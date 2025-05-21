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
    public partial class Form_Medication_Table : Form
    {
        private string connectionString = "server=localhost;user=root;password=vilnaje1021;database=healthdb;";

        public Form_Medication_Table()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox_Medication_Name.Text = row.Cells["medication_name"].Value.ToString();
                textBox_Manufacturer.Text = row.Cells["manufacturer"].Value.ToString();
                textBox_Price.Text = row.Cells["price"].Value.ToString();
                textBox_Stock.Text = row.Cells["stock"].Value.ToString();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            form_HomePage Homepage = new form_HomePage();
            Homepage.Show();
        }

        private void Form_Medication_Table_Load(object sender, EventArgs e)
        {
            LoadMedications();
        }

        private void LoadMedications()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM medication";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading medication: " + ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_Addd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO medication (medication_name, manufacturer, price, stock) VALUES (@name, @manufacturer, @price, @stock)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", textBox_Medication_Name.Text);
                    cmd.Parameters.AddWithValue("@manufacturer", textBox_Manufacturer.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(textBox_Price.Text));
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(textBox_Stock.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Medication added successfully.");
                    LoadMedications();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding medication: " + ex.Message);
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            textBox_Medication_Name.Clear();
            textBox_Manufacturer.Clear();
            textBox_Price.Clear();
            textBox_Stock.Clear();
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int medicationId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["medication_id"].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM medication WHERE medication_id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", medicationId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Medication deleted.");
                        LoadMedications();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting medication: " + ex.Message);
                    }
                }
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int medicationId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["medication_id"].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE medication SET medication_name=@name, manufacturer=@manufacturer, price=@price, stock=@stock WHERE medication_id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@name", textBox_Medication_Name.Text);
                        cmd.Parameters.AddWithValue("@manufacturer", textBox_Manufacturer.Text);
                        cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(textBox_Price.Text));
                        cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(textBox_Stock.Text));
                        cmd.Parameters.AddWithValue("@id", medicationId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Medication updated.");
                        LoadMedications();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating medication: " + ex.Message);
                    }
                }
            }
        }

        private void textBox_Stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Manufacturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Medication_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
