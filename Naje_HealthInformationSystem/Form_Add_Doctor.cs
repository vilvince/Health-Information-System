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

    public partial class Form_Add_Doctor : Form
    {
        private string connectionString = "server=localhost;user=root;password=vilnaje1021;database=healthdb;";
        public Form_Add_Doctor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Add_Doctor_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM doctor_workload"; // This is your VIEW
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView_DoctorWorkload.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading active appointments: " + ex.Message);
                }
            }
            dataGridView_DoctorWorkload.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Doctor_Button_OPtions DocButt = new Doctor_Button_OPtions();
            DocButt.Show();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
                    }

        private void dataGridView_DoctorWorkload_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_DoctorID_TextChanged(object sender, EventArgs e)
        {
            string doctorId = textBox_DoctorID.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query;

                    if (string.IsNullOrEmpty(doctorId))
                    {
                        // Show all if no filter is applied
                        query = "SELECT * FROM doctor_workload";
                    }
                    else
                    {
                        // Filter by exact doctor_id
                        query = "SELECT * FROM doctor_workload WHERE doctor_id LIKE @doctorId";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(doctorId))
                    {
                        cmd.Parameters.AddWithValue("@doctorId", doctorId + "%"); // partial match for better UX
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView_DoctorWorkload.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering doctor workload: " + ex.Message);
                }
            }
        }
    }
}
