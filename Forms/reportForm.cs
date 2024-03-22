using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.IO.Font;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerprintApplication.Forms
{
    public partial class reportForm : Form
    {
        MongoClient client;
        IMongoDatabase database;
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public reportForm()
        {
            InitializeComponent();
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("fingerprint_authentication_database");
            dateTimePickerStart.Value = DateTime.Today;
            dateTimePickerEnd.Value = DateTime.Today;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            fillTable();
            month.Text = DateTime.UtcNow.AddHours(3).ToString("MMMM", CultureInfo.InvariantCulture);
        }

        private void fillTable()
        {
            var peopleCollection = database.GetCollection<People>("people");
            List<People> peopleList = peopleCollection.Find(FilterDefinition<People>.Empty).ToList();

            DataTable dataTable1 = new DataTable();
            DataTable dataTable2 = new DataTable();

            dataTable1.Columns.Add("Id", typeof(ObjectId));
            dataTable1.Columns.Add("Folder Name", typeof(string));
            dataTable1.Columns.Add("Name", typeof(string));
            dataTable1.Columns.Add("Surname", typeof(string));
            dataTable1.Columns.Add("Fathers Name", typeof(string));

            dataTable2.Columns.Add("Id", typeof(ObjectId));
            dataTable2.Columns.Add("Folder Name", typeof(string));
            dataTable2.Columns.Add("Name", typeof(string));
            dataTable2.Columns.Add("Surname", typeof(string));
            dataTable2.Columns.Add("Fathers Name", typeof(string));

            string month = DateTime.UtcNow.AddHours(3).ToString("MM", CultureInfo.InvariantCulture);

            System.Diagnostics.Debug.WriteLine("Got here 1"); // Print a string to the console
            foreach (var person in peopleList)
            {
                Boolean showuptrue = false;
                foreach (DateTime date in person.appearances)
                {
                    System.Diagnostics.Debug.WriteLine(" --> " + date.Month.ToString() + " --> " + month);

                    if (date.Month.ToString("D2") == month)
                    {
                        System.Diagnostics.Debug.WriteLine($"Month {date.Month.ToString()} and {month}"); // Print a string to the console
                        System.Diagnostics.Debug.WriteLine($"Start Date : {person.WhenShowup.StartDate} and End Date : {person.WhenShowup.EndDate} and today is : {date.Day}");
                        if (person.WhenShowup.StartDate <= date.Day && date.Day <= person.WhenShowup.EndDate)
                        {
                            System.Diagnostics.Debug.WriteLine($"Start {person.WhenShowup.StartDate} and date.day {date.Day} and end {person.WhenShowup.EndDate}"); // Print a string to the console
                            showuptrue = true;
                        }
                    }


                }
                if (showuptrue)
                {
                    dataTable1.Rows.Add(person._id, person.FolderName, person.Name, person.Surname, person.FathersName);
                }
                else
                {
                    dataTable2.Rows.Add(person._id, person.FolderName, person.Name, person.Surname, person.FathersName);
                }
            }

            reportTableforUsers1.DataSource = dataTable1;
            reportTableforUsers2.DataSource = dataTable2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<People> showedUp = new List<People>();
            List<People> notShowedUp = new List<People>();
            // Create a new PDF document
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter("Report2.pdf"));

            // Create a document instance
            Document document = new Document(pdfDoc);

            // Create a font for Greek text
            PdfFont greekFont = PdfFontFactory.CreateFont("fonts/liberation-sans-italic.ttf", PdfEncodings.IDENTITY_H);

            // Create a paragraph with the title
            Paragraph title = new Paragraph("ΦΟΡΜΑ ΠΑΡΟΥΣΙΩΝ")
                .SetFontSize(28)
                .SetFont(greekFont)
                .SetBold()
                .SetTextAlignment(TextAlignment.CENTER);

            document.Add(title);

            Table showedUpTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1, 1 , 1})).UseAllAvailableWidth();
            Table notShowedUpTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1, 1 })).UseAllAvailableWidth();

            // Add headers to each table
            Paragraph showedUpHeader = new Paragraph("Εμφανισθέντες")
            .SetFont(greekFont)
            .SetBold()
            .SetFontSize(16)
            .SetTextAlignment(TextAlignment.CENTER);


            Paragraph notShowedUpHeader = new Paragraph("Μη Εμφανισθέντες")
            .SetFont(greekFont)
            .SetBold()
            .SetFontSize(16)
            .SetTextAlignment(TextAlignment.CENTER);


            if (dateTimePickerStart.Value <= dateTimePickerEnd.Value)
            {
                StartDate = dateTimePickerStart.Value;
                EndDate = dateTimePickerEnd.Value;
                string dateRange = $" {StartDate.Date.ToString("dd/MM/yyyy")} - {EndDate.Date.ToString("dd/MM/yyyy")}";
                Paragraph dateRangeParagraph = new Paragraph(dateRange)
                .SetFontSize(12) // You can adjust the font size as needed
                .SetTextAlignment(TextAlignment.CENTER);

                showedUpTable.AddHeaderCell(new Cell().Add(new Paragraph("Αριθμός Φακέλου Υπόθεσης").SetFont(greekFont)).SetBold());
                showedUpTable.AddHeaderCell(new Cell().Add(new Paragraph("Όνομα").SetFont(greekFont)).SetBold());
                showedUpTable.AddHeaderCell(new Cell().Add(new Paragraph("Επίθετο").SetFont(greekFont)).SetBold());
                showedUpTable.AddHeaderCell(new Cell().Add(new Paragraph("Ημερομηνία Εμφάνισης").SetFont(greekFont)).SetBold());

                notShowedUpTable.AddHeaderCell(new Cell().Add(new Paragraph("Αριθμός Φακέλου Υπόθεσης").SetFont(greekFont)).SetBold());
                notShowedUpTable.AddHeaderCell(new Cell().Add(new Paragraph("Όνομα").SetFont(greekFont)).SetBold());
                notShowedUpTable.AddHeaderCell(new Cell().Add(new Paragraph("Επίθετο").SetFont(greekFont)).SetBold());

                var peopleCollection = database.GetCollection<People>("people");
                List<People> peopleList = peopleCollection.Find(FilterDefinition<People>.Empty).ToList();
                foreach (var person in peopleList)
                {
                    var showedUpBool = false;
                    foreach (DateTime date in person.appearances)
                    {
                        if (StartDate.Date <= date.Date && date.Date <= EndDate.Date && person.WhenShowup.StartDate <= date.Day && date.Day <= person.WhenShowup.EndDate)
                        {
                            showedUpTable.AddCell(new Cell().Add(new Paragraph(person.FolderName).SetFont(greekFont)));
                            showedUpTable.AddCell(new Cell().Add(new Paragraph(person.Name).SetFont(greekFont)));
                            showedUpTable.AddCell(new Cell().Add(new Paragraph(person.Surname).SetFont(greekFont)));
                            showedUpTable.AddCell(new Cell().Add(new Paragraph(date.Date.ToString("dd/MM/yyyy hh:mm tt")).SetFont(greekFont)));
                            showedUpBool = true;
                            break;
                        }
                    }
                    if (showedUpBool == false)
                    {
                        notShowedUpTable.AddCell(new Cell().Add(new Paragraph(person.FolderName).SetFont(greekFont)));
                        notShowedUpTable.AddCell(new Cell().Add(new Paragraph(person.Name).SetFont(greekFont)));
                        notShowedUpTable.AddCell(new Cell().Add(new Paragraph(person.Surname).SetFont(greekFont)));

                    }
                }

                document.Add(dateRangeParagraph);
                document.Add(new Paragraph("\n"));
                document.Add(showedUpHeader);
                document.Add(showedUpTable);
                document.Add(new Paragraph("\n")); // Optional: add some space between tables
                document.Add(notShowedUpHeader);
                document.Add(notShowedUpTable);
                document.Close();
            }
            else
            {
                MessageBox.Show("The start date must be before the end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usersDataPrint_Click(object sender, EventArgs e)
        {
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter("Report3.pdf"));

            // Create a document instance
            Document document = new Document(pdfDoc);

            // Create a font for Greek text
            PdfFont greekFont = PdfFontFactory.CreateFont("fonts/liberation-sans-italic.ttf", PdfEncodings.IDENTITY_H);

            // Create a paragraph with the title
            Paragraph title = new Paragraph("ΣΤΟΙΧΕΙΑ ΠΑΡΟΥΣΙΑΖΟΜΕΝΩΝ")
                .SetFontSize(28)
                .SetFont(greekFont)
                .SetBold()
                .SetTextAlignment(TextAlignment.CENTER);

            
            var peopleCollection = database.GetCollection<People>("people");
            List<People> peopleList = peopleCollection.Find(FilterDefinition<People>.Empty).ToList();
            Table usersTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1, 1, 1, 1, 1, 1, 1})).UseAllAvailableWidth();

            usersTable.AddHeaderCell(new Cell().Add(new Paragraph("Αριθμός Φακέλου Υπόθεσης").SetFont(greekFont)).SetBold());
            usersTable.AddHeaderCell(new Cell().Add(new Paragraph("Όνομα").SetFont(greekFont)).SetBold());
            usersTable.AddHeaderCell(new Cell().Add(new Paragraph("Επίθετο").SetFont(greekFont)).SetBold());
            usersTable.AddHeaderCell(new Cell().Add(new Paragraph("Όνομα Πατέρα").SetFont(greekFont)).SetBold());
            usersTable.AddHeaderCell(new Cell().Add(new Paragraph("Όνομα Μητέρας").SetFont(greekFont)).SetBold());
            usersTable.AddHeaderCell(new Cell().Add(new Paragraph("Ημερομηνία Γέννησης").SetFont(greekFont)).SetBold());
            usersTable.AddHeaderCell(new Cell().Add(new Paragraph("Τοπ. Γέννησης").SetFont(greekFont)).SetBold());
            usersTable.AddHeaderCell(new Cell().Add(new Paragraph("Τοπ. Κατοικίας").SetFont(greekFont)).SetBold());

            foreach (People person in peopleList)
            {
                usersTable.AddCell(new Cell().Add(new Paragraph(person.FolderName).SetFont(greekFont)));
                usersTable.AddCell(new Cell().Add(new Paragraph(person.Name).SetFont(greekFont)));
                usersTable.AddCell(new Cell().Add(new Paragraph(person.Surname).SetFont(greekFont)));
                usersTable.AddCell(new Cell().Add(new Paragraph(person.FathersName).SetFont(greekFont)));
                usersTable.AddCell(new Cell().Add(new Paragraph(person.MothersName).SetFont(greekFont)));
                usersTable.AddCell(new Cell().Add(new Paragraph(person.DateofBirth.ToString()).SetFont(greekFont)));
                usersTable.AddCell(new Cell().Add(new Paragraph(person.PlaceOfBirth).SetFont(greekFont)));
                usersTable.AddCell(new Cell().Add(new Paragraph(person.PlaceOfResidence).SetFont(greekFont)));
            }

            document.Add(title);
            document.Add(new Paragraph("\n"));
            document.Add(usersTable);
            document.Close();
        }
    }
}
