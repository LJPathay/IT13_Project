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
    public partial class AppointmentForm : Form
    {
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=SystemIT13DB;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            cmbService.Items.Add(new KeyValuePair<int, string>(1, "General Check up"));
            cmbService.Items.Add(new KeyValuePair<int, string>(2, "Immunization"));
            cmbService.Items.Add(new KeyValuePair<int, string>(3, "Prenatal Test"));
            cmbService.Items.Add(new KeyValuePair<int, string>(4, "Medical Check up"));
            cmbService.Items.Add(new KeyValuePair<int, string>(5, "Family Planning"));

            cmbService.DisplayMember = "Value";
            cmbService.ValueMember = "Key";

            LoadAppointments();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int patientId = int.Parse(txtPatientID.Text);
            int serviceId = ((KeyValuePair<int, string>)cmbService.SelectedItem).Key;
            DateTime appointmentDate = dateTimePicker1.Value.Date;



            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                string checkQuery = "SELECT COUNT(*) FROM Appointments WHERE PatientID=@PatientID AND AppointmentDate=@Date";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@PatientID", patientId);
                checkCmd.Parameters.AddWithValue("@Date", appointmentDate);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("This patient already has an appointment on that date!", "Duplicate Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string query = "INSERT INTO Appointments (PatientID, ServiceID, AppointmentDate) " +
                               "VALUES (@PatientID, @ServiceID, @Date)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientID", patientId);
                cmd.Parameters.AddWithValue("@ServiceID", serviceId);
                cmd.Parameters.AddWithValue("@Date", appointmentDate);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAppointments();
            }
        }

        private void LoadAppointments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT 
                a.AppointmentID,
                a.PatientID,
                (p.FirstName + ' ' + p.LastName) AS PatientName,
                s.ServiceName,
                a.AppointmentDate
                FROM Appointments a
                JOIN Patients p ON a.PatientID = p.PatientID
                JOIN Services s ON a.ServiceID = s.ServiceID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAppointments.DataSource = dt;
                dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAppointments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow != null)
            {
                int appointmentId = Convert.ToInt32(dgvAppointments.CurrentRow.Cells["AppointmentID"].Value);

                using (SqlConnection conn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=SystemIT13DB;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;"))
                {
                    conn.Open();
                    string query = @"UPDATE Appointments 
                             SET PatientID = @PatientID, 
                                 ServiceID = @ServiceID, 
                                 AppointmentDate = @AppointmentDate
                             WHERE AppointmentID = @AppointmentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text);
                        cmd.Parameters.AddWithValue("@ServiceID", cmbService.SelectedValue);
                        cmd.Parameters.AddWithValue("@AppointmentDate", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadAppointments(); // refresh grid
                MessageBox.Show("Appointment updated successfully!");
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow != null)
            {
                int appointmentId = Convert.ToInt32(dgvAppointments.CurrentRow.Cells["AppointmentID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=SystemIT13DB;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;"))
                    {
                        conn.Open();
                        string query = "DELETE FROM Appointments WHERE AppointmentID = @AppointmentID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadAppointments(); // refresh grid
                    MessageBox.Show("Appointment deleted successfully!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm Dash = new DashboardForm();
            Dash.Show();
            this.Hide();
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
