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
    public partial class Form_Add_Billing : Form
    {
        string connectionString = "server=localhost;user=root;password=vilnaje1021;database=healthdb;";
        public Form_Add_Billing()
        {
            InitializeComponent();
        }

        private void Form_Add_Billing_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM billing_summary";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_BillingSummary.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading billing summary: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Billing_Button_Option BillBut = new Billing_Button_Option();
            BillBut.Show();
        }

        private void label_AddBilling_Click(object sender, EventArgs e)
        {

        }
    }
}
