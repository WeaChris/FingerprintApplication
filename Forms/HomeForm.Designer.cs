namespace FingerprintApplication.Forms
{
    partial class HomeForm
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
            label14 = new Label();
            label15 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            userFound = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(label14);
            splitContainer1.Panel1.Controls.Add(label15);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(label10);
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(label12);
            splitContainer1.Panel1.Controls.Add(label13);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(userFound);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(1387, 673);
            splitContainer1.SplitterDistance = 615;
            splitContainer1.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(366, 97);
            label14.Name = "label14";
            label14.Size = new Size(208, 84);
            label14.TabIndex = 19;
            label14.Text = "Στην συχνότητα εμφάνισης \r\nβάζουμε το διάστημα που \r\nθέλουμε διαχωρισμένο με \r\n- (παύλα)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F);
            label15.Location = new Point(334, 97);
            label15.Name = "label15";
            label15.Size = new Size(26, 25);
            label15.TabIndex = 18;
            label15.Text = "4.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(44, 562);
            label8.Name = "label8";
            label8.Size = new Size(230, 63);
            label8.TabIndex = 17;
            label8.Text = "Αν η λήψη δεν είναι καλή ξανα \r\nπατάμε το κουμπί που ανοίγει \r\nτον scanner";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F);
            label9.Location = new Point(12, 587);
            label9.Name = "label9";
            label9.Size = new Size(26, 25);
            label9.TabIndex = 16;
            label9.Text = "3.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(44, 488);
            label10.Name = "label10";
            label10.Size = new Size(204, 42);
            label10.TabIndex = 15;
            label10.Text = "Ανοίγουμε τον scanner \rκαι ακουμπάμε το δάχτυλο";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F);
            label11.Location = new Point(12, 505);
            label11.Name = "label11";
            label11.Size = new Size(26, 25);
            label11.TabIndex = 14;
            label11.Text = "2.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(44, 440);
            label12.Name = "label12";
            label12.Size = new Size(227, 21);
            label12.TabIndex = 13;
            label12.Text = "Κάνουμε εκκίνηση του Scanner";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F);
            label13.Location = new Point(12, 436);
            label13.Name = "label13";
            label13.Size = new Size(26, 25);
            label13.TabIndex = 12;
            label13.Text = "1.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(130, 374);
            label7.Name = "label7";
            label7.Size = new Size(249, 30);
            label7.TabIndex = 11;
            label7.Text = "Οδηγίες Χρήσης Scanner";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(44, 252);
            label3.Name = "label3";
            label3.Size = new Size(274, 84);
            label3.TabIndex = 10;
            label3.Text = "Αν ο χρήστης είναι εγεγραμμένος και \r\nθέλουμε να επιβεβαιώσουμε την\r\nεμφάνιση του στο τμήμα\r\nχρησιμοποιούμε την επιλογή search";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(12, 268);
            label6.Name = "label6";
            label6.Size = new Size(26, 25);
            label6.TabIndex = 9;
            label6.Text = "3.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(44, 164);
            label4.Name = "label4";
            label4.Size = new Size(256, 63);
            label4.TabIndex = 8;
            label4.Text = "Αν δεν είναι τον κάνουμε εγγραφή \r\nμέσω της επιλογής που υπαρχει \r\nστο menu.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(12, 186);
            label5.Name = "label5";
            label5.Size = new Size(26, 25);
            label5.TabIndex = 7;
            label5.Text = "2.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(44, 100);
            label2.Name = "label2";
            label2.Size = new Size(260, 42);
            label2.TabIndex = 5;
            label2.Text = "Εξακριβώνουμε αν ο χρήστης ειναι \r\nεγγεγραμένος στο σύστημα ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(12, 117);
            label1.Name = "label1";
            label1.Size = new Size(26, 25);
            label1.TabIndex = 4;
            label1.Text = "1.";
            // 
            // userFound
            // 
            userFound.AutoSize = true;
            userFound.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            userFound.Location = new Point(179, 42);
            userFound.Name = "userFound";
            userFound.Size = new Size(162, 30);
            userFound.TabIndex = 3;
            userFound.Text = "Γενικές Οδηγίες";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 153F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Location = new Point(94, 58);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(575, 567);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(569, 561);
            dataGridView1.TabIndex = 0;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1387, 673);
            Controls.Add(splitContainer1);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label userFound;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Label label14;
        private Label label15;
    }
}