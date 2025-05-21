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
    public partial class Form_Appointment_Table : Form
    {
        

        public Form_Appointment_Table()
        {
            InitializeComponent();
        }

        private void Form_Appointment_Table_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            // Set up the status ComboBox
            comboBox_Status.Items.Clear();
            comboBox_Status.Items.Add("Scheduled");
            comboBox_Status.Items.Add("Completed");
            comboBox_Status.Items.Add("Cancelled");
            comboBox_Status.Items.Add("Inactive");
            comboBox_Status.DropDownStyle = ComboBoxStyle.DropDownList; // prevents manual input
            comboBox_Status.SelectedIndex = 0; // Default to "Schedule"

            comboBox_Reason.Items.Clear();
            comboBox_Reason.Items.Add("Follow-up");
            comboBox_Reason.Items.Add("General Checkup");
            comboBox_Reason.Items.Add("Emergency");
            comboBox_Reason.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Reason.SelectedIndex = 0; // Default selection (optional)

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Appointment_Button_Option AppBut = new Appointment_Button_Option();
            AppBut.Show();
        }

        private void dataGridView_Appointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Appointments.Rows[e.RowIndex];
                textBox_PatientID.Text = row.Cells["patient_id"].Value.ToString();
                textBox_DoctorID.Text = row.Cells["doctor_id"].Value.ToString();
                dateTimePicker_AppointmentDate.Value = Convert.ToDateTime(row.Cells["appointment_date"].Value);
                string status = row.Cells["status"].Value.ToString().Trim();
                int statusIndex = comboBox_Status.FindStringExact(status);
                if (statusIndex != -1)
                    comboBox_Status.SelectedIndex = statusIndex;

                string reason = row.Cells["reason"].Value.ToString().Trim();
                int reasonIndex = comboBox_Reason.FindStringExact(reason);
                if (reasonIndex != -1)
                    comboBox_Reason.SelectedIndex = reasonIndex;
            }
        }
        private string connectionString = "server=localhost;user=root;password=vilnaje1021;database=healthdb;";

        private void LoadAppointments()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT appointment_id, patient_id, doctor_id, appointment_date, status, reason FROM appointments";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView_Appointments.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label_PatientID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO appointments (patient_id, doctor_id, appointment_date, status, reason) " +
                                   "VALUES (@patient, @doctor, @date, @status, @reason)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@patient", textBox_PatientID.Text);
                    cmd.Parameters.AddWithValue("@doctor", textBox_DoctorID.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker_AppointmentDate.Value);
                    cmd.Parameters.AddWithValue("@status", comboBox_Status.Text);
                    cmd.Parameters.AddWithValue("@reason", comboBox_Reason.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment added.");
                    LoadAppointments();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView_Appointments.CurrentRow != null)
            {
                int appointmentId = Convert.ToInt32(dataGridView_Appointments.CurrentRow.Cells["appointment_id"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE appointments SET patient_id=@patient, doctor_id=@doctor, " +
                                       "appointment_date=@date, status=@status, reason=@reason WHERE appointment_id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@patient", textBox_PatientID.Text);
                        cmd.Parameters.AddWithValue("@doctor", textBox_DoctorID.Text);
                        cmd.Parameters.AddWithValue("@date", dateTimePicker_AppointmentDate.Value);
                        cmd.Parameters.AddWithValue("@status", comboBox_Status.Text);
                        cmd.Parameters.AddWithValue("@reason", comboBox_Reason.Text);
                        cmd.Parameters.AddWithValue("@id", appointmentId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Appointment updated.");
                        LoadAppointments();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Appointments.CurrentRow != null)
            {
                int appointmentId = Convert.ToInt32(dataGridView_Appointments.CurrentRow.Cells["appointment_id"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM appointments WHERE appointment_id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", appointmentId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Appointment deleted.");
                        LoadAppointments();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void ClearFields()
        {
            textBox_PatientID.Clear();
            textBox_DoctorID.Clear();
            comboBox_Status.SelectedIndex = -1;
            comboBox_Reason.SelectedIndex = -1;
            dateTimePicker_AppointmentDate.Value = DateTime.Today;
        }

        private void comboBox_Reason_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_PatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
