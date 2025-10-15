using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it13
{
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            cmbServices.Items.Add(new KeyValuePair<int, string>(1, "General Check up"));
            cmbServices.Items.Add(new KeyValuePair<int, string>(2, "Immunization"));
            cmbServices.Items.Add(new KeyValuePair<int, string>(3, "Prenatal Test"));
            cmbServices.Items.Add(new KeyValuePair<int, string>(4, "Medical Check up"));
            cmbServices.Items.Add(new KeyValuePair<int, string>(5, "Family Planning"));

            cmbServices.DisplayMember = "Value"; // show service name
            cmbServices.ValueMember = "Key";     // use service ID
        }

        private void cmbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServices.SelectedItem != null)
            {
                var selectedService = (KeyValuePair<int, string>)cmbServices.SelectedItem;
                int serviceId = selectedService.Key;
                string serviceName = selectedService.Value;

                using (SqlConnection conn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=SystemIT13DB;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;"))
                {
                    conn.Open();

                    // 1. Count Visits
                    string countQuery = @"SELECT COUNT(*) 
                                  FROM Appointments 
                                  WHERE ServiceID = @ServiceID";

                    SqlCommand countCmd = new SqlCommand(countQuery, conn);
                    countCmd.Parameters.AddWithValue("@ServiceID", serviceId);

                    int visits = (int)countCmd.ExecuteScalar();
                    lblVisits.Text = $"Total Visits for {serviceName}: {visits}";

                    // 2. List Patients
                    string listQuery = @"SELECT a.AppointmentID, 
                                        p.PatientID, 
                                        (p.FirstName + ' ' + p.LastName) AS PatientName,
                                        a.AppointmentDate
                                 FROM Appointments a
                                 JOIN Patients p ON a.PatientID = p.PatientID
                                 WHERE a.ServiceID = @ServiceID";

                    SqlDataAdapter da = new SqlDataAdapter(listQuery, conn);
                    da.SelectCommand.Parameters.AddWithValue("@ServiceID", serviceId);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPatients.DataSource = dt;
                }
            }

        }
    }
}
