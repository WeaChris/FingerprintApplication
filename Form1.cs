namespace FingerprintApplication
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(childForm);
            this.mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //titleLabel.Text = childForm.Text;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.HomeForm(), sender);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.AddUserForm(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.SearchUserForm(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.reportForm(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.EditForm(), sender);
        }
    }
}