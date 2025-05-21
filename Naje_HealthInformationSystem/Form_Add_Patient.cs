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
    public partial class Form_Add_Patient : Form
    {
        public Form_Add_Patient()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Add_Patient_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            LoadPatientLogsByDate(DateTime.Today);
        }

        private void button_Add_Click(object sender, EventArgs e)
        {

        }

        private void textBox_First_Nmae_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Patient_Button_Options PatientButt = new Patient_Button_Options();
            PatientButt.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadPatientLogsByDate(dateTimePicker1.Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadPatientLogsByDate(DateTime selectedDate)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=vilnaje1021;database=healthdb;"))
            {
                string query = @"SELECT * FROM patient_logs 
                         WHERE DATE(registration_date) = @selectedDate";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@selectedDate", selectedDate.Date);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.DefaultCellStyle.BackColor = Color.White;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.ReadOnly = true;
                
            }
        }

    }
}
