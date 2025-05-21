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
    public partial class Medication_Button_Options : Form
    {
        public Medication_Button_Options()
        {
            InitializeComponent();
        }

        private void Prescription_Button_Options_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            form_HomePage Homepage = new form_HomePage();
            Homepage.Show();
        }

        private void button_View_Medicine_Table_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Medication_Table MedicationTab = new Form_Medication_Table();
            MedicationTab.Show();
        }

        private void button_Add_New_Medicine_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Add_Medication AddMedication = new Form_Add_Medication();
            AddMedication.Show();
        }
    }
}
