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
    public partial class GroupUI : UserControl
    {
        PopupNotifier popup = new PopupNotifier();
        private void Notify(string title, string cont)
        {
            popup.TitleText = title;
            popup.ContentText = cont;
            popup.Popup();
        }
        Group _group = new Group();
        GroupManager _groupManager = new GroupManager();
        private int groupId;
        public GroupUI()
        {
            InitializeComponent();
            AllButtonDeactive();
            FillDataGridView();
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void FillDataGridView()
        {
            dataGridView.DataSource = _groupManager.GetAll();
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
            textBoxGroupName.Clear();
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
            if (IsNotEmpty(textBoxGroupName.Text, labelGroupName.Text))
            {
                _group.GroupName = textBoxGroupName.Text;
                _group.EntryDate = DateTime.Now;
                _group.EntryBy = "admin";
                if (_groupManager.Add(_group))
                {
                    //MessageBox.Show("Added Successfully");
                    Notify("Group Added Successfully !", "Group " + textBoxGroupName.Text + " Added Successfully");
                }
                AllTextBoxClear();
                FillDataGridView();
            }
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(textBoxGroupName.Text, labelGroupName.Text))
            {
                _group.GroupName = textBoxGroupName.Text;
                _group.EntryDate = DateTime.Now;
                _group.EntryBy = "admin";
                if (_groupManager.Update(_group))
                {
                    //MessageBox.Show("Updated Successfully");
                    Notify("Group Updated Successfully !", "Group " + textBoxGroupName.Text + " Updated Successfully");
                }
                AllTextBoxClear();
                FillDataGridView();
                AllButtonDeactive();
            }
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            _group = _groupManager.GetById(groupId);
            if (_groupManager.Delete(_group))
            {
                //MessageBox.Show("Delete Successfully");
                Notify("Group Deleted Successfully !", "Group " + textBoxGroupName.Text + " Deleted Successfully");
            }
            AllTextBoxClear();
            FillDataGridView();
            AllButtonDeactive();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                AllButtonActive();
                iconButtonSave.Enabled = false;
                groupId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                _group = _groupManager.GetById(groupId);
                textBoxGroupName.Text = _group.GroupName;

            }
        }

        private void iconButtonReset_Click(object sender, EventArgs e)
        {
            AllButtonDeactive();
            AllTextBoxClear();
        }
    }
}
