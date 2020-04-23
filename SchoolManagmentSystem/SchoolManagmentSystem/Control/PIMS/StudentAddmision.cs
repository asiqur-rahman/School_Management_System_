using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagmentSystem.Model.Model.Administration;
using SchoolManagmentSystem.Model.Model.Student;
using SchoolManagmentSystem.BLL.BLL.Administration;
using SchoolManagmentSystem.BLL.BLL.PIMS;
using SchoolManagmentSystem.BLL.BLL.Others;

namespace SchoolManagmentSystem
{
    public partial class StudentAddmission : UserControl
    {
        ClassManager _classManager = new ClassManager();
        SectionManager _sectionManager = new SectionManager();
        GroupManager _groupManager = new GroupManager();
        ShiftManager _shiftManager = new ShiftManager();
        StudentInfoManager _studentInfoManager = new StudentInfoManager();

        StudentDetailsInfo _studentDetailsInfo;
        StudentInfo _studentInfo;

        DivisionManager _divisionManager = new DivisionManager();
        DistrictManager _districtManager = new DistrictManager();
        UpazilaManager _upazilaManager = new UpazilaManager();
        public StudentAddmission()
        {
            InitializeComponent();
            LoadComboBox();
            comboBoxClass.DataSource = _classManager.GetAll();
            comboBoxSection.DataSource = _sectionManager.GetAll();
            comboBoxGroup.DataSource = _groupManager.GetAll();
            comboBoxShift.DataSource = _shiftManager.GetAll();
            comboBoxPresentDivision.DataSource = _divisionManager.GetAll();
            comboBoxPermanentDivision.DataSource = _divisionManager.GetAll();
            comboBoxPresentDistrict.Enabled = false;
            comboBoxPresentUpazila.Enabled = false;
            comboBoxPermanentDistrict.Enabled = false;
            comboBoxPermanentUpazila.Enabled = false;
        }
        private void LoadComboBox()
        {
            List<string> comGender = new List<string>();
            List<string> comNatiolatity = new List<string>();
            List<string> comActive = new List<string>();
            List<string> comReligion = new List<string>();

            comGender.Add("--Select--");
            comGender.Add("Male");
            comGender.Add("Female");
            comGender.Add("Another");
            

            comNatiolatity.Add("--Select--");
            comNatiolatity.Add("Bangladeshi");
            comNatiolatity.Add("Foreign");

            comActive.Add("--Select--");
            comActive.Add("Active");
            comActive.Add("Not Active");

            comReligion.Add("--Select--");
            comReligion.Add("Islam");
            comReligion.Add("Hindu");
            comReligion.Add("Buddhism");
            comReligion.Add("Other");

            comboBoxGender.DataSource = comGender;
            comboBoxNationality.DataSource = comNatiolatity;
            comboBoxActive.DataSource = comActive;
            comboBoxReligion.DataSource = comReligion;

        }
        private void NumericCheck(object sender,KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void AllTextBoxClear()
        {
            textBoxRollNo.Clear();
            textBoxStudentNameEnglish.Clear();
            textBoxStudentNameBangla.Clear();
            textBoxStudentFatherName.Clear();
            textBoxStudentMotherName.Clear();

            textBoxPresentAddress.Clear();
            textBoxPresentPhoneNumber.Clear();

            textBoxPermanentAddress.Clear();
            textBoxPermanentPhoneNumber.Clear();
        }
        private bool IsNotEmpty(string text, string textBox)
        {
            if (text != "" || text!="--Select--" || text!=null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please Enter " + textBox + " !");
                return false;
            }
        }
        private bool AllTextFilled()
        {
            bool result = false;
            if (IsNotEmpty(textBoxRollNo.Text, labelRollNo.Text))
            {

                if (IsNotEmpty(textBoxStudentNameEnglish.Text, labelStudentNameEnglish.Text))
                {

                    if (IsNotEmpty(textBoxStudentNameBangla.Text, labelStudentNameBangla.Text))
                    {

                        if (IsNotEmpty(textBoxStudentFatherName.Text, labelStudentFatherName.Text))
                        {

                            if (IsNotEmpty(textBoxStudentMotherName.Text, labelStudentMotherName.Text))
                            {

                                if (IsNotEmpty(textBoxPresentAddress.Text, labelPresentAddress.Text))
                                {

                                    if (IsNotEmpty(comboBoxPresentDivision.Text, labelPresentDivision.Text))
                                    {

                                        if (IsNotEmpty(comboBoxPresentDistrict.Text, labelPresentDistrict.Text))
                                        {

                                            if (IsNotEmpty(comboBoxPresentUpazila.Text, labelPresentUpazila.Text))
                                            {
                                                
                                                if (IsNotEmpty(comboBoxPermanentDivision.Text, labelPermanentDivision.Text) || checkBoxSameAsPresentAddress.Checked == true)
                                                {

                                                    if (IsNotEmpty(comboBoxPermanentDistrict.Text, labelPermanentDistrict.Text) || checkBoxSameAsPresentAddress.Checked == true)
                                                    {

                                                        if (IsNotEmpty(comboBoxPermanentUpazila.Text, labelPermanentUpazila.Text) || checkBoxSameAsPresentAddress.Checked == true)
                                                        {

                                                            if (IsNotEmpty(textBoxPermanentPhoneNumber.Text, labelPermanentPhone.Text) || checkBoxSameAsPresentAddress.Checked == true)
                                                            {

                                                                if (IsNotEmpty(textBoxPermanentAddress.Text, labelPermanentAddress.Text) || checkBoxSameAsPresentAddress.Checked == true)
                                                                {

                                                                    if (IsNotEmpty(textBoxPresentPhoneNumber.Text, labelPresentPhone.Text))
                                                                    {

                                                                        if (IsNotEmpty(comboBoxClass.Text, labelClass.Text))
                                                                        {

                                                                            if (IsNotEmpty(comboBoxGroup.Text, labelClass.Text))
                                                                            {

                                                                                if (IsNotEmpty(comboBoxSection.Text, labelSection.Text))
                                                                                {

                                                                                    if (IsNotEmpty(comboBoxShift.Text, labelShift.Text))
                                                                                    {

                                                                                         result = true;
                                                                                        
                                                                                    }
                                                                                }
                                                                            
                                                                            }

                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }      
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if(AllTextFilled())
            {
                _studentInfo = new StudentInfo();
                _studentDetailsInfo = new StudentDetailsInfo();

                _studentDetailsInfo.StudentId = "N/A";
                _studentDetailsInfo.ShiftName = comboBoxShift.Text;
                _studentDetailsInfo.RollNo = textBoxRollNo.Text;
                _studentDetailsInfo.ClassName = comboBoxClass.Text;
                _studentDetailsInfo.GroupName = comboBoxGroup.Text;
                _studentDetailsInfo.SectionName = comboBoxSection.Text;
                _studentDetailsInfo.Session = Convert.ToInt32(textBoxSession.Text);

                _studentInfo.DetailsInfo = _studentDetailsInfo;

                _studentInfo.NameEnglish = textBoxStudentNameEnglish.Text;
                _studentInfo.NameBengali = textBoxStudentNameBangla.Text;
                _studentInfo.DateOfBirth = dateTimePickerDateOfBirth.Value;
                _studentInfo.Nationality = comboBoxNationality.Text;
                _studentInfo.Gender = comboBoxGender.Text;
                _studentInfo.Religion = comboBoxReligion.Text;
                _studentInfo.Active = comboBoxActive.Text;
                _studentInfo.PresentAddress = textBoxPresentAddress.Text;
                _studentInfo.PresentPO = comboBoxPresentDivision.Text;
                _studentInfo.PresentPS = comboBoxPresentUpazila.Text;
                _studentInfo.PresentDistrict = comboBoxPresentDistrict.Text;
                _studentInfo.PresentPhone = textBoxPresentPhoneNumber.Text;

                if(checkBoxSameAsPresentAddress.Checked==true)
                {
                    _studentInfo.PermanentAddress = textBoxPresentAddress.Text;
                    _studentInfo.PermanentPO = comboBoxPresentDivision.Text;
                    _studentInfo.PermanentPS = comboBoxPresentUpazila.Text;
                    _studentInfo.PermanentDistrict = comboBoxPresentDistrict.Text;
                    _studentInfo.PermanentPhone = textBoxPresentPhoneNumber.Text;
                }
                else
                {
                    _studentInfo.PermanentAddress = textBoxPermanentAddress.Text;
                    _studentInfo.PermanentPO = comboBoxPermanentDivision.Text;
                    _studentInfo.PermanentPS = comboBoxPermanentUpazila.Text;
                    _studentInfo.PermanentDistrict = comboBoxPermanentDistrict.Text;
                    _studentInfo.PermanentPhone = textBoxPermanentPhoneNumber.Text;
                }

                _studentInfo.GuardianName = textBoxGuardianName.Text;
                _studentInfo.GuardianAddress = textBoxGuardianAddress.Text;
                _studentInfo.UpdateBy = "admin";
                _studentInfo.UpdateDate = DateTime.Now;

                _studentInfoManager.Add(_studentInfo);
            }
        }

        private void iconButtonReset_Click(object sender, EventArgs e)
        {
            AllTextBoxClear();
        }

        private void comboBoxPresentDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxPresentDivision.Text!="--Select--")
            {
                comboBoxPresentDistrict.DataSource = _districtManager.GetAll((int)comboBoxPresentDivision.SelectedValue);
                comboBoxPresentDistrict.Enabled = true;
            }
            else
            {
                comboBoxPresentDistrict.Enabled = false;
            }
        }

        private void comboBoxPresentDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPresentUpazila.DataSource = _upazilaManager.GetAll((int)comboBoxPresentDistrict.SelectedValue);
            comboBoxPresentUpazila.Enabled = true;
        }

        private void comboBoxPermanentDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPermanentDistrict.DataSource= _districtManager.GetAll((int)comboBoxPermanentDivision.SelectedValue);
            comboBoxPermanentDistrict.Enabled = true;
        }

        private void comboBoxPermanentDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPermanentUpazila.DataSource= _upazilaManager.GetAll((int)comboBoxPermanentDistrict.SelectedValue);
            comboBoxPermanentUpazila.Enabled = true;
        }

        private void textBoxRollNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericCheck(sender,e);
        }

        private void textBoxSession_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericCheck(sender, e);
        }

        private void textBoxPresentPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericCheck(sender, e);
        }

        private void textBoxPermanentPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericCheck(sender, e);
        }

        private void checkBoxSameAsPresentAddress_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSameAsPresentAddress.Checked==true)
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
