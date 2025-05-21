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
    public partial class Form_Prescription_Table : Form
    {
        private string connectionString = "server=localhost;user=root;password=vilnaje1021;database=healthdb;";

        public Form_Prescription_Table()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            form_HomePage Homepage = new form_HomePage();
            Homepage.Show();
        }

        private void Form_Prescription_Table_Load(object sender, EventArgs e)
        {
            LoadPrescriptions();
            LoadComboBoxes();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void LoadPrescriptions()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM prescriptions";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading prescriptions: " + ex.Message);
                }

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.AllowUserToAddRows = false;
            }
        }

        private void LoadComboBoxes()
        {
            comboBox_Record_ID.Items.Clear();
            comboBox_Medication_ID.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd1 = new MySqlCommand("SELECT record_id FROM medical_records", conn);
                    using (MySqlDataReader reader = cmd1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox_Record_ID.Items.Add(reader["record_id"].ToString());
                        }
                    }

                    MySqlCommand cmd2 = new MySqlCommand("SELECT medication_id FROM medication", conn);
                    using (MySqlDataReader reader = cmd2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox_Medication_ID.Items.Add(reader["medication_id"].ToString());
                        }
                    }

                    comboBox_Record_ID.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBox_Medication_ID.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading combo boxes: " + ex.Message);
                }
            }
        }



        private void comboBox_Record_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Medication_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Dosage_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Duration_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Addd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO prescriptions (record_id, medication_id, dosage, duration) VALUES (@record, @medication, @dosage, @duration)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@record", comboBox_Record_ID.Text);
                    cmd.Parameters.AddWithValue("@medication", comboBox_Medication_ID.Text);
                    cmd.Parameters.AddWithValue("@dosage", textBox_Dosage.Text);
                    cmd.Parameters.AddWithValue("@duration", textBox_Duration.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prescription added.");
                    LoadPrescriptions();
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
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["prescription_id"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE prescriptions SET record_id=@record, medication_id=@medication, dosage=@dosage, duration=@duration WHERE prescription_id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@record", comboBox_Record_ID.Text);
                        cmd.Parameters.AddWithValue("@medication", comboBox_Medication_ID.Text);
                        cmd.Parameters.AddWithValue("@dosage", textBox_Dosage.Text);
                        cmd.Parameters.AddWithValue("@duration", textBox_Duration.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Prescription updated.");
                        LoadPrescriptions();
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
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["prescription_id"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM prescriptions WHERE prescription_id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Prescription deleted.");
                        LoadPrescriptions();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            comboBox_Record_ID.SelectedIndex = -1;
            comboBox_Medication_ID.SelectedIndex = -1;
            textBox_Dosage.Clear();
            textBox_Duration.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                comboBox_Record_ID.Text = row.Cells["record_id"].Value.ToString();
                comboBox_Medication_ID.Text = row.Cells["medication_id"].Value.ToString();
                textBox_Dosage.Text = row.Cells["dosage"].Value.ToString();
                textBox_Duration.Text = row.Cells["duration"].Value.ToString();
            }
        }
    }
}
