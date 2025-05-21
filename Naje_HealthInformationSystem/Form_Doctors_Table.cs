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
    public partial class Form_Doctors_Table : Form
    {
        private string connectionString = "server=localhost;user=root;password=vilnaje1021;database=healthdb;";
        public Form_Doctors_Table()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Doctor_Button_OPtions DocButt = new Doctor_Button_OPtions();
            DocButt.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox_FirstName.Text = dataGridView1.CurrentRow.Cells["first_name"].Value.ToString();
                textBox_LastName.Text = dataGridView1.CurrentRow.Cells["last_name"].Value.ToString();
                textBox_Specialty.Text = dataGridView1.CurrentRow.Cells["specialty"].Value.ToString();
                textBox_ContactNumber.Text = dataGridView1.CurrentRow.Cells["contact_number"].Value.ToString();
                textBox_Email.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_Email_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Specialty_TextChanged(object sender, EventArgs e)
        {

        }
         
        private void textBox_LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Doctors_Table_Load(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void button_Addd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO doctors (first_name, last_name, specialty, contact_number, email) VALUES (@first, @last, @specialty, @contact, @email)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@first", textBox_FirstName.Text);
                cmd.Parameters.AddWithValue("@last", textBox_LastName.Text);
                cmd.Parameters.AddWithValue("@specialty", textBox_Specialty.Text);
                cmd.Parameters.AddWithValue("@contact", textBox_ContactNumber.Text);
                cmd.Parameters.AddWithValue("@email", textBox_Email.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Doctor added successfully.");
                LoadDoctors();
                ClearFields();
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int doctorId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["doctor_id"].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE doctors SET first_name=@first, last_name=@last, specialty=@specialty, contact_number=@contact, email=@email WHERE doctor_id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@first", textBox_FirstName.Text);
                    cmd.Parameters.AddWithValue("@last", textBox_LastName.Text);
                    cmd.Parameters.AddWithValue("@specialty", textBox_Specialty.Text);
                    cmd.Parameters.AddWithValue("@contact", textBox_ContactNumber.Text);
                    cmd.Parameters.AddWithValue("@email", textBox_Email.Text);
                    cmd.Parameters.AddWithValue("@id", doctorId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Doctor updated successfully.");
                    LoadDoctors();
                    ClearFields();
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int doctorId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["doctor_id"].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM doctors WHERE doctor_id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", doctorId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Doctor deleted successfully.");
                    LoadDoctors();
                    ClearFields();
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            textBox_FirstName.Clear();
            textBox_LastName.Clear();
            textBox_Specialty.Clear();
            textBox_ContactNumber.Clear();
            textBox_Email.Clear();
        }
        private void LoadDoctors()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM doctors";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
