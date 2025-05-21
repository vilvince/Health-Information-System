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
    public partial class Form_Add_Medication : Form
    {
        public Form_Add_Medication()
        {
            InitializeComponent();
        }

        private void Form_Add_Medication_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Medication_Button_Options MedicationButt = new Medication_Button_Options();
            MedicationButt.Show();
        }
    }
}
