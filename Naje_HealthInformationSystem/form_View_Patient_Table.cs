using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Naje_HealthInformationSystem
{
    public partial class form_View_Patient_Table : Form
    {
        string connectionString = "server=localhost;user=root;password=vilnaje1021;database=healthdb;";
        public form_View_Patient_Table()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Patients.Rows[e.RowIndex];
                textBox_FirstName.Text = row.Cells["first_name"].Value.ToString();
                textBox_LastName.Text = row.Cells["last_name"].Value.ToString();
                textBox_Gender.Text = row.Cells["gender"].Value.ToString();
                dateTimePicker_Birthdate.Value = Convert.ToDateTime(row.Cells["birthdate"].Value);
                textBox_ContactNumber.Text = row.Cells["contact_number"].Value.ToString();
                textBox_Email.Text = row.Cells["email"].Value.ToString();
                textBox_Address.Text = row.Cells["address"].Value.ToString();
                comboBox_Status.SelectedItem = row.Cells["status"].Value.ToString();


                string statusFromDb = row.Cells["status"].Value.ToString().ToLower();
                if (comboBox_Status.Items.Contains(statusFromDb))
                {
                    comboBox_Status.SelectedItem = statusFromDb;
                }
                else
                {
                    comboBox_Status.SelectedIndex = -1;
                }


            }
        }

        private void form_View_Patient_Table_Load(object sender, EventArgs e)
        {
            LoadPatients();

            // Add dropdown options
            comboBox_Status.Items.Clear();
            comboBox_Status.Items.Add("active");
            comboBox_Status.Items.Add("inactive");
            comboBox_Status.SelectedIndex = 0;

            comboBox_FilterStatus.Items.Clear();
            comboBox_FilterStatus.Items.Add("All");     // Show all patients
            comboBox_FilterStatus.Items.Add("active");
            comboBox_FilterStatus.Items.Add("inactive");
            comboBox_FilterStatus.SelectedIndex = 0;   // Default to "All"
    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Patient_Button_Options PatientButt = new Patient_Button_Options();
            PatientButt.Show();
        }

        private void label_Specialty_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_Email_Click(object sender, EventArgs e)
        {

        }

        private void label_Gender_Click(object sender, EventArgs e)
        {

        }

        private void label_Email_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Addd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO patients 
                            (first_name, last_name, gender, birthdate, contact_number, email, address, status) 
                            VALUES (@first_name, @last_name, @gender, @birthdate, @contact_number, @email, @address, @status)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@first_name", textBox_FirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", textBox_LastName.Text);
                    cmd.Parameters.AddWithValue("@gender", textBox_Gender.Text);
                    cmd.Parameters.AddWithValue("@birthdate", dateTimePicker_Birthdate.Value.Date);
                    cmd.Parameters.AddWithValue("@contact_number", textBox_ContactNumber.Text);
                    cmd.Parameters.AddWithValue("@email", textBox_Email.Text);
                    cmd.Parameters.AddWithValue("@address", textBox_Address.Text);
                    cmd.Parameters.AddWithValue("@status", comboBox_Status.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Patient added successfully.");
                    LoadPatients();
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
            if (dataGridView_Patients.CurrentRow != null)
            {
                int PatientId = Convert.ToInt32(dataGridView_Patients.CurrentRow.Cells["patient_id"].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = @"UPDATE patients 
                            SET first_name = @first_name, 
                                last_name = @last_name, 
                                gender = @gender, 
                                birthdate = @birthdate, 
                                contact_number = @contact_number, 
                                email = @email, 
                                address = @address,
                                status = @status 
                            WHERE patient_id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@first_name", textBox_FirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", textBox_LastName.Text);
                    cmd.Parameters.AddWithValue("@gender", textBox_Gender.Text);
                    cmd.Parameters.AddWithValue("@birthdate", dateTimePicker_Birthdate.Value.Date);
                    cmd.Parameters.AddWithValue("@contact_number", textBox_ContactNumber.Text);
                    cmd.Parameters.AddWithValue("@email", textBox_Email.Text);
                    cmd.Parameters.AddWithValue("@address", textBox_Address.Text);
                    cmd.Parameters.AddWithValue("@status", comboBox_Status.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@id", PatientId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Patient updated successfully.");
                    LoadPatients();
                    ClearFields();
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Patients.CurrentRow != null)
            {
                int PatientId = Convert.ToInt32(dataGridView_Patients.CurrentRow.Cells["patient_id"].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check for active appointments
                    string checkAppointments = "SELECT COUNT(*) FROM appointments WHERE patient_id = @id AND status = 'Scheduled'";
                    MySqlCommand cmdAppointments = new MySqlCommand(checkAppointments, conn);
                    cmdAppointments.Parameters.AddWithValue("@id", PatientId);
                    int appointmentCount = Convert.ToInt32(cmdAppointments.ExecuteScalar());

                    // Check for unpaid bills
                    string checkBills = "SELECT COUNT(*) FROM billing WHERE appointment_id = @id AND payment_status = 'Pending'";
                    MySqlCommand cmdBills = new MySqlCommand(checkBills, conn);
                    cmdBills.Parameters.AddWithValue("@id", PatientId);
                    int billCount = Convert.ToInt32(cmdBills.ExecuteScalar());

                    if (appointmentCount > 0 || billCount > 0)
                    {
                        MessageBox.Show("Patient cannot be deleted because they have active appointments or unpaid bills.",
                                        "Delete Blocked",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }
                    string query = "DELETE FROM patients WHERE patient_id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", PatientId);

                    
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Patient deleted successfully.");
                    LoadPatients();
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
            dateTimePicker_Birthdate.Value = DateTime.Now;
            textBox_Gender.Clear();
            textBox_ContactNumber.Clear();
            textBox_Address.Clear();
            textBox_Email.Clear();
            comboBox_Status.SelectedIndex = 0; // Reset to "active"

        }

        private void textBox_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Birthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadPatients(string statusFilter = "All")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query;
                if (statusFilter == "All")
                {
                    query = "SELECT * FROM patients";
                }
                else
                {
                    query = "SELECT * FROM patients WHERE status = @status";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (statusFilter != "All")
                {
                    cmd.Parameters.AddWithValue("@status", statusFilter);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView_Patients.DataSource = dt;
            }
        }

        private void dateTimePicker_Birthdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_DoctorDetails_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_FilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = comboBox_FilterStatus.SelectedItem.ToString();
            LoadPatients(selectedStatus);
        }
    }
}
