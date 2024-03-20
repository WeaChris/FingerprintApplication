namespace FingerprintApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            addUserButton = new Button();
            homeButton = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 14, 148);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(addUserButton);
            panel1.Controls.Add(homeButton);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 869);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 429);
            button2.Margin = new Padding(3, 15, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(200, 60);
            button2.TabIndex = 5;
            button2.Text = "  Αναφορές";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 369);
            button1.Margin = new Padding(3, 15, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(200, 60);
            button1.TabIndex = 4;
            button1.Text = "  Επεξεργασία";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 309);
            button3.Margin = new Padding(3, 15, 3, 3);
            button3.Name = "button3";
            button3.Size = new Size(200, 60);
            button3.TabIndex = 3;
            button3.Text = "  Αναζήτηση";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // addUserButton
            // 
            addUserButton.Dock = DockStyle.Top;
            addUserButton.FlatAppearance.BorderSize = 0;
            addUserButton.FlatStyle = FlatStyle.Flat;
            addUserButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            addUserButton.ForeColor = SystemColors.Control;
            addUserButton.Image = (Image)resources.GetObject("addUserButton.Image");
            addUserButton.Location = new Point(0, 249);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(200, 60);
            addUserButton.TabIndex = 2;
            addUserButton.Text = " Προσθήκη";
            addUserButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // homeButton
            // 
            homeButton.Dock = DockStyle.Top;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            homeButton.ForeColor = SystemColors.Control;
            homeButton.Image = (Image)resources.GetObject("homeButton.Image");
            homeButton.Location = new Point(0, 189);
            homeButton.Margin = new Padding(5, 15, 5, 5);
            homeButton.Name = "homeButton";
            homeButton.Padding = new Padding(5);
            homeButton.Size = new Size(200, 60);
            homeButton.TabIndex = 1;
            homeButton.Text = "   Αρχική";
            homeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(2, 8, 94);
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(8);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 189);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(4, 14, 148);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1372, 186);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(2, 8, 94);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(815, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(557, 186);
            panel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(42, 47);
            label3.Name = "label3";
            label3.Size = new Size(485, 72);
            label3.TabIndex = 3;
            label3.Text = "Εφαρμογή ανίχνευσης δακτυλικού\r\n               αποτυπώματος";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(176, 102);
            label2.Name = "label2";
            label2.Size = new Size(391, 31);
            label2.TabIndex = 2;
            label2.Text = "Υπουργείο προστασίας του πολίτη";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(144, 47);
            label1.Name = "label1";
            label1.Size = new Size(476, 46);
            label1.TabIndex = 1;
            label1.Text = "ΕΛΛΗΝΙΚΗ ΑΣΤΥΝΟΜΙΑ";
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 186);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(5);
            mainPanel.Size = new Size(1372, 683);
            mainPanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1572, 869);
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button homeButton;
        private Button button3;
        private Button addUserButton;
        private Panel mainPanel;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}