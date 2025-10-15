namespace it13
{
    partial class PatientForm
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
            label1 = new Label();
            txtPatientID = new TextBox();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbGender = new ComboBox();
            txtContact = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Add = new Button();
            update = new Button();
            delete = new Button();
            clear = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Patient ID :";
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(91, 12);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.ReadOnly = true;
            txtPatientID.Size = new Size(100, 23);
            txtPatientID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(91, 44);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "First Name  :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(91, 73);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Last Name  :";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(91, 102);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 110);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 6;
            label4.Text = "Age :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(214, 20);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "Gender :";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(293, 12);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(100, 23);
            cmbGender.TabIndex = 9;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(293, 44);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(100, 23);
            txtContact.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(214, 52);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 10;
            label6.Text = "Contact  :";
            // 
            // txtAddress
            // 
            txtAddress.ForeColor = SystemColors.WindowText;
            txtAddress.Location = new Point(293, 73);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(214, 81);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 12;
            label7.Text = "Address  :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 286);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Add
            // 
            Add.Location = new Point(441, 12);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 15;
            Add.Text = "ADD";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // update
            // 
            update.Location = new Point(441, 41);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 16;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(441, 72);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 17;
            delete.Text = "DELETE";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // clear
            // 
            clear.Location = new Point(441, 102);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 18;
            clear.Text = "CLEAR";
            clear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(681, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(button1);
            Controls.Add(clear);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(Add);
            Controls.Add(dataGridView1);
            Controls.Add(txtAddress);
            Controls.Add(label7);
            Controls.Add(txtContact);
            Controls.Add(label6);
            Controls.Add(cmbGender);
            Controls.Add(label5);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(txtPatientID);
            Controls.Add(label1);
            Name = "PatientForm";
            Text = "PatientForm";
            Load += PatientForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPatientID;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtAge;
        private Label label4;
        private Label label5;
        private ComboBox cmbGender;
        private TextBox txtContact;
        private Label label6;
        private TextBox txtAddress;
        private Label label7;
        private DataGridView dataGridView1;
        private Button Add;
        private Button update;
        private Button delete;
        private Button clear;
        private Button button1;
    }
}