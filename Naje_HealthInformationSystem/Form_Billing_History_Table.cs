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
    public partial class Form_Billing_History_Table : Form
    {
        string connectionString = "server=localhost;user=root;password=vilnaje1021;database=healthdb;";

        public Form_Billing_History_Table()
        {
            InitializeComponent();
        }

        private void Form_Billing_History_Table_Load(object sender, EventArgs e)
        {
            LoadBillingHistory();
        }

        private void LoadBillingHistory()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT history_id, billing_id, old_amount, new_amount, updated_at FROM billing_history ORDER BY updated_at DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                // Optional: Set nice column headers
                dataGridView1.Columns["history_id"].HeaderText = "History ID";
                dataGridView1.Columns["billing_id"].HeaderText = "Billing ID";
                dataGridView1.Columns["old_amount"].HeaderText = "Original Price";
                dataGridView1.Columns["new_amount"].HeaderText = "Updated Price";
                dataGridView1.Columns["updated_at"].HeaderText = "Date Changed";


                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.DefaultCellStyle.BackColor = Color.White;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Billing_Button_Option BillBut = new Billing_Button_Option();
            BillBut.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
