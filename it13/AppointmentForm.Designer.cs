namespace it13
{
    partial class AppointmentForm
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
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnSave = new Button();
            btnUpdateAppointment = new Button();
            btnDeleteAppointment = new Button();
            btnViewAppointments = new Button();
            dgvAppointments = new DataGridView();
            cmbService = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Patient ID";
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(76, 34);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(129, 23);
            txtPatientID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Service ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 4;
            label3.Text = "Appointment Date : ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(132, 92);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(360, 98);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdateAppointment
            // 
            btnUpdateAppointment.Location = new Point(453, 98);
            btnUpdateAppointment.Name = "btnUpdateAppointment";
            btnUpdateAppointment.Size = new Size(75, 23);
            btnUpdateAppointment.TabIndex = 7;
            btnUpdateAppointment.Text = "UPDATE";
            btnUpdateAppointment.UseVisualStyleBackColor = true;
            btnUpdateAppointment.Click += btnUpdateAppointment_Click;
            // 
            // btnDeleteAppointment
            // 
            btnDeleteAppointment.Location = new Point(555, 98);
            btnDeleteAppointment.Name = "btnDeleteAppointment";
            btnDeleteAppointment.Size = new Size(75, 23);
            btnDeleteAppointment.TabIndex = 8;
            btnDeleteAppointment.Text = "DELETE";
            btnDeleteAppointment.UseVisualStyleBackColor = true;
            btnDeleteAppointment.Click += btnDeleteAppointment_Click;
            // 
            // btnViewAppointments
            // 
            btnViewAppointments.Location = new Point(652, 98);
            btnViewAppointments.Name = "btnViewAppointments";
            btnViewAppointments.Size = new Size(75, 23);
            btnViewAppointments.TabIndex = 9;
            btnViewAppointments.Text = "REFRESH";
            btnViewAppointments.UseVisualStyleBackColor = true;
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(0, 132);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.Size = new Size(739, 318);
            dgvAppointments.TabIndex = 10;
            dgvAppointments.CellContentClick += dgvAppointments_CellContentClick;
            // 
            // cmbService
            // 
            cmbService.FormattingEnabled = true;
            cmbService.Location = new Point(76, 63);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(129, 23);
            cmbService.TabIndex = 11;
            cmbService.SelectedIndexChanged += cmbService_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(652, 33);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 450);
            Controls.Add(button1);
            Controls.Add(cmbService);
            Controls.Add(dgvAppointments);
            Controls.Add(btnViewAppointments);
            Controls.Add(btnDeleteAppointment);
            Controls.Add(btnUpdateAppointment);
            Controls.Add(btnSave);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPatientID);
            Controls.Add(label1);
            Name = "AppointmentForm";
            Text = "AppointmentForm";
            Load += AppointmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPatientID;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button btnSave;
        private Button btnUpdateAppointment;
        private Button btnDeleteAppointment;
        private Button btnViewAppointments;
        private DataGridView dgvAppointments;
        private ComboBox cmbService;
        private Button button1;
    }
}