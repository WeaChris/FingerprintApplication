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

namespace FingerprintApplication.Forms
{
    public partial class HomeForm : Form
    {
        People document;
        MongoClient client;
        IMongoDatabase database;
        public HomeForm()
        {
            InitializeComponent();
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("fingerprint_authentication_database");


        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            fillTable();
        }

        private void fillTable()
        {
            var peopleCollection = database.GetCollection<People>("people");
            List<People> peopleList = peopleCollection.Find(FilterDefinition<People>.Empty).ToList();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(ObjectId));
            dataTable.Columns.Add("Αριθμός Φακέλου", typeof(string));
            dataTable.Columns.Add("Όνομα", typeof(string));
            dataTable.Columns.Add("Επίθετο", typeof(string));
            dataTable.Columns.Add("Πατρώνυμο", typeof(string));

            foreach (var person in peopleList)
            {
                dataTable.Rows.Add(person._id, person.FolderName, person.Name, person.Surname, person.FathersName);
            }

            dataGridView1.DataSource = dataTable;
        }

    }
}
