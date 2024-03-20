namespace FingerprintApplication.Forms
{
    partial class SearchUserForm
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
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            picFPImg = new PictureBox();
            label14 = new Label();
            panel2 = new Panel();
            date_ofBirth = new DateTimePicker();
            searchWithoutBio = new Button();
            fathersNameText = new TextBox();
            label13 = new Label();
            folderNameText = new TextBox();
            label12 = new Label();
            label11 = new Label();
            surnameText = new TextBox();
            label9 = new Label();
            nameText = new TextBox();
            label10 = new Label();
            label8 = new Label();
            startScanner = new Button();
            searchButton = new Button();
            label1 = new Label();
            loggingLabel = new Label();
            openScannerButton = new Button();
            initializeScannerButton = new Button();
            panel1 = new Panel();
            button1 = new Button();
            label7 = new Label();
            button3 = new Button();
            label4 = new Label();
            folderNameLabel = new Label();
            label6 = new Label();
            whenShowLabel = new Label();
            label5 = new Label();
            surnameLabel = new Label();
            fathersName = new Label();
            nameLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFPImg).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(label14);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(startScanner);
            splitContainer1.Panel1.Controls.Add(searchButton);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(loggingLabel);
            splitContainer1.Panel1.Controls.Add(openScannerButton);
            splitContainer1.Panel1.Controls.Add(initializeScannerButton);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(folderNameLabel);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(whenShowLabel);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(surnameLabel);
            splitContainer1.Panel2.Controls.Add(fathersName);
            splitContainer1.Panel2.Controls.Add(nameLabel);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label);
            splitContainer1.Panel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            splitContainer1.Size = new Size(1357, 704);
            splitContainer1.SplitterDistance = 702;
            splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(picFPImg);
            panel3.Location = new Point(67, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 399);
            panel3.TabIndex = 33;
            // 
            // picFPImg
            // 
            picFPImg.BackColor = SystemColors.Control;
            picFPImg.Location = new Point(4, 3);
            picFPImg.Name = "picFPImg";
            picFPImg.Padding = new Padding(10);
            picFPImg.Size = new Size(443, 393);
            picFPImg.TabIndex = 13;
            picFPImg.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(152, 6);
            label14.Name = "label14";
            label14.Size = new Size(280, 21);
            label14.TabIndex = 32;
            label14.Text = "Αναζήτηση με τη χρήση Βιομετρικού";
            // 
            // panel2
            // 
            panel2.Controls.Add(date_ofBirth);
            panel2.Controls.Add(searchWithoutBio);
            panel2.Controls.Add(fathersNameText);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(folderNameText);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(surnameText);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(nameText);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(3, 487);
            panel2.Name = "panel2";
            panel2.Size = new Size(621, 176);
            panel2.TabIndex = 31;
            // 
            // date_ofBirth
            // 
            date_ofBirth.Location = new Point(214, 73);
            date_ofBirth.Name = "date_ofBirth";
            date_ofBirth.Size = new Size(166, 23);
            date_ofBirth.TabIndex = 34;
            // 
            // searchWithoutBio
            // 
            searchWithoutBio.Location = new Point(418, 131);
            searchWithoutBio.Name = "searchWithoutBio";
            searchWithoutBio.Size = new Size(166, 30);
            searchWithoutBio.TabIndex = 30;
            searchWithoutBio.Text = "Αναζήτηση";
            searchWithoutBio.UseVisualStyleBackColor = true;
            searchWithoutBio.Click += searchWithoutBio_Click;
            // 
            // fathersNameText
            // 
            fathersNameText.Location = new Point(214, 138);
            fathersNameText.Name = "fathersNameText";
            fathersNameText.Size = new Size(166, 23);
            fathersNameText.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(246, 120);
            label13.Name = "label13";
            label13.Size = new Size(100, 15);
            label13.TabIndex = 28;
            label13.Text = "ΟΝΟΜΑ ΠΑΤΕΡΑ";
            // 
            // folderNameText
            // 
            folderNameText.Location = new Point(418, 73);
            folderNameText.Name = "folderNameText";
            folderNameText.Size = new Size(166, 23);
            folderNameText.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(418, 55);
            label12.Name = "label12";
            label12.Size = new Size(181, 15);
            label12.TabIndex = 26;
            label12.Text = "ΑΡΙΘΜΟΣ ΦΑΚΕΛΟΥ ΥΠΟΘΕΣΗΣ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(246, 55);
            label11.Name = "label11";
            label11.Size = new Size(93, 15);
            label11.TabIndex = 24;
            label11.Text = "ΗΜ. ΓΕΝΝΗΣΗΣ";
            // 
            // surnameText
            // 
            surnameText.Location = new Point(18, 138);
            surnameText.Name = "surnameText";
            surnameText.Size = new Size(166, 23);
            surnameText.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(71, 120);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 9;
            label9.Text = "ΕΠΩΝΥΜΟ";
            // 
            // nameText
            // 
            nameText.Location = new Point(18, 73);
            nameText.Name = "nameText";
            nameText.Size = new Size(166, 23);
            nameText.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(71, 55);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 7;
            label10.Text = "ΟΝΟΜΑ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(149, 16);
            label8.Name = "label8";
            label8.Size = new Size(308, 21);
            label8.TabIndex = 6;
            label8.Text = "Αναζήτηση χώρις τη χρήση Βιομετρικού";
            // 
            // startScanner
            // 
            startScanner.Location = new Point(96, 30);
            startScanner.Name = "startScanner";
            startScanner.Size = new Size(151, 45);
            startScanner.TabIndex = 30;
            startScanner.Text = "ΕΚΚΙΝΗΣΗ SCANNER";
            startScanner.UseVisualStyleBackColor = true;
            startScanner.Click += startScanner_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(348, 30);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(132, 45);
            searchButton.TabIndex = 29;
            searchButton.Text = "Αναζήτηση";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 42);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 28;
            label1.Text = "ΠΛΗΡΟΦΟΡΙΕΣ";
            // 
            // loggingLabel
            // 
            loggingLabel.AutoSize = true;
            loggingLabel.Location = new Point(-231, 226);
            loggingLabel.Name = "loggingLabel";
            loggingLabel.Size = new Size(89, 15);
            loggingLabel.TabIndex = 25;
            loggingLabel.Text = "ΠΛΗΡΟΦΟΡΙΕΣ";
            // 
            // openScannerButton
            // 
            openScannerButton.Location = new Point(-264, 140);
            openScannerButton.Name = "openScannerButton";
            openScannerButton.Size = new Size(151, 45);
            openScannerButton.TabIndex = 19;
            openScannerButton.Text = "ΑΝΟΙΓΜΑ SCANNER";
            openScannerButton.UseVisualStyleBackColor = true;
            // 
            // initializeScannerButton
            // 
            initializeScannerButton.Location = new Point(-264, 71);
            initializeScannerButton.Name = "initializeScannerButton";
            initializeScannerButton.Size = new Size(151, 45);
            initializeScannerButton.TabIndex = 18;
            initializeScannerButton.Text = "ΕΚΚΙΝΗΣΗ SCANNER";
            initializeScannerButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 390);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 314);
            panel1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(242, 268);
            button1.Name = "button1";
            button1.Size = new Size(147, 43);
            button1.TabIndex = 11;
            button1.Text = "Έκδοση";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.Location = new Point(172, 221);
            label7.Name = "label7";
            label7.Size = new Size(278, 25);
            label7.TabIndex = 6;
            label7.Text = "Έκδοση έκθεσης Εμφανίσεως";
            // 
            // button3
            // 
            button3.Location = new Point(223, 119);
            button3.Name = "button3";
            button3.Size = new Size(186, 51);
            button3.TabIndex = 5;
            button3.Text = "Επιβεβαίωση Εμφάνισης";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(39, 23);
            label4.Name = "label4";
            label4.Size = new Size(549, 50);
            label4.TabIndex = 0;
            label4.Text = "Αν θέλετε να επιβεβαιώσετε την εμφάνιση του ανθρώπου \r\nστο τμήμα για την τωρινή ημερομηνία πατήστε το κουμπι";
            // 
            // folderNameLabel
            // 
            folderNameLabel.AutoSize = true;
            folderNameLabel.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Italic);
            folderNameLabel.Location = new Point(223, 189);
            folderNameLabel.Name = "folderNameLabel";
            folderNameLabel.Size = new Size(21, 30);
            folderNameLabel.TabIndex = 11;
            folderNameLabel.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(173, 131);
            label6.Name = "label6";
            label6.Size = new Size(185, 30);
            label6.TabIndex = 10;
            label6.Text = "Αριθμός φακέλου";
            // 
            // whenShowLabel
            // 
            whenShowLabel.AutoSize = true;
            whenShowLabel.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Italic);
            whenShowLabel.Location = new Point(422, 83);
            whenShowLabel.Name = "whenShowLabel";
            whenShowLabel.Size = new Size(21, 30);
            whenShowLabel.TabIndex = 9;
            whenShowLabel.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(336, 9);
            label5.Name = "label5";
            label5.Size = new Size(231, 60);
            label5.TabIndex = 8;
            label5.Text = "Συχνότητα εμφάνισης \r\nκάθε μήνα";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Italic);
            surnameLabel.Location = new Point(223, 83);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(21, 30);
            surnameLabel.TabIndex = 7;
            surnameLabel.Text = "-";
            // 
            // fathersName
            // 
            fathersName.AutoSize = true;
            fathersName.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Italic);
            fathersName.Location = new Point(54, 189);
            fathersName.Name = "fathersName";
            fathersName.Size = new Size(21, 30);
            fathersName.TabIndex = 6;
            fathersName.Text = "-";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Italic);
            nameLabel.Location = new Point(54, 83);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(21, 30);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(3, 131);
            label3.Name = "label3";
            label3.Size = new Size(164, 30);
            label3.TabIndex = 4;
            label3.Text = "'Ονομα Πατέρα";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(202, 30);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 3;
            label2.Text = "Επίθετο";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label.Location = new Point(39, 27);
            label.Name = "label";
            label.Size = new Size(84, 30);
            label.TabIndex = 1;
            label.Text = "'Ονομα";
            // 
            // SearchUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1357, 704);
            Controls.Add(splitContainer1);
            Name = "SearchUserForm";
            Text = "SearchUserForm";
            Load += searchUser_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFPImg).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label loggingLabel;
        private Button openScannerButton;
        private Button initializeScannerButton;
        private Label label1;
        private Label label;
        private Label nameLabel;
        private Label label3;
        private Label label2;
        private Label surnameLabel;
        private Label fathersName;
        private Label whenShowLabel;
        private Label label5;
        private Label folderNameLabel;
        private Label label6;
        private Button searchButton;
        private Panel panel1;
        private Label label4;
        private Button button3;
        private Button startScanner;
        private Label label7;
        private Button button1;
        private Panel panel2;
        private Label label8;
        private TextBox surnameText;
        private Label label9;
        private TextBox nameText;
        private Label label10;
        private Label label11;
        private TextBox folderNameText;
        private Label label12;
        private Button searchWithoutBio;
        private TextBox fathersNameText;
        private Label label13;
        private DateTimePicker date_ofBirth;
        private Label label14;
        private Panel panel3;
        private PictureBox picFPImg;
    }
}