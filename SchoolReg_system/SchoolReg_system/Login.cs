using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolReg_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\LoginDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void sign_btn_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "")
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM RegistrationTBL WHERE email = @username AND password = @password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username.Text);
                    command.Parameters.AddWithValue("@password", password.Text);

                    int v = (int)command.ExecuteScalar();

                    if (v == 1)
                    {
                        MessageBox.Show("Welcome to your profile!");
                        username.Text = "";
                        password.Text = "";
                        // Open Dashboard or Main Form (if needed)
                    }
                    else
                    {
                        MessageBox.Show("Error: Incorrect username or password", "Error!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Ensure connection is closed after execution
                }
            }
            else
            {
                MessageBox.Show("Fill in the blanks!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
