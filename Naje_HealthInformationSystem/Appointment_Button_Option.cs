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
    public partial class Appointment_Button_Option : Form
    {
        public Appointment_Button_Option()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            form_HomePage Homepage = new form_HomePage();
            Homepage.Show();
        }

        private void button_View_Appointment_Table_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Appointment_Table AppointmentTable = new Form_Appointment_Table();
            AppointmentTable.Show();
        }

        private void button_Add_Appointment_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Add_Appointment AddApp = new Form_Add_Appointment();
            AddApp.Show();
        }

        private void Appointment_Button_Option_Load(object sender, EventArgs e)
        {

        }
    }
}
