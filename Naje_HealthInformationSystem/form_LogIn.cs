using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;




namespace Naje_HealthInformationSystem
{
    public partial class Form_LogIn : Form

    {
        string connectionString = "server=localhost;" +
            "user=root;" +
            "password=vilnaje1021;" +
            "database=healthdb;";

        public Form_LogIn()
        {
            InitializeComponent();
        }

        private void Form_LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            string email = textBox_Email.Text.Trim();
            string password = textBox_Password.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Email and Password.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT username FROM users WHERE email = @Email AND password = @Password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password); // ✅ plaintext for now; we'll improve this later

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        form_HomePage dashboard = new form_HomePage();
                        dashboard.Show();
                        this.Hide();
                        // Optionally: open dashboard here
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.", "Login Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
            }
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_ForgetPasswod_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the Login form
            Form_ForgetPassword forgot = new Form_ForgetPassword();
            forgot.Show();
            
        }
    }
}
