namespace it13
{
    partial class ServiceForm
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
            cmbServices = new ComboBox();
            label1 = new Label();
            lblVisits = new Label();
            label3 = new Label();
            dgvPatients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // cmbServices
            // 
            cmbServices.FormattingEnabled = true;
            cmbServices.Location = new Point(114, 12);
            cmbServices.Name = "cmbServices";
            cmbServices.Size = new Size(121, 23);
            cmbServices.TabIndex = 0;
            cmbServices.SelectedIndexChanged += cmbServices_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Choose a Service";
            // 
            // lblVisits
            // 
            lblVisits.AutoSize = true;
            lblVisits.Location = new Point(114, 51);
            lblVisits.Name = "lblVisits";
            lblVisits.Size = new Size(51, 15);
            lblVisits.TabIndex = 2;
            lblVisits.Text = "Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 51);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 3;
            label3.Text = "Number of Visit :";
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new Point(12, 91);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.Size = new Size(776, 347);
            dgvPatients.TabIndex = 4;
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPatients);
            Controls.Add(label3);
            Controls.Add(lblVisits);
            Controls.Add(label1);
            Controls.Add(cmbServices);
            Name = "ServiceForm";
            Text = "ServiceForm";
            Load += ServiceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbServices;
        private Label label1;
        private Label lblVisits;
        private Label label3;
        private DataGridView dgvPatients;
    }
}