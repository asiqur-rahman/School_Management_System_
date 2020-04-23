using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem
{
    public partial class EmployeeRegistration : UserControl
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxSameAsPresentAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSameAsPresentAddress.Checked == true)
            {
                groupBoxPermanentAddress.Hide();
            }
            else
            {
                groupBoxPermanentAddress.Show();
            }
        }
    }
}
