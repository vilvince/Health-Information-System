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
    public partial class Medical_record_Button_Option : Form
    {
        public Medical_record_Button_Option()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Medical_Records_Table MedRecTable = new Form_Medical_Records_Table();
            MedRecTable.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Add_MedicalRecord AddMR = new Form_Add_MedicalRecord();
            AddMR.Show();
        }

        private void Medical_record_Button_Option_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Deleted_Medical_Records DeletedMR = new Form_Deleted_Medical_Records();
            DeletedMR.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            form_HomePage Homepage = new form_HomePage();
            Homepage.Show();
        }
    }
}
