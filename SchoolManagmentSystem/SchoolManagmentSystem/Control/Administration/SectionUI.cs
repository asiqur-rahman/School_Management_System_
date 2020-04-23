using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagmentSystem.BLL.BLL.Administration;
using SchoolManagmentSystem.Model.Model.Administration;

namespace SchoolManagmentSystem
{
    public partial class SectionUI : UserControl
    {
        ClassManager _classManager = new ClassManager();
        ShiftManager _shiftManager = new ShiftManager();
        SectionManager _sectionManager = new SectionManager();
        Section _section = new Section();
        private int sectionId;
        public SectionUI()
        {
            InitializeComponent();
            AllButtonDeactive();
            comboBoxClass.DataSource= _classManager.GetAll();
            comboBoxShift.DataSource = _shiftManager.GetAll();
            FillDataGridView();
            FillSectionCode();
        }
        private void FillSectionCode()
        {
            string shiftName = comboBoxShift.Text;
            if (shiftName!="" && comboBoxClass.SelectedValue!= null)
            {
                int classId = (int)comboBoxClass.SelectedValue;
                Class clas = _classManager.GetById(classId);
                textBoxSctionCode.Text = (DateTime.Now.Year.ToString()) + (shiftName.Substring(0, 2)) + (clas.ClassShortName);
            }
            
        }
        private void FillDataGridView()
        {
            dataGridView.DataSource = _sectionManager.GetAll();
        }
        private bool IsNotEmpty(string text, string textBox)
        {
            if (text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please Enter " + textBox + " !");
                return false;
            }
        }
        private void AllTextBoxClear()
        {
            textBoxSctionCode.Clear();
            textBoxSectionName.Clear();
        }
        private void AllButtonDeactive()
        {
            iconButtonSave.Enabled = true;
            iconButtonDelete.Enabled = false;
            iconButtonReset.Enabled = false;
            iconButtonUpdate.Enabled = false;

        }
        private void AllButtonActive()
        {
            iconButtonSave.Enabled = false;
            iconButtonDelete.Enabled = true;
            iconButtonReset.Enabled = true;
            iconButtonUpdate.Enabled = true;

        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(textBoxSctionCode.Text, labelSectionCode.Text) && IsNotEmpty(textBoxSectionName.Text, labelSectionName.Text))
            {
                _section.ShiftId = (int)comboBoxShift.SelectedValue;
                _section.ClassId=(int)comboBoxClass.SelectedValue;
                _section.ClassName = comboBoxClass.Text;
                _section.ShiftName = comboBoxShift.Text;
                _section.SectionCode = textBoxSctionCode.Text;
                _section.SectionName = textBoxSectionName.Text;
                _section.EntryDate = DateTime.Now;
                _section.EntryBy = "admin";
                if (_sectionManager.Add(_section))
                {
                    MessageBox.Show("Added Successfully");
                }
                AllTextBoxClear();
                FillDataGridView();
            }
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(textBoxSctionCode.Text, labelSectionCode.Text) && IsNotEmpty(textBoxSectionName.Text, labelSectionName.Text))
            {
                _section.ShiftId = (int)comboBoxShift.SelectedValue;
                _section.ClassId = (int)comboBoxClass.SelectedValue;
                _section.ClassName = comboBoxClass.Text;
                _section.ShiftName = comboBoxShift.Text;
                _section.SectionCode = textBoxSctionCode.Text;
                _section.SectionName = textBoxSectionName.Text;
                _section.EntryDate = DateTime.Now;
                _section.EntryBy = "admin";
                if (_sectionManager.Update(_section))
                {
                    MessageBox.Show("Added Successfully");
                }
                AllTextBoxClear();
                FillDataGridView();
                AllButtonDeactive();
            }
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            _section = _sectionManager.GetById(sectionId);
            if (_sectionManager.Delete(_section))
            {
                MessageBox.Show("Delete Successfully");
            }
            AllTextBoxClear();
            FillDataGridView();
            AllButtonDeactive();
        }

        private void iconButtonReset_Click(object sender, EventArgs e)
        {
            AllButtonDeactive();
            AllTextBoxClear();
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSectionCode();
        }

        private void comboBoxShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSectionCode();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                AllButtonActive();
                iconButtonSave.Enabled = false;
                sectionId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                _section = _sectionManager.GetById(sectionId);
                textBoxSectionName.Text = _section.SectionName;
                textBoxSctionCode.Text = _section.SectionCode;
            }
        }
    }
}
