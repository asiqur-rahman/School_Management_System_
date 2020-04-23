using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace SchoolManagmentSystem
{
    public partial class AdminUI : Form
    {
        private IconButton currentBtn;
        private UserControl currentChild;
        public AdminUI()
        {
            InitializeComponent();
            AllPanelDisable();
        }
        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(24, 161, 251);
        }
        private bool ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn!= null && currentBtn!=senderBtn)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign=ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;


                //Active Title
                activeIconPictureBox.IconChar = currentBtn.IconChar;
                activeIconPictureBox.IconColor = color;
                activeLabel.Text = currentBtn.Text;

                panelBorder.BackColor = color;
                panelTop.BackColor = color;

                return true;
            }
            else
            {
                return false;
            }

        }
        private void DisableButton()
        {
            if(currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(33, 43, 52);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

                activeIconPictureBox.IconChar = IconChar.Home;
                activeIconPictureBox.IconColor = Color.White;
                activeLabel.Text = "Home";
                panelBorder.BackColor = Color.Gray;
                panelTop.BackColor = Color.Gray;
                currentChild.Dispose();
            }
        }

        private void AllPanelDisable()
        {
            panelPIMS.Visible = false;
            panelAttendance.Visible = false;
            panelAdministrative.Visible = false;
            panelResult.Visible = false;
            panelRoutine.Visible = false;
        }
        private void OpenChild(UserControl childForm)
        {
            if(currentChild!=null)
            {
                currentChild.Dispose();
            }
            currentChild = childForm;
            panelDesktop.Controls.Add(childForm);
        }

        
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            AllPanelDisable();
        }

        private void activeIconPictureBox_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void panelLogo_MouseClick(object sender, MouseEventArgs e)
        {
            Reset();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            if (panelPIMS.Visible==false)
            {
                panelPIMS.Visible = true;
            }
            else
            {
                panelPIMS.Visible = false;
            }
        }

        private void stuRegBtn_Click(object sender, EventArgs e)
        {
            if(ActiveButton(sender, RGBcolors.color1))
            OpenChild(new StudentAddmission());
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            WindowState  = FormWindowState.Minimized;
        }

        private void empRegBtn_Click_1(object sender, EventArgs e)
        {
            if (ActiveButton(sender, RGBcolors.color2))
                OpenChild(new EmployeeRegistration());
        }

        private void stuListBtn_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender, RGBcolors.color3))
                OpenChild(new StudentList());
        }

        private void empListBtn_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender, RGBcolors.color4))
                OpenChild(new EmployeeList());
        }

        private void iconButtonAttendance_Click(object sender, EventArgs e)
        {
            if (panelAttendance.Visible == false)
            {
                panelAttendance.Visible = true;
            }
            else
            {
                panelAttendance.Visible = false;
            }
        }

        private void iconButtonAdministration_Click(object sender, EventArgs e)
        {
            if (panelAdministrative.Visible == false)
            {
                panelAdministrative.Visible = true;
            }
            else
            {
                panelAdministrative.Visible = false;
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonResult_Click(object sender, EventArgs e)
        {
            if (panelResult.Visible == false)
            {
                panelResult.Visible = true;
            }
            else
            {
                panelResult.Visible = false;
            }
        }

        private void iconButtonRoutine_Click(object sender, EventArgs e)
        {
            if (panelRoutine.Visible == false)
            {
                panelRoutine.Visible = true;
            }
            else
            {
                panelRoutine.Visible = false;
            }
        }

        private void iconButtonEmployeeAttendance_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender, RGBcolors.color5))
                OpenChild(new EmployeeAttendance());
        }

        private void iconButtonStudentAttendance_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender, RGBcolors.color1))
                OpenChild(new StudentAttendance());
        }

        private void iconButtonShift_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender, RGBcolors.color1))
                OpenChild(new ShiftUI());
        }

        private void iconButtonClass_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender, RGBcolors.color2))
                OpenChild(new ClassUI());
        }

        private void iconButtonSubjective_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender, RGBcolors.color3))
                OpenChild(new SubjectUI());
        }

        private void iconButtonSection_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender, RGBcolors.color4))
                OpenChild(new SectionUI());
        }

        private void iconButtonGroup_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender, RGBcolors.color5))
                OpenChild(new GroupUI());
        }
    }
    
}
