using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naje_HealthInformationSystem
{
    public partial class Billing_Button_Option : Form
    {
        public Billing_Button_Option()
        {
            InitializeComponent();
        }

        private void Billing_Button_Option_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Add_Billing AddBill = new Form_Add_Billing();
            AddBill.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            form_HomePage Homepage = new form_HomePage();
            Homepage.Show();
        }

        private void button_View_Billing_Table_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Billing_Table BillTab = new Form_Billing_Table();
            BillTab.Show();
        }

        private void button_Billing_History_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Billing_History_Table BillHist = new Form_Billing_History_Table();
            BillHist.Show();
        }
    }
}
