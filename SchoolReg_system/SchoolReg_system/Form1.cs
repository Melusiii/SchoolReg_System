using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolReg_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\LoginDb.mdf;Integrated Security=True;Connect Timeout=30");

        

        private int check(string email)
        {
            connection.Open();
            string query = "SELECT COUNT(*) FROM RegistrationTBL WHERE email = @email";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@email", email);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }
        private void btn_SignUp_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (first_name.Text != "" && last_name.Text != "" && datepicker.Text != "" && gender.Text != "" &&
                    email.Text != "" && txt_password.Text != "" && txt_password2.Text != "")
                {
                    if (txt_password.Text == txt_password2.Text)
                    {
                        int v = check(email.Text);
                        if (v != 1)
                        {
                            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\LoginDb.mdf;Integrated Security=True;Connect Timeout=30"))
                            {
                                connection.Open(); // ? Ensure the connection is open before executing queries

                                SqlCommand command = new SqlCommand(
                                    "INSERT INTO RegistrationTBL (f_name, l_name, b_date, gender, email, password) " +
                                    "VALUES (@f_name, @l_name, @b_date, @gender, @email, @password)", connection);

                                command.Parameters.AddWithValue("@f_name", first_name.Text);
                                command.Parameters.AddWithValue("@l_name", last_name.Text);
                                command.Parameters.AddWithValue("@b_date", Convert.ToDateTime(datepicker.Text));
                                command.Parameters.AddWithValue("@gender", gender.Text);
                                command.Parameters.AddWithValue("@email", email.Text);
                                command.Parameters.AddWithValue("@password", txt_password.Text);

                                command.ExecuteNonQuery(); // ? Execute only when connection is open

                                MessageBox.Show("Registered successfully!");

                                // Clear form fields
                                first_name.Text = "";
                                last_name.Text = "";
                                datepicker.Text = "";
                                gender.Text = "";
                                email.Text = "";
                                txt_password.Text = "";
                                txt_password2.Text = "";
                            } // Connection automatically closes here due to 'using' statement
                        }
                        else
                        {
                            MessageBox.Show("You are already registered");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password does not match");
                    }
                }
                else
                {
                    MessageBox.Show("Fill in all fields!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void link_sign_in_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
