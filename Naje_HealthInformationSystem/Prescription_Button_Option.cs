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
    public partial class Prescription_Button_Option : Form
    {
        public Prescription_Button_Option()
        {
            InitializeComponent();
        }

        private void Prescription_Button_Option_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            form_HomePage Homepage = new form_HomePage();
            Homepage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Prescription_Table PrescriptionTab = new Form_Prescription_Table();
            PrescriptionTab.Show();
        }

        private void button_Add_Prescription_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Add_Prescription AddPrescription = new Form_Add_Prescription();
            AddPrescription.Show();
        }
    }
}
