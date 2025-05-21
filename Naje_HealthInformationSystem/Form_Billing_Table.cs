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
using System.IO;



namespace Naje_HealthInformationSystem
{
    public partial class Form_Billing_Table : Form
    {
        string connectionString = "server=localhost;user=root;password=vilnaje1021;database=healthdb;";
        private bool showingUnpaid = false;
        public Form_Billing_Table()
        {
            InitializeComponent();
        }

        private void Form_Billing_Table_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            LoadBillingData();
            LoadPaymentStatusOptions();
            button_GetTotalBill.Click += button_GetTotalBill_Click;
            button_ToggleBills.Text = "Show Unpaid Bills";


        }
        private void LoadAppointments()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT appointment_id FROM appointments", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox_AppointmentID.Items.Add(reader["appointment_id"].ToString());
                }
            }
        }
        private void LoadBillingData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM billing", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;


            }
        }
        private void LoadPaymentStatusOptions()
        {
            comboBox_PaymentStatus.Items.Clear();
            comboBox_PaymentStatus.Items.Add("Pending");
            comboBox_PaymentStatus.Items.Add("Paid");
            comboBox_PaymentStatus.Items.Add("Cancelled");
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Billing_Button_Option BillBut = new Billing_Button_Option();
            BillBut.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                comboBox_AppointmentID.Text = row.Cells["appointment_id"].Value.ToString();
                textBox_AmountDue.Text = row.Cells["amount_due"].Value.ToString();
                comboBox_PaymentStatus.Text = row.Cells["payment_status"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["payment_date"].Value);
            }
        }

        private void label_AppointmentID_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_AppointmentID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_AmountDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_PaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_Addd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO billing (appointment_id, amount_due, payment_status, payment_date) VALUES (@appointment_id, @amount_due, @payment_status, @payment_date)", conn);
                cmd.Parameters.AddWithValue("@appointment_id", comboBox_AppointmentID.Text);
                cmd.Parameters.AddWithValue("@amount_due", textBox_AmountDue.Text);
                cmd.Parameters.AddWithValue("@payment_status", comboBox_PaymentStatus.Text);
                cmd.Parameters.AddWithValue("@payment_date", dateTimePicker1.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Billing record added successfully.");
                LoadBillingData();
                ClearFields();
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int billingId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["billing_id"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE billing SET appointment_id=@appointment_id, amount_due=@amount_due, payment_status=@payment_status, payment_date=@payment_date WHERE billing_id=@billing_id", conn);
                    cmd.Parameters.AddWithValue("@appointment_id", comboBox_AppointmentID.Text);
                    cmd.Parameters.AddWithValue("@amount_due", textBox_AmountDue.Text);
                    cmd.Parameters.AddWithValue("@payment_status", comboBox_PaymentStatus.Text);
                    cmd.Parameters.AddWithValue("@payment_date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@billing_id", billingId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Billing record updated successfully.");
                    LoadBillingData();
                    ClearFields();
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int billingId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["billing_id"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM billing WHERE billing_id=@billing_id", conn);
                    cmd.Parameters.AddWithValue("@billing_id", billingId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Billing record deleted successfully.");
                    LoadBillingData();
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
            comboBox_AppointmentID.SelectedIndex = -1;
            textBox_AmountDue.Clear();
            comboBox_PaymentStatus.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }
        private decimal GetTotalBill(int patientId)
        {
            decimal total = 0;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT GetTotalBill(@patientId)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@patientId", patientId);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                        total = Convert.ToDecimal(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving total bill: " + ex.Message);
                }
            }
            return total;
        }

        private void button_GetTotalBill_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_PatientId.Text.Trim(), out int patientId))
            {
                decimal totalBill = GetTotalBill(patientId);
                label_TotalBill.Text = "Total Bill: ₱" + totalBill.ToString("N2");
            }
            else
            {
                MessageBox.Show("Please enter a valid Patient ID (numeric).");
                textBox_PatientId.Focus();
            }
        }

        private void label_Instruction_Click(object sender, EventArgs e)
        {

        }

        private void label_TotalBill_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }





        private void button_ToggleBills_Click(object sender, EventArgs e)
        {
            if (showingUnpaid)
            {
                // Currently showing unpaid bills; switch to show all bills
                LoadBillingData();
                button_ToggleBills.Text = "Show Unpaid Bills";
                showingUnpaid = false;
            }
            else
            {
                // Currently showing all bills; switch to show unpaid bills
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("ListUnpaidBills", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                button_ToggleBills.Text = "Show All Bills";
                showingUnpaid = true;
            }
        }

        private void button_ExportToCSV_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "BillingData.csv";
                bool fileError = false;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int columnCount = dataGridView1.Columns.Count;
                        string columnNames = "";
                        string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                        }
                        outputCsv[0] += columnNames;

                        for (int i = 1; i <= dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value?.ToString() + ",";
                            }
                        }

                        File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                        MessageBox.Show("Data Exported Successfully.", "Info");
                    }
                    catch (Exception ex)
                    {
                        fileError = true;
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

                if (!fileError)
                {
                    MessageBox.Show("Export Successful", "Info");
                }
            }
            else
            {
                MessageBox.Show("No Record To Export", "Info");
            }
        }
    }
}
