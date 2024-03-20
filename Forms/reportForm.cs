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
            if (dateTimePickerStart.Value <= dateTimePickerEnd.Value) {
                StartDate = dateTimePickerStart.Value;
                EndDate = dateTimePickerEnd.Value;
                

            }
            else
            {
                MessageBox.Show("The start date must be before the end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
