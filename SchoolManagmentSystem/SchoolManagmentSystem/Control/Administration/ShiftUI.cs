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

namespace SchoolManagmentSystem
{
    public partial class ShiftUI : UserControl
    {
        ShiftManager _shiftManager = new ShiftManager();
        Shift _shift = new Shift();
        private int shiftId;
        public ShiftUI()
        {
            InitializeComponent();
            AllButtonDeactive();
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            dataGridView.DataSource = _shiftManager.GetAll();
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
            textBoxShiftName.Clear();
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
        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(textBoxShiftName.Text, labelShiftName.Text))
            {
                _shift.ShiftName = textBoxShiftName.Text;
                _shift.EntryDate = DateTime.Now;
                _shift.EntryBy = "admin";
                if (_shiftManager.Add(_shift))
                {
                    MessageBox.Show("Added Successfully");
                }
                AllTextBoxClear();
                FillDataGridView();
            }
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(textBoxShiftName.Text, labelShiftName.Text))
            {
                _shift.ShiftName = textBoxShiftName.Text;
                _shift.EntryDate = DateTime.Now;
                _shift.EntryBy = "admin";
                if (_shiftManager.Update(_shift))
                {
                    MessageBox.Show("Updated Successfully");
                }
                AllTextBoxClear();
                FillDataGridView();
                AllButtonDeactive();
            }
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            _shift = _shiftManager.GetById(shiftId);
            if (_shiftManager.Delete(_shift))
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                AllButtonActive();
                iconButtonSave.Enabled = false;
                shiftId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                _shift = _shiftManager.GetById(shiftId);
                textBoxShiftName.Text = _shift.ShiftName;
            }
        }
    }
}
