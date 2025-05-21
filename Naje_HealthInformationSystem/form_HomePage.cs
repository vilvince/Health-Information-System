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
    public partial class form_HomePage : Form
    {
        string connectionString = "server=localhost;user=root;password=vilnaje1021;database=healthdb;";

        public form_HomePage()
        {
            InitializeComponent();
        }

        private void button_Medical_Click(object sender, EventArgs e)
        {
            Medical_record_Button_Option medRecords = new Medical_record_Button_Option();
            medRecords.Show();
            this.Hide();
        }

        private void form_HomePage_Load(object sender, EventArgs e)
        {
            LoadDashboardSummary();
        }
        private void LoadDashboardSummary()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Total patients
                    MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM patients", conn);
                    int totalPatients = Convert.ToInt32(cmd1.ExecuteScalar());
                    label_PatientRegisterPlaceholder.Text = totalPatients.ToString();

                    // Total doctors
                    MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) FROM doctors", conn);
                    int totalDoctors = Convert.ToInt32(cmd2.ExecuteScalar());
                    label_TotalDoctorPlaceHolder.Text = totalDoctors.ToString();

                    // Upcoming appointments (next 7 days)
                    // Upcoming appointments (next 7 days, only Scheduled)
                    MySqlCommand cmd3 = new MySqlCommand(
                        "SELECT COUNT(*) FROM appointments WHERE appointment_date >= CURDATE() AND appointment_date < CURDATE() + INTERVAL 7 DAY AND status = 'Scheduled'", conn);
                    int upcomingAppointments = Convert.ToInt32(cmd3.ExecuteScalar());
                    label_UpcomingAppointmentsPlaceholder.Text = upcomingAppointments.ToString();


                    // Total logs (assuming you have a `logs` table)
                    MySqlCommand cmd4 = new MySqlCommand("SELECT COUNT(*) FROM patient_logs WHERE DATE(registration_date) = CURDATE()", conn);
                    int totalLogs = Convert.ToInt32(cmd4.ExecuteScalar());
                    label_TotalLogsPlaceholder.Text = totalLogs.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dashboard data: " + ex.Message);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button_Billing_Click(object sender, EventArgs e)
        {
            Billing_Button_Option billRecords = new Billing_Button_Option();
            billRecords.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_PatientRegisterPlaceholder_Click(object sender, EventArgs e)
        {

        }

        private void label_TotalDoctorPlaceHolder_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide(); // Just hide the current form
                Form_LogIn loginForm = new Form_LogIn();
                loginForm.Show();
            }
        }

        private void label_UpcomingAppointmentsPlaceholder_Click(object sender, EventArgs e)
        {

        }

        private void button_Doctors_Click(object sender, EventArgs e)
        {
            Doctor_Button_OPtions docRecords = new Doctor_Button_OPtions();
            docRecords.Show();
            this.Hide();
        }

        private void button_Patients_Click(object sender, EventArgs e)
        {
            Patient_Button_Options paiRecords = new Patient_Button_Options();
            paiRecords.Show();
            this.Hide();
        }

        private void button_Appointments_Click(object sender, EventArgs e)
        {
            Appointment_Button_Option appoiRecords = new Appointment_Button_Option();
            appoiRecords.Show();
            this.Hide();
        }

        private void button_Medication_Click(object sender, EventArgs e)
        {
            Form_Medication_Table mediTab = new Form_Medication_Table();
            mediTab.Show();
            this.Hide();
        }

        private void button_Prescription_Click(object sender, EventArgs e)
        {
            Form_Prescription_Table presTab = new Form_Prescription_Table();
            presTab.Show();
            this.Hide();
        }

        private void label_TotalLogsPlaceholder_Click(object sender, EventArgs e)
        {

        }
    }
}
