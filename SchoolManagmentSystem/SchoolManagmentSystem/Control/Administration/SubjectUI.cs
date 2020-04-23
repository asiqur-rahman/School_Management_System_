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
    public partial class SubjectUI : UserControl
    {
        SubjectManager _subjectManager = new SubjectManager();
        Subject _subject = new Subject();
        private int subjectId;
        public SubjectUI()
        {
            InitializeComponent();
            AllButtonDeactive();
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            dataGridView.DataSource = _subjectManager.GetAll();
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
            textBoxSubjectCode.Clear();
            textBoxSubjectName.Clear();
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
        private string GetSelectedRadioButton()
        {
            if (radioButtonObjective.Checked == true)
            {
                return "Objective";
            }
            else if (radioButtonSelective.Checked == true)
            {
                return "Selective";
            }
            else if (radioButtonSubjective.Checked == true)
            {
                return "Subjective";
            }
            else
            {
                return null;
            }
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(textBoxSubjectCode.Text, labelSubjectCode.Text) && IsNotEmpty(textBoxSubjectName.Text, labelSubjectName.Text))
            {
                if(GetSelectedRadioButton()!=null)
                {
                    _subject.SubjectCode = textBoxSubjectCode.Text;
                    _subject.SubjectName = textBoxSubjectName.Text;
                    _subject.SubjectType = GetSelectedRadioButton();
                    _subject.EntryBy = "admin";
                    _subject.EntryDate = DateTime.Now;
                    if (_subjectManager.Add(_subject))
                    {
                        MessageBox.Show("Added Successfully");
                    }
                    AllTextBoxClear();
                    FillDataGridView();
                }
                else
                {
                    MessageBox.Show("Please Select Subject !");
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                AllButtonActive();
                iconButtonSave.Enabled = false;
                subjectId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                _subject = _subjectManager.GetById(subjectId);
                textBoxSubjectCode.Text = _subject.SubjectCode;
                textBoxSubjectName.Text = _subject.SubjectName;
            }
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(textBoxSubjectCode.Text, labelSubjectCode.Text) && IsNotEmpty(textBoxSubjectName.Text, labelSubjectName.Text))
            {
                if (GetSelectedRadioButton() != null)
                {
                    _subject.SubjectCode = textBoxSubjectCode.Text;
                    _subject.SubjectName = textBoxSubjectName.Text;
                    _subject.SubjectType = GetSelectedRadioButton();
                    _subject.EntryBy = "admin";
                    _subject.EntryDate = DateTime.Now;
                    if (_subjectManager.Update(_subject))
                    {
                        MessageBox.Show("Updated Successfully");
                    }
                    AllTextBoxClear();
                    FillDataGridView();
                }
                else
                {
                    MessageBox.Show("Please Select Subject !");
                }
            }
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            _subject = _subjectManager.GetById(subjectId);
            if (_subjectManager.Delete(_subject))
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
    }
}
