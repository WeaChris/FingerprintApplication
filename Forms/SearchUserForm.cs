using libzkfpcsharp;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.IO.Font;
using System.Globalization;

namespace FingerprintApplication.Forms
{
    public partial class SearchUserForm : Form
    {
        People document;
        MongoClient client;
        IMongoDatabase database;

        IntPtr mDevHandle = IntPtr.Zero;
        IntPtr mDBHandle = IntPtr.Zero;
        IntPtr FormHandle = IntPtr.Zero;
        bool bIsTimeToDie = false;
        bool IsRegister = false;
        bool bIdentify = true;
        byte[] FPBuffer;
        int RegisterCount = 0;
        const int REGISTER_FINGER_COUNT = 3;

        byte[][] RegTmps = new byte[3][];
        byte[] RegTmp = new byte[2048];
        byte[] CapTmp = new byte[2048];
        int cbCapTmp = 2048;
        int cbRegTmp = 0;
        int iFid = 1;
        Thread captureThread = null;

        private int mfpWidth = 0;
        private int mfpHeight = 0;

        const int MESSAGE_CAPTURED_OK = 0x0400 + 6;

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        public SearchUserForm()
        {
            InitializeComponent();
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("fingerprint_authentication_database");

            nameLabel.Text = "";
            surnameLabel.Text = "";
            fathersName.Text = "";
            whenShowLabel.Text = "";
            folderNameLabel.Text = "";
            button1.Enabled = false;
            button3.Enabled = false;
        }

        private void DoCapture2()
        {
            while (!bIsTimeToDie)
            {
                cbCapTmp = 2048;
                int ret = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
                if (ret == zkfp.ZKFP_ERR_OK)
                {
                    SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero);

                    if (IntPtr.Zero != mDevHandle)
                    {
                        Console.WriteLine("HERE 1-------------------------");
                        bIsTimeToDie = true;
                        zkfp2.CloseDevice(mDevHandle);
                        mDevHandle = IntPtr.Zero;
                        zkfp2.Terminate();
                        Console.WriteLine("HERE 2-------------------------");
                        cbRegTmp = 0;
                        captureThread.Join();
                        Console.WriteLine("HERE 3-------------------------");
                    }
                }
            }
        }

        protected override void DefWndProc(ref Message m)
        {

            switch (m.Msg)
            {
                case MESSAGE_CAPTURED_OK:
                    {
                        MemoryStream ms = new MemoryStream();
                        BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, ref ms);
                        Bitmap bmp = new Bitmap(ms);
                        this.picFPImg.Image = bmp;

                        String strBase64 = zkfp2.BlobToBase64(CapTmp, cbCapTmp);
                        byte[] blob = zkfp2.Base64ToBlob(strBase64);


                        Debug.WriteLine(CapTmp);
                        break;
                    }
                default:
                    {
                        base.DefWndProc(ref m);
                        break;
                    }
            }

        }

        private People searchFingerprintInDatabase()
        {
            var peopleCollection = database.GetCollection<People>("people");
            var filter = Builders<People>.Filter.Empty;
            var documents = peopleCollection.Find(filter).ToList();

            foreach (var document in documents)
            {

                int result = zkfp2.DBMatch(mDBHandle, CapTmp, document.fingerprint_data);
                System.Diagnostics.Debug.WriteLine($" RESULT : {result}");
                if (result > 100)
                {
                    //SUCCEED
                    return document;
                }
                else
                {
                    //LOW SCORE
                    System.Diagnostics.Debug.WriteLine($"FAILED WITH {result}");

                }
            }
            return null;
        }

        private People searchFingerprintInDatabaseWithoutBio()
        {
            var peopleCollection = database.GetCollection<People>("people");
            var folderNameFilter = Builders<People>.Filter.Eq(p => p.FolderName, folderNameText.Text);
            var nameFilter = Builders<People>.Filter.Eq(p => p.Name, nameText.Text);
            var surnameFilter = Builders<People>.Filter.Eq(p => p.Surname, surnameText.Text);
            var dateOfBirthFilter = Builders<People>.Filter.Eq(p => p.DateofBirth, date_ofBirth.Value);
            var fathersNameFilter = Builders<People>.Filter.Eq(p => p.FathersName, fathersNameText.Text);

            var combinedFilter = (nameFilter & surnameFilter & dateOfBirthFilter & fathersNameFilter) | folderNameFilter;

            var documents = peopleCollection.Find(combinedFilter).ToList();

            if (documents.Count() > 1)
            {
                return null;
            }
            else if (documents.Any())
            {
                return documents[0];
            }

            return null;
        }


        private void searchUser_Load(object sender, EventArgs e)
        {
            FormHandle = this.Handle;
        }

        //Epivevaiwsi emfanisis Button
        private void button3_Click(object sender, EventArgs e)
        {

            DateTime utcNow = DateTime.UtcNow;
            DateTime currentDate = utcNow.AddHours(3);

            var peopleCollection = database.GetCollection<People>("people");

            var filter = Builders<People>.Filter.Eq("folderName", this.document.FolderName);
            var update = Builders<People>.Update.Push("appearances", currentDate);

            peopleCollection.UpdateOne(filter, update);
            MessageBox.Show("Επιβεβαίωση Επιτυχής!");
            button1.Enabled = true;
        }

        private void startScanner_Click(object sender, EventArgs e)
        {
            //INITIALIZATION

            int ret = zkfperrdef.ZKFP_ERR_OK;
            if ((ret = zkfp2.Init()) == zkfperrdef.ZKFP_ERR_OK)
            {
                int nCount = zkfp2.GetDeviceCount();
                if (nCount > 0)
                {

                    //OPEN DEVICE AND READY FOR CAPTURE

                    int ret2 = zkfp.ZKFP_ERR_OK;
                    if (IntPtr.Zero == (mDevHandle = zkfp2.OpenDevice(0)))
                    {
                        MessageBox.Show("Αποτυχία");
                        return;
                    }
                    if (IntPtr.Zero == (mDBHandle = zkfp2.DBInit()))
                    {
                        MessageBox.Show("Init DB fail");
                        zkfp2.CloseDevice(mDevHandle);
                        mDevHandle = IntPtr.Zero;
                        return;
                    }

                    RegisterCount = 0;
                    cbRegTmp = 0;
                    iFid = 1;

                    for (int i = 0; i < 3; i++)
                    {
                        RegTmps[i] = new byte[2048];
                    }
                    byte[] paramValue = new byte[4];
                    int size = 4;
                    zkfp2.GetParameters(mDevHandle, 1, paramValue, ref size);
                    zkfp2.ByteArray2Int(paramValue, ref mfpWidth);

                    size = 4;
                    zkfp2.GetParameters(mDevHandle, 2, paramValue, ref size);
                    zkfp2.ByteArray2Int(paramValue, ref mfpHeight);

                    FPBuffer = new byte[mfpWidth * mfpHeight];

                    captureThread = new Thread(new ThreadStart(DoCapture2));
                    captureThread.IsBackground = true;
                    captureThread.Start();
                    bIsTimeToDie = false;
                    loggingLabel.Text = "Open succeeded";
                }
                else
                {
                    zkfp2.Terminate();
                    loggingLabel.Text = "No device connected!";
                    MessageBox.Show("Δεν υπάρχει συσκευή αναγνώρισης δακτυλικού");
                }
            }
            else
            {
                MessageBox.Show("Initialize fail, ret=" + ret + " !");
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.document = searchFingerprintInDatabase();
            if (document != null)
            {
                nameLabel.Text = document.Name;
                surnameLabel.Text = document.Surname;
                fathersName.Text = document.FathersName;
                whenShowLabel.Text = $"Από {document.WhenShowup.StartDate.ToString()} μέχρι {document.WhenShowup.EndDate.ToString()}";
                folderNameLabel.Text = document.FolderName;
                button3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Δεν βρέθηκε χρήστης");
            }
        }

        private void searchWithoutBio_Click(object sender, EventArgs e)
        {
            this.document = searchFingerprintInDatabaseWithoutBio();
            if (document != null)
            {
                nameLabel.Text = document.Name;
                surnameLabel.Text = document.Surname;
                fathersName.Text = document.FathersName;
                whenShowLabel.Text = $"Από {document.WhenShowup.StartDate.ToString()} μέχρι {document.WhenShowup.EndDate.ToString()}";
                folderNameLabel.Text = document.FolderName;
                button3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Δεν βρέθηκε χρήστης");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Find the Greek timezone by its identifier
            TimeZoneInfo greekTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GTB Standard Time");

            // Convert the UTC time to Greek time
            DateTime greekTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, greekTimeZone);

            // CultureInfo for Greek
            CultureInfo greekCulture = new CultureInfo("el-GR");

            // Get the day of the week in Greek
            string dayOfWeekInGreek = greekTime.ToString("dddd", greekCulture);

            // Get the current time without seconds in Greek time
            string currentTimeWithoutSeconds = greekTime.ToString("HH:mm");


            //DateTime utcNow = DateTime.UtcNow;
            //DateTime currentDate = utcNow.AddHours(3);
            //CultureInfo greekCulture = new CultureInfo("el-GR");
            //string dayOfWeekInGreek = currentDate.ToString("dddd", greekCulture);
            //string currentTimeWithoutSeconds = currentDate.ToString("HH:mm");

            // Create a new PDF document
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter("Report.pdf"));

            // Create a document instance
            Document document = new Document(pdfDoc);

            // Create a font for Greek text
            PdfFont greekFont = PdfFontFactory.CreateFont("fonts/liberation-sans-italic.ttf", PdfEncodings.IDENTITY_H);

            // Create a paragraph with the title
            Paragraph title = new Paragraph("ΕΚΘΕΣΗ ΕΜΦΑΝΙΣΕΩΣ")
                .SetFontSize(28)
                .SetFont(greekFont)
                .SetBold()
                .SetTextAlignment(TextAlignment.CENTER);

            document.Add(title);

            // Add the dynamic content
            string dynamicContent = $"Στου Ζωγράφου, σήμερα την {greekTime.Day} του μηνός {greekTime.Month} του έτους {greekTime.Year}, ημέρα της εβδομάδος {dayOfWeekInGreek} και ώρα {currentTimeWithoutSeconds} ," +
                $" ενώπιον εμού του ....................................................... , Αξιωματικου Υπηρεσίας του Τμήματος Ασφαλείας Ζωγράφου , επί παρουσία και του ....................................." +
                $".......... προσληφθέντος ως Β Ανακριτικού Υπαλλήλου , υπηρετούντος στο Τμήμα Ασφαλείας Ζωγράφου , εμφανίστηκε ο/η {this.document.Name} {this.document.Surname} του {this.document.FathersName} , κάτοικος επί της οδού {this.document.PlaceOfResidence} " +
                $", στου Ζωγράφου Αττικής , ο/η υποχρεούται εμφάνισης στην Υπηρεσία μας , σύμφωνα με την/ις υπ'αριθμ:.............................................................................................." +
                $"..................................................................................................................................................................................................." +
                $"............................................................. με την/ις οποιας/ες επιβλήθηκε το περιοριστικό μέτρο της εμφανίσεως του/ης , ενωπίον της Αστυνομκης αρχής του τόπου κατοικίας του/ης.";


            Paragraph dynamicContentParagraph = new Paragraph(dynamicContent)
                .SetFont(greekFont)
                .SetTextAlignment(TextAlignment.LEFT);

            document.Add(dynamicContentParagraph);

            // Add empty lines
            for (int i = 0; i < 3; i++)
            {
                document.Add(new Paragraph(" ").SetFont(greekFont));
            }

            // Create a paragraph for the signatures
            Paragraph signatures = new Paragraph()
                .Add("Αξιωματικός υπηρεσίας").Add("\t\t\t\t\t\t").Add("Β' Ανακριτικός Υπάλληλος").Add("\t\t\t\t\t\t").Add("Εμφανισθείς")
                .SetFont(greekFont);

            document.Add(signatures);

            // Close the document
            document.Close();

            // Display a message
            Console.WriteLine("PDF document generated successfully.");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
