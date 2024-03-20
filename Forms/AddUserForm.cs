using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using libzkfpcsharp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Diagnostics;
using MongoDB.Driver;

namespace FingerprintApplication.Forms
{
    public partial class AddUserForm : Form
    {

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
        public AddUserForm()
        {
            InitializeComponent();
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("fingerprint_authentication_database");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoCapture()
        {
            while (!bIsTimeToDie)
            {
                cbCapTmp = 2048;
                int ret = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
                if (ret == zkfp.ZKFP_ERR_OK)
                {
                    SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero);
                }
                Thread.Sleep(200);
            }
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
                        bIsTimeToDie = true;
                        zkfp2.CloseDevice(mDevHandle);
                        mDevHandle = IntPtr.Zero;
                        zkfp2.Terminate();
                        cbRegTmp = 0;
                        captureThread.Join();
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
                        break;
                    }
                default:
                    {
                        base.DefWndProc(ref m);
                        break;
                    }
            }

        }

        private void createAndPostUser(byte[] CapTmp)
        {
            var peopleCollection = database.GetCollection<People>("people");
            string whenTextString = whenText.Text;
            string[] numericText = whenTextString.Split('-');
            int[] integers = new int[numericText.Length];

            DateTime selectedDate = dateTimePicker1.Value;


            for (int i = 0; i < numericText.Length; i++)
            {
                if (int.TryParse(numericText[i], out int parsedInt))
                {
                    integers[i] = parsedInt;
                }
                else
                {
                    // Invalid input, handle the error as needed
                    MessageBox.Show($"Οι ημερες στο διάστημα εμφάνισης πρεπει να διαχωρίζονται με το χαρακτήρα - , Για παράδειγμα 1-5");
                    return; // Exit the method if there's an invalid input
                }
            }
            Appearances appearances = new Appearances(integers[0], integers[1], selectedDate);
            var person = new People(
                folderNameText.Text, nameText.Text, surnameText.Text, fathersNameText.Text, appearances, mothersNameText.Text, date_ofBirth.Value, placeOfBirthText.Text, homeAdressText.Text, diata3iText.Text, CapTmp, new Object[0]
            );

            peopleCollection.InsertOne(person);
            MessageBox.Show("Επιτυχής Δημιουργία");
        }

        private void addUsers_Load(object sender, EventArgs e)
        {
            FormHandle = this.Handle;
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            createAndPostUser(CapTmp);

        }

        private void button1_Click_1(object sender, EventArgs e)
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
                        MessageBox.Show("OpenDevice fail");
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
                    MessageBox.Show("No device connected!");
                }
            }
            else
            {
                MessageBox.Show("Initialize fail, ret=" + ret + " !");
            }



        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var peopleCollection = database.GetCollection<People>("people");

            string whenTextString = whenText.Text;
            string[] numericText = whenTextString.Split('-');
            int[] integers = new int[numericText.Length];

            DateTime selectedDate = dateTimePicker1.Value;
            Appearances appearances = null;

            if (integers.Length == 1)
            {
                appearances = new Appearances(integers[0], integers[0], selectedDate);
            }
            else
            {
                appearances = new Appearances(integers[0], integers[1], selectedDate);
            }

            for (int i = 0; i < numericText.Length; i++)
            {

                if (int.TryParse(numericText[i], out int parsedInt))
                {
                    integers[i] = parsedInt;
                }
                else
                {
                    // Invalid input, handle the error as needed
                    MessageBox.Show($"Οι ημερες στο διάστημα εμφάνισης πρεπει να διαχωρίζονται με το χαρακτήρα - , Για παράδειγμα 1-5");
                    return; // Exit the method if there's an invalid input
                }
            }

            var person = new People(
                folderNameText.Text, nameText.Text, surnameText.Text, fathersNameText.Text, appearances, mothersNameText.Text, date_ofBirth.Value, placeOfBirthText.Text, homeAdressText.Text, diata3iText.Text, Array.Empty<byte>(), new Object[0]
            );

            peopleCollection.InsertOne(person);
            MessageBox.Show("Succesfully added User");
        }
    }
}
