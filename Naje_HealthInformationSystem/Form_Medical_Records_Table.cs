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
    public partial class Form_Medical_Records_Table : Form
    {
        private string connectionString = "server=localhost;user=root;password=vilnaje1021;database=healthdb;";
        public Form_Medical_Records_Table()
        {
            InitializeComponent();
        }

        private void Form_Medical_Records_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }


        private void LoadRecords()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM medical_records";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


                // Make table clean and compact
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToResizeRows = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.GridColor = Color.LightGray;
                dataGridView1.BorderStyle = BorderStyle.None;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridView1.EnableHeadersVisualStyles = false;

                // Header style
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Medical_record_Button_Option MedBut = new Medical_record_Button_Option();
            MedBut.Show();
        }

        private void label_Diagnosis_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox_AppointmentID.Text = row.Cells["appointment_id"].Value.ToString();
                textBox_Diagnosis.Text = row.Cells["diagnosis"].Value.ToString();
                textBox_Treatment.Text = row.Cells["treatment"].Value.ToString();
            }
        }

        private void button_Addd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO medical_records (appointment_id, diagnosis, treatment, created_at)
                             VALUES (@appointment_id, @diagnosis, @treatment, NOW())";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@appointment_id", textBox_AppointmentID.Text);
                    cmd.Parameters.AddWithValue("@diagnosis", textBox_Diagnosis.Text);
                    cmd.Parameters.AddWithValue("@treatment", textBox_Treatment.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Medical record added.");
                    LoadRecords();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int recordId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["record_id"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = @"UPDATE medical_records
                             SET appointment_id = @appointment_id,
                                 diagnosis = @diagnosis,
                                 treatment = @treatment
                             WHERE record_id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@appointment_id", textBox_AppointmentID.Text);
                    cmd.Parameters.AddWithValue("@diagnosis", textBox_Diagnosis.Text);
                    cmd.Parameters.AddWithValue("@treatment", textBox_Treatment.Text);
                    cmd.Parameters.AddWithValue("@id", recordId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Medical record updated.");
                    LoadRecords();
                    ClearFields();
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int recordId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["record_id"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM medical_records WHERE record_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", recordId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Medical record deleted.");
                    LoadRecords();
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
            textBox_AppointmentID.Clear();
            textBox_Diagnosis.Clear();
            textBox_Treatment.Clear();
        }
        private void textBox_AppointmentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Diagnosis_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Treatment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
