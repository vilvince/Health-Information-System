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
    public partial class Form_ForgetPassword : Form
    {

        string connectionString = "server=localhost;user=root;password=vilnaje1021;database=healthdb;";
        string correctAnswer = "";
        string retrievedPassword = "";
        public Form_ForgetPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form_ForgetPassword_Load(object sender, EventArgs e)
        {
            string userEmail = "nurse@gmail.com";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT recovery_question, recovery_answer, password FROM users WHERE email = @Email";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", userEmail);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label_Question.Text = reader["recovery_question"].ToString();
                            correctAnswer = reader["recovery_answer"].ToString();
                            retrievedPassword = reader["password"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Email not found in the database.");
                            button_Submit.Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (textBox_Answer.Text.Trim().Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                label_Password.Text = "Your password is: " + retrievedPassword;
            }
            else
            {
                MessageBox.Show("Incorrect answer. Try again.");
            }
        }

        private void textBox_Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
                // Show the login form
    Form_LogIn loginForm = new Form_LogIn();
    loginForm.Show();

            // Close the current forgot password form
            this.Hide();
        }
    }
}
