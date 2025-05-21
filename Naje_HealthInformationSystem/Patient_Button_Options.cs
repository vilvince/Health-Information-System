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
    public partial class Patient_Button_Options : Form
    {
        public Patient_Button_Options()
        {
            InitializeComponent();
        }

        private void label_Back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            form_HomePage Homepage = new form_HomePage();
            Homepage.Show();
        }

        private void button_View_Patients_Table_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            form_View_Patient_Table PatientTable = new form_View_Patient_Table();
            PatientTable.Show();
        }

        private void button_Add_Patients_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Add_Patient AddPatient = new Form_Add_Patient();
            AddPatient.Show();
        }
    }
}
