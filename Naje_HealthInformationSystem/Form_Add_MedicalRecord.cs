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
    public partial class Form_Add_MedicalRecord : Form
    {
        public Form_Add_MedicalRecord()
        {
            InitializeComponent();
        }

        private void Form_Add_MedicalRecord_Load(object sender, EventArgs e)
        {

        }

        private void label_Diagnosis_Click(object sender, EventArgs e)
        {

        }

        private void label_Treatment_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Treatment_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Findings_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Medical_record_Button_Option MedBut = new Medical_record_Button_Option();
            MedBut.Show();
        }
    }
}
