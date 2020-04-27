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
using SchoolManagmentSystem.BLL.BLL.Administration;
using Tulpep.NotificationWindow;

namespace SchoolManagmentSystem
{
    public partial class ClassUI : UserControl
    {
        PopupNotifier popup = new PopupNotifier();

        private void Notify(string title, string cont)
        {
            popup.Image = Properties.Resources.Notification;
            popup.TitleText = title;
            popup.ContentText = cont;
            popup.Popup();
        }
        Class _class = new Class();
        ClassManager _classManager = new ClassManager();
        private int classId;
        public ClassUI()
        {
            InitializeComponent();
            FillDataGridView();
            AllButtonDeactive();
        }
        private void FillDataGridView()
        {
            dataGridView.DataSource = _classManager.GetAll();
        }
        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if(IsNotEmpty(textBoxClassName.Text,labelClassName.Text) && IsNotEmpty(textBoxShortName.Text, labelShortName.Text))
            {
                _class.ClassName = textBoxClassName.Text;
                _class.ClassShortName = textBoxShortName.Text;
                _class.EntryDate = DateTime.Now;
                _class.EntryBy = "admin";
                if(_classManager.Add(_class))
                {
                    Notify("Section Added Successfully !", "Section " + textBoxClassName.Text+" Added Successfully");
                }
                AllTextBoxClear();
                FillDataGridView();
            }
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                AllButtonActive();
                //MessageBox.Show(dataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                classId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                _class = _classManager.GetById(classId);
                textBoxClassName.Text = _class.ClassName;
                textBoxShortName.Text = _class.ClassShortName;

            }
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(textBoxClassName.Text, labelClassName.Text) && IsNotEmpty(textBoxShortName.Text, labelShortName.Text))
            {
                _class = _classManager.GetById(classId);
                _class.ClassName = textBoxClassName.Text;
                _class.ClassShortName= textBoxShortName.Text;

                if(_classManager.Update(_class))
                {
                    //MessageBox.Show("Updated Successfully");
                    Notify("Section Updated Successfully !", "Section "+textBoxClassName.Text + " Updated Successfully");
                }
                AllTextBoxClear();
                FillDataGridView();
            }
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            _class = _classManager.GetById(classId);
            if (_classManager.Delete(_class))
            {
                //MessageBox.Show("Delete Successfully");
                Notify(""," Section Delete Successfully !");
            }
            AllTextBoxClear();
            FillDataGridView();
        }
        private void iconButtonReset_Click(object sender, EventArgs e)
        {
            AllButtonDeactive();
            AllTextBoxClear();
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
            textBoxClassName.Clear();
            textBoxShortName.Clear();
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

    }
}
