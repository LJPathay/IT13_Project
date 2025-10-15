using Microsoft.Data.SqlClient;

namespace it13

{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //button log in ni admin

            string username = useruser.Text;
            string password = userpassword.Text;

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SystemIT13DB;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful! Welcome Admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DashboardForm dashboard = new DashboardForm();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userpassword_TextChanged(object sender, EventArgs e)
        {
            userpassword.PasswordChar = '*';

        }

        private void useruser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manageform loginForm = new Manageform();
            loginForm.Show();
            this.Hide();
        }
    }
}

