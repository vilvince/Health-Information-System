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
    public partial class Doctor_Button_OPtions : Form
    {
        public Doctor_Button_OPtions()
        {
            InitializeComponent();
        }

        private void Doctor_Button_OPtions_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            form_HomePage Homepage = new form_HomePage();
            Homepage.Show();
        }

        private void button_Veiw_Doctor_Table_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Doctors_Table DocTable = new Form_Doctors_Table();
            DocTable.Show();
        }

        private void button_Add_New_Doctor_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the current form
            Form_Add_Doctor AddDoc = new Form_Add_Doctor();
            AddDoc.Show();
        }
    }
}
