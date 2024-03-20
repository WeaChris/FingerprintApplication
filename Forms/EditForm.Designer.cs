namespace FingerprintApplication.Forms
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            splitContainer1 = new SplitContainer();
            dataGridView = new DataGridView();
            deleteUserButton = new Button();
            saveChangesButton = new Button();
            deleteFingerprintButton = new Button();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            endOfRecursionDate = new DateTimePicker();
            toDayText = new TextBox();
            label12 = new Label();
            fromDayText = new TextBox();
            label11 = new Label();
            label10 = new Label();
            placeOfBirthText = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            diata3iText = new TextBox();
            homeAdressText = new TextBox();
            label6 = new Label();
            date_ofBirth = new DateTimePicker();
            mothersNameText = new TextBox();
            label1 = new Label();
            fathersNameText = new TextBox();
            surnameText = new TextBox();
            nameText = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            folderNameText = new TextBox();
            openScanner = new Button();
            closeScannerButton = new Button();
            initializeScanner = new Button();
            freeScannerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(deleteUserButton);
            splitContainer1.Panel2.Controls.Add(saveChangesButton);
            splitContainer1.Panel2.Controls.Add(deleteFingerprintButton);
            splitContainer1.Panel2.Controls.Add(label17);
            splitContainer1.Panel2.Controls.Add(label16);
            splitContainer1.Panel2.Controls.Add(label15);
            splitContainer1.Panel2.Controls.Add(label14);
            splitContainer1.Panel2.Controls.Add(label13);
            splitContainer1.Panel2.Controls.Add(endOfRecursionDate);
            splitContainer1.Panel2.Controls.Add(toDayText);
            splitContainer1.Panel2.Controls.Add(label12);
            splitContainer1.Panel2.Controls.Add(fromDayText);
            splitContainer1.Panel2.Controls.Add(label11);
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Panel2.Controls.Add(placeOfBirthText);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(diata3iText);
            splitContainer1.Panel2.Controls.Add(homeAdressText);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(date_ofBirth);
            splitContainer1.Panel2.Controls.Add(mothersNameText);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(fathersNameText);
            splitContainer1.Panel2.Controls.Add(surnameText);
            splitContainer1.Panel2.Controls.Add(nameText);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(folderNameText);
            splitContainer1.Panel2.Controls.Add(openScanner);
            splitContainer1.Panel2.Controls.Add(closeScannerButton);
            splitContainer1.Panel2.Controls.Add(initializeScanner);
            splitContainer1.Panel2.Controls.Add(freeScannerButton);
            splitContainer1.Size = new Size(1219, 715);
            splitContainer1.SplitterDistance = 630;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(511, 685);
            dataGridView.TabIndex = 1;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // deleteUserButton
            // 
            deleteUserButton.BackgroundImage = (Image)resources.GetObject("deleteUserButton.BackgroundImage");
            deleteUserButton.Location = new Point(463, 627);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(48, 56);
            deleteUserButton.TabIndex = 70;
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // saveChangesButton
            // 
            saveChangesButton.BackgroundImage = (Image)resources.GetObject("saveChangesButton.BackgroundImage");
            saveChangesButton.Location = new Point(273, 627);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(53, 56);
            saveChangesButton.TabIndex = 69;
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // deleteFingerprintButton
            // 
            deleteFingerprintButton.Image = (Image)resources.GetObject("deleteFingerprintButton.Image");
            deleteFingerprintButton.Location = new Point(69, 627);
            deleteFingerprintButton.Name = "deleteFingerprintButton";
            deleteFingerprintButton.Size = new Size(64, 56);
            deleteFingerprintButton.TabIndex = 68;
            deleteFingerprintButton.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F);
            label17.ForeColor = Color.Blue;
            label17.Location = new Point(224, 592);
            label17.Name = "label17";
            label17.Size = new Size(160, 20);
            label17.TabIndex = 67;
            label17.Text = "Αποθήκευση αλλαγών";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(411, 592);
            label16.Name = "label16";
            label16.Size = new Size(149, 20);
            label16.TabIndex = 66;
            label16.Text = "Διαγραφή Εγγραφής";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F);
            label15.ForeColor = Color.FromArgb(255, 128, 128);
            label15.Location = new Point(17, 592);
            label15.Name = "label15";
            label15.Size = new Size(186, 20);
            label15.TabIndex = 65;
            label15.Text = "Διαγραφή Αποτυπώματος";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label14.Location = new Point(224, 12);
            label14.Name = "label14";
            label14.Size = new Size(150, 25);
            label14.TabIndex = 64;
            label14.Text = "Γενικά Στοιχεια";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F);
            label13.Location = new Point(295, 524);
            label13.Name = "label13";
            label13.Size = new Size(101, 20);
            label13.TabIndex = 63;
            label13.Text = "Ημ. Διακοπής";
            // 
            // endOfRecursionDate
            // 
            endOfRecursionDate.Location = new Point(402, 521);
            endOfRecursionDate.Name = "endOfRecursionDate";
            endOfRecursionDate.Size = new Size(166, 23);
            endOfRecursionDate.TabIndex = 62;
            // 
            // toDayText
            // 
            toDayText.Location = new Point(209, 523);
            toDayText.Name = "toDayText";
            toDayText.Size = new Size(68, 23);
            toDayText.TabIndex = 61;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F);
            label12.Location = new Point(153, 523);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 60;
            label12.Text = "Μέχρι";
            // 
            // fromDayText
            // 
            fromDayText.Location = new Point(65, 523);
            fromDayText.Name = "fromDayText";
            fromDayText.Size = new Size(68, 23);
            fromDayText.TabIndex = 59;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F);
            label11.Location = new Point(22, 526);
            label11.Name = "label11";
            label11.Size = new Size(37, 20);
            label11.TabIndex = 58;
            label11.Text = "Από";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label10.Location = new Point(156, 471);
            label10.Name = "label10";
            label10.Size = new Size(313, 25);
            label10.TabIndex = 57;
            label10.Text = "Ημέρες του μήνα προς εμφάνιση";
            // 
            // placeOfBirthText
            // 
            placeOfBirthText.Location = new Point(435, 262);
            placeOfBirthText.Name = "placeOfBirthText";
            placeOfBirthText.Size = new Size(125, 23);
            placeOfBirthText.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(312, 265);
            label9.Name = "label9";
            label9.Size = new Size(119, 20);
            label9.TabIndex = 55;
            label9.Text = "Τόπος Γέννησης";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(22, 421);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 54;
            label8.Text = "Διάταξη";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(22, 346);
            label7.Name = "label7";
            label7.Size = new Size(151, 20);
            label7.TabIndex = 53;
            label7.Text = "Διεύθυνση Κατοικίας";
            // 
            // diata3iText
            // 
            diata3iText.Location = new Point(156, 418);
            diata3iText.Name = "diata3iText";
            diata3iText.Size = new Size(125, 23);
            diata3iText.TabIndex = 52;
            // 
            // homeAdressText
            // 
            homeAdressText.Location = new Point(190, 343);
            homeAdressText.Name = "homeAdressText";
            homeAdressText.Size = new Size(166, 23);
            homeAdressText.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(22, 268);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 48;
            label6.Text = "Ημ. Γέννησης";
            // 
            // date_ofBirth
            // 
            date_ofBirth.Location = new Point(137, 265);
            date_ofBirth.Name = "date_ofBirth";
            date_ofBirth.Size = new Size(166, 23);
            date_ofBirth.TabIndex = 46;
            // 
            // mothersNameText
            // 
            mothersNameText.Location = new Point(435, 197);
            mothersNameText.Name = "mothersNameText";
            mothersNameText.Size = new Size(125, 23);
            mothersNameText.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(312, 199);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 44;
            label1.Text = "Όνομα μητέρας";
            // 
            // fathersNameText
            // 
            fathersNameText.Location = new Point(156, 196);
            fathersNameText.Name = "fathersNameText";
            fathersNameText.Size = new Size(125, 23);
            fathersNameText.TabIndex = 43;
            // 
            // surnameText
            // 
            surnameText.Location = new Point(435, 69);
            surnameText.Name = "surnameText";
            surnameText.Size = new Size(125, 23);
            surnameText.TabIndex = 42;
            // 
            // nameText
            // 
            nameText.Location = new Point(156, 69);
            nameText.Name = "nameText";
            nameText.Size = new Size(125, 23);
            nameText.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(22, 196);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 40;
            label5.Text = "Όνομα πατέρα";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(312, 68);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 39;
            label4.Text = "Επίθετο";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(22, 68);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 38;
            label3.Text = "Όνομα";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(22, 132);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 37;
            label2.Text = "Αριθμός φακέλου";
            // 
            // folderNameText
            // 
            folderNameText.Location = new Point(156, 129);
            folderNameText.Name = "folderNameText";
            folderNameText.Size = new Size(125, 23);
            folderNameText.TabIndex = 34;
            // 
            // openScanner
            // 
            openScanner.Location = new Point(-395, 96);
            openScanner.Name = "openScanner";
            openScanner.Size = new Size(151, 45);
            openScanner.TabIndex = 33;
            openScanner.Text = "ΑΝΟΙΓΜΑ SCANNER";
            openScanner.UseVisualStyleBackColor = true;
            // 
            // closeScannerButton
            // 
            closeScannerButton.Location = new Point(-173, 96);
            closeScannerButton.Name = "closeScannerButton";
            closeScannerButton.Size = new Size(151, 45);
            closeScannerButton.TabIndex = 30;
            closeScannerButton.Text = "ΚΛΕΙΣΙΜΟ SCANNER";
            closeScannerButton.UseVisualStyleBackColor = true;
            // 
            // initializeScanner
            // 
            initializeScanner.Location = new Point(-395, 27);
            initializeScanner.Name = "initializeScanner";
            initializeScanner.Size = new Size(151, 45);
            initializeScanner.TabIndex = 32;
            initializeScanner.Text = "ΕΚΚΙΝΗΣΗ SCANNER";
            initializeScanner.UseVisualStyleBackColor = true;
            // 
            // freeScannerButton
            // 
            freeScannerButton.Location = new Point(-173, 27);
            freeScannerButton.Name = "freeScannerButton";
            freeScannerButton.Size = new Size(151, 45);
            freeScannerButton.TabIndex = 31;
            freeScannerButton.Text = "ΑΠΕΛΕΥΘΕΡΩΣΗ SCANNER";
            freeScannerButton.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1219, 715);
            Controls.Add(splitContainer1);
            Name = "EditForm";
            Text = "EditForm";
            Load += EditForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button openScanner;
        private Button closeScannerButton;
        private Button initializeScanner;
        private Button freeScannerButton;
        private Label label3;
        private Label label2;
        private TextBox folderNameText;
        private TextBox fathersNameText;
        private TextBox surnameText;
        private TextBox nameText;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView;
        private TextBox mothersNameText;
        private Label label1;
        private DateTimePicker date_ofBirth;
        private Label label6;
        private Label label7;
        private TextBox diata3iText;
        private TextBox homeAdressText;
        private Label label8;
        private TextBox placeOfBirthText;
        private Label label9;
        private TextBox fromDayText;
        private Label label11;
        private Label label10;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private DateTimePicker endOfRecursionDate;
        private TextBox toDayText;
        private Label label12;
        private Button deleteUserButton;
        private Button saveChangesButton;
        private Button deleteFingerprintButton;
    }
}