using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FingerprintApplication.Forms
{
    public partial class EditForm : Form
    {

        People document;
        MongoClient client;
        IMongoDatabase database;
        People currentPeople;
        public EditForm()
        {
            InitializeComponent();
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("fingerprint_authentication_database");
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            fillTable();
        }

        private void fillTable()
        {
            var peopleCollection = database.GetCollection<People>("people");
            List<People> peopleList = peopleCollection.Find(FilterDefinition<People>.Empty).ToList();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(ObjectId));
            dataTable.Columns.Add("Folder Name", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Surname", typeof(string));
            dataTable.Columns.Add("Fathers Name", typeof(string));

            foreach (var person in peopleList)
            {
                dataTable.Rows.Add(person._id, person.FolderName, person.Name, person.Surname, person.FathersName);
            }

            dataGridView.DataSource = dataTable;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                var peopleCollection = database.GetCollection<People>("people");
                var folderNameFilter = Builders<People>.Filter.Eq(p => p.FolderName, row.Cells["Folder Name"].Value?.ToString());
                var document = peopleCollection.Find(folderNameFilter).ToList();
                try { 
                    currentPeople = document[0];
                    // Assuming textBox1, textBox2, textBox3, and textBox4 are for Folder Name, Name, Surname, and Father's Name respectively
                    folderNameText.Text = row.Cells["Folder Name"].Value?.ToString();
                    nameText.Text = row.Cells["Name"].Value?.ToString();
                    surnameText.Text = row.Cells["Surname"].Value?.ToString();
                    fathersNameText.Text = row.Cells["Fathers Name"].Value?.ToString();

                    mothersNameText.Text = document[0].MothersName?.ToString();
                    date_ofBirth.Value = document[0].DateofBirth;
                    placeOfBirthText.Text = document[0].PlaceOfBirth?.ToString();
                    homeAdressText.Text = document[0].PlaceOfResidence?.ToString();
                    diata3iText.Text = document[0].Diata3i?.ToString();
                    fromDayText.Text = document[0].WhenShowup.StartDate.ToString();
                    toDayText.Text = document[0].WhenShowup.EndDate.ToString();
                    endOfRecursionDate.Value = document[0].WhenShowup.EndOfRecursion;
                } catch (Exception exception){ }
               
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(fromDayText.Text, out int fromDayInt))
            {
                if (int.TryParse(toDayText.Text, out int toDayInt))
                {
                    Appearances appearances = new Appearances(fromDayInt, toDayInt, endOfRecursionDate.Value);
                    var person = new People(
                        folderNameText.Text, nameText.Text, surnameText.Text, fathersNameText.Text, appearances, mothersNameText.Text, date_ofBirth.Value, placeOfBirthText.Text, homeAdressText.Text, diata3iText.Text, currentPeople.fingerprint_data, currentPeople.appearances
                    );
                    person._id = currentPeople._id;
                    var folderNameFilter = Builders<People>.Filter.Eq(p => p.FolderName, currentPeople.FolderName);
                    var peopleCollection = database.GetCollection<People>("people");
                    var options = new FindOneAndReplaceOptions<People>
                    {
                        ReturnDocument = ReturnDocument.After
                    };

                    peopleCollection.FindOneAndReplace(folderNameFilter, person, options);

                    MessageBox.Show("Επιτυχής Αποθύκευση των αλλαγών");
                    return;
                }
            }
            MessageBox.Show("Αποτυχία");
            return;
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {

            if (currentPeople == null || currentPeople.FolderName == null)
            {
                MessageBox.Show("Επιλέξτε κάποιο χρήστη απο τη λίστα , Ανεπιτυχής Διαγραφή");
                return;
            }
            var folderNameFilter = Builders<People>.Filter.Eq(p => p.FolderName, currentPeople.FolderName);
            var peopleCollection = database.GetCollection<People>("people");
            peopleCollection.FindOneAndDelete(folderNameFilter);
            this.Refresh();
            MessageBox.Show("Επιτυχής Διαγραφή");

        }
    }
}
