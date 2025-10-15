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
    public partial class PatientForm : Form
    {
        SqlConnection con = new SqlConnection(
        @"Server=localhost\SQLEXPRESS;Database=SystemIT13DB;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");
        public PatientForm()
        {
            InitializeComponent();
            LoadPatients();

        }
        private void LoadPatients()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(
                    @"Server=localhost\SQLEXPRESS;Database=SystemIT13DB;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;"))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Patients", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message);
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try

            {
                string connectionString = @"Server=localhost\SQLEXPRESS;Database=SystemIT13DB;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "INSERT INTO Patients (FirstName, LastName, Age, Gender, Contact, Address) " +
                                   "VALUES (@FirstName, @LastName, @Age, @Gender, @Contact, @Address)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("✅ Patient added successfully!");

                LoadPatients();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient: " + ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (txtPatientID.Text == "")
            {
                MessageBox.Show("⚠ Please select a patient to update.");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Patients SET FirstName=@fn, LastName=@ln, Age=@age, Gender=@gender, Contact=@contact, Address=@addr WHERE PatientID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtPatientID.Text);
                cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@addr", txtAddress.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("✅ Patient updated successfully!");
                LoadPatients();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating patient: " + ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (txtPatientID.Text == "")
            {
                MessageBox.Show("⚠ Please select a patient to delete.");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Patients WHERE PatientID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtPatientID.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("🗑 Patient deleted successfully!");
                LoadPatients();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting patient: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtPatientID.Text = row.Cells["PatientID"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                cmbGender.Text = row.Cells["Gender"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtPatientID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = -1;
            txtContact.Clear();
            txtAddress.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm Dash = new DashboardForm();
            Dash.Show();
            this.Hide();
        }
    }
}
