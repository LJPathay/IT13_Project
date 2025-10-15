namespace it13
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Logoutbtn = new Button();
            label1 = new Label();
            welcomelabel = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnPatients = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Logoutbtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(welcomelabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 68);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MediumTurquoise;
            pictureBox1.BackgroundImage = Properties.Resources.clinic_log;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Logoutbtn
            // 
            Logoutbtn.BackColor = Color.AliceBlue;
            Logoutbtn.FlatAppearance.BorderColor = Color.White;
            Logoutbtn.FlatAppearance.BorderSize = 0;
            Logoutbtn.FlatAppearance.MouseDownBackColor = Color.PowderBlue;
            Logoutbtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            Logoutbtn.FlatStyle = FlatStyle.Flat;
            Logoutbtn.Font = new Font("Bodoni MT", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logoutbtn.ForeColor = Color.Black;
            Logoutbtn.Location = new Point(747, 27);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(75, 23);
            Logoutbtn.TabIndex = 2;
            Logoutbtn.Text = "LOG OUT";
            Logoutbtn.UseVisualStyleBackColor = false;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 39);
            label1.Name = "label1";
            label1.Size = new Size(120, 19);
            label1.TabIndex = 1;
            label1.Text = "Welcome Admin!";
            // 
            // welcomelabel
            // 
            welcomelabel.AutoSize = true;
            welcomelabel.Font = new Font("Bell MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            welcomelabel.Location = new Point(78, 14);
            welcomelabel.Name = "welcomelabel";
            welcomelabel.Size = new Size(262, 25);
            welcomelabel.TabIndex = 0;
            welcomelabel.Text = "Clinic Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnPatients);
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(125, 396);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.AliceBlue;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.PowderBlue;
            button4.FlatAppearance.MouseOverBackColor = Color.Blue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bodoni MT", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(12, 213);
            button4.Name = "button4";
            button4.Size = new Size(103, 23);
            button4.TabIndex = 7;
            button4.Text = "MANAGEMENT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.AliceBlue;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.PowderBlue;
            button3.FlatAppearance.MouseOverBackColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bodoni MT", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(25, 167);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "REPORTS";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.AliceBlue;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.PowderBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.Blue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bodoni MT", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(25, 124);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "SERVICES";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.PowderBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.Blue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bodoni MT", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 79);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 4;
            button1.Text = "APPOINTMENTS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btnPatients
            // 
            btnPatients.BackColor = Color.MintCream;
            btnPatients.FlatAppearance.BorderColor = Color.White;
            btnPatients.FlatAppearance.BorderSize = 0;
            btnPatients.FlatAppearance.MouseDownBackColor = Color.PowderBlue;
            btnPatients.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnPatients.FlatStyle = FlatStyle.Flat;
            btnPatients.Font = new Font("Bodoni MT", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPatients.ForeColor = Color.Black;
            btnPatients.Location = new Point(25, 34);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(75, 23);
            btnPatients.TabIndex = 3;
            btnPatients.Text = "PATIENTS";
            btnPatients.UseVisualStyleBackColor = false;
            btnPatients.Click += btnPatients_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.tett;
            pictureBox2.Location = new Point(131, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(718, 417);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(849, 464);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label welcomelabel;
        private Label label1;
        private Button Logoutbtn;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnPatients;
        private PictureBox pictureBox2;
    }
}