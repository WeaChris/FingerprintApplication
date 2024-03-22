namespace FingerprintApplication.Forms
{
    partial class reportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportForm));
            reportTableforUsers2 = new DataGridView();
            reportTableforUsers1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            month = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            button1 = new Button();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            FromLabel = new Label();
            UntilLabel = new Label();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            label7 = new Label();
            label8 = new Label();
            usersDataPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)reportTableforUsers2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reportTableforUsers1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // reportTableforUsers2
            // 
            reportTableforUsers2.AllowUserToOrderColumns = true;
            reportTableforUsers2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportTableforUsers2.Location = new Point(602, 131);
            reportTableforUsers2.Name = "reportTableforUsers2";
            reportTableforUsers2.Size = new Size(522, 478);
            reportTableforUsers2.TabIndex = 1;
            // 
            // reportTableforUsers1
            // 
            reportTableforUsers1.AllowUserToOrderColumns = true;
            reportTableforUsers1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportTableforUsers1.Location = new Point(26, 131);
            reportTableforUsers1.Name = "reportTableforUsers1";
            reportTableforUsers1.Size = new Size(513, 478);
            reportTableforUsers1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(42, 93);
            label1.Name = "label1";
            label1.Size = new Size(381, 21);
            label1.TabIndex = 3;
            label1.Text = "Χρήστες που έχουν ολοκληρώσει τις παρουσίες τους";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(629, 93);
            label2.Name = "label2";
            label2.Size = new Size(409, 21);
            label2.TabIndex = 4;
            label2.Text = "Χρήστες που δεν έχουν ολοκληρώσει τις παρουσίες τους";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(387, 25);
            label3.Name = "label3";
            label3.Size = new Size(155, 30);
            label3.TabIndex = 5;
            label3.Text = "Για τον μήνα :";
            // 
            // month
            // 
            month.AutoSize = true;
            month.Font = new Font("Segoe UI", 15.75F);
            month.Location = new Point(539, 25);
            month.Name = "month";
            month.Size = new Size(0, 30);
            month.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1058, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(448, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(1225, 77);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 9;
            label4.Text = "Έκδοση αρχείων";
            // 
            // button1
            // 
            button1.Location = new Point(1234, 140);
            button1.Name = "button1";
            button1.Size = new Size(147, 43);
            button1.TabIndex = 10;
            button1.Text = "Φόρμα Αναφοράς";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(1213, 254);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 12;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(1213, 325);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 13;
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(1286, 223);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(30, 15);
            FromLabel.TabIndex = 14;
            FromLabel.Text = "Από";
            FromLabel.Click += label5_Click;
            // 
            // UntilLabel
            // 
            UntilLabel.AutoSize = true;
            UntilLabel.Location = new Point(1286, 296);
            UntilLabel.Name = "UntilLabel";
            UntilLabel.Size = new Size(39, 15);
            UntilLabel.TabIndex = 15;
            UntilLabel.Text = "Μέχρι";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(1141, 197);
            label5.Name = "label5";
            label5.Size = new Size(348, 25);
            label5.TabIndex = 16;
            label5.Text = "------------------------------------------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(1141, 102);
            label6.Name = "label6";
            label6.Size = new Size(348, 25);
            label6.TabIndex = 17;
            label6.Text = "------------------------------------------";
            // 
            // button3
            // 
            button3.Location = new Point(1234, 371);
            button3.Name = "button3";
            button3.Size = new Size(147, 43);
            button3.TabIndex = 18;
            button3.Text = "Φόρμα Παρουσιών";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.Location = new Point(1140, 77);
            label7.Name = "label7";
            label7.Size = new Size(18, 600);
            label7.TabIndex = 19;
            label7.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label8.Location = new Point(1153, 429);
            label8.Name = "label8";
            label8.Size = new Size(348, 25);
            label8.TabIndex = 20;
            label8.Text = "------------------------------------------";
            // 
            // usersDataPrint
            // 
            usersDataPrint.Location = new Point(1234, 487);
            usersDataPrint.Name = "usersDataPrint";
            usersDataPrint.Size = new Size(147, 43);
            usersDataPrint.TabIndex = 21;
            usersDataPrint.Text = "Στοιχεία παρουσιαζομένων";
            usersDataPrint.UseVisualStyleBackColor = true;
            usersDataPrint.Click += usersDataPrint_Click;
            // 
            // reportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1480, 698);
            Controls.Add(usersDataPrint);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(UntilLabel);
            Controls.Add(FromLabel);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(month);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reportTableforUsers1);
            Controls.Add(reportTableforUsers2);
            Name = "reportForm";
            Text = "reportForm";
            Load += ReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)reportTableforUsers2).EndInit();
            ((System.ComponentModel.ISupportInitialize)reportTableforUsers1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView reportTableforUsers2;
        private DataGridView reportTableforUsers1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label month;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Button button1;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label FromLabel;
        private Label UntilLabel;
        private Label label5;
        private Label label6;
        private Button button3;
        private Label label7;
        private Label label8;
        private Button usersDataPrint;
    }
}