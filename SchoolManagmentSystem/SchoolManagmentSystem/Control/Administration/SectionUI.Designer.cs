namespace SchoolManagmentSystem
{
    partial class SectionUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconButtonReset = new FontAwesome.Sharp.IconButton();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxShift = new System.Windows.Forms.ComboBox();
            this.shiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSectionName = new System.Windows.Forms.TextBox();
            this.labelSectionName = new System.Windows.Forms.Label();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.textBoxSctionCode = new System.Windows.Forms.TextBox();
            this.iconButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.labelSectionCode = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.sectionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.shiftIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconButtonReset);
            this.groupBox1.Controls.Add(this.comboBoxClass);
            this.groupBox1.Controls.Add(this.comboBoxShift);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSectionName);
            this.groupBox1.Controls.Add(this.labelSectionName);
            this.groupBox1.Controls.Add(this.iconButtonDelete);
            this.groupBox1.Controls.Add(this.textBoxSctionCode);
            this.groupBox1.Controls.Add(this.iconButtonUpdate);
            this.groupBox1.Controls.Add(this.iconButtonSave);
            this.groupBox1.Controls.Add(this.labelSectionCode);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(34, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1201, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // iconButtonReset
            // 
            this.iconButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButtonReset.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButtonReset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonReset.IconColor = System.Drawing.Color.Black;
            this.iconButtonReset.IconSize = 16;
            this.iconButtonReset.Location = new System.Drawing.Point(841, 158);
            this.iconButtonReset.Name = "iconButtonReset";
            this.iconButtonReset.Rotation = 0D;
            this.iconButtonReset.Size = new System.Drawing.Size(181, 36);
            this.iconButtonReset.TabIndex = 24;
            this.iconButtonReset.Text = "Reset";
            this.iconButtonReset.UseVisualStyleBackColor = true;
            this.iconButtonReset.Click += new System.EventHandler(this.iconButtonReset_Click);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DataSource = this.classBindingSource;
            this.comboBoxClass.DisplayMember = "ClassName";
            this.comboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(218, 99);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(262, 30);
            this.comboBoxClass.TabIndex = 23;
            this.comboBoxClass.ValueMember = "Id";
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(SchoolManagmentSystem.Model.Model.Administration.Class);
            // 
            // comboBoxShift
            // 
            this.comboBoxShift.DataSource = this.shiftBindingSource;
            this.comboBoxShift.DisplayMember = "ShiftName";
            this.comboBoxShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxShift.FormattingEnabled = true;
            this.comboBoxShift.Location = new System.Drawing.Point(218, 43);
            this.comboBoxShift.Name = "comboBoxShift";
            this.comboBoxShift.Size = new System.Drawing.Size(262, 30);
            this.comboBoxShift.TabIndex = 22;
            this.comboBoxShift.ValueMember = "Id";
            this.comboBoxShift.SelectedIndexChanged += new System.EventHandler(this.comboBoxShift_SelectedIndexChanged);
            // 
            // shiftBindingSource
            // 
            this.shiftBindingSource.DataSource = typeof(SchoolManagmentSystem.Model.Model.Administration.Shift);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Shift";
            // 
            // textBoxSectionName
            // 
            this.textBoxSectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSectionName.Location = new System.Drawing.Point(803, 98);
            this.textBoxSectionName.Name = "textBoxSectionName";
            this.textBoxSectionName.Size = new System.Drawing.Size(242, 28);
            this.textBoxSectionName.TabIndex = 18;
            // 
            // labelSectionName
            // 
            this.labelSectionName.AutoSize = true;
            this.labelSectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectionName.Location = new System.Drawing.Point(613, 101);
            this.labelSectionName.Name = "labelSectionName";
            this.labelSectionName.Size = new System.Drawing.Size(129, 24);
            this.labelSectionName.TabIndex = 17;
            this.labelSectionName.Text = "Section Name";
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButtonDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonDelete.IconColor = System.Drawing.Color.Black;
            this.iconButtonDelete.IconSize = 16;
            this.iconButtonDelete.Location = new System.Drawing.Point(613, 158);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Rotation = 0D;
            this.iconButtonDelete.Size = new System.Drawing.Size(181, 36);
            this.iconButtonDelete.TabIndex = 16;
            this.iconButtonDelete.Text = "Delete";
            this.iconButtonDelete.UseVisualStyleBackColor = true;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // textBoxSctionCode
            // 
            this.textBoxSctionCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSctionCode.Location = new System.Drawing.Point(803, 40);
            this.textBoxSctionCode.Name = "textBoxSctionCode";
            this.textBoxSctionCode.Size = new System.Drawing.Size(242, 28);
            this.textBoxSctionCode.TabIndex = 15;
            // 
            // iconButtonUpdate
            // 
            this.iconButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButtonUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonUpdate.IconColor = System.Drawing.Color.Black;
            this.iconButtonUpdate.IconSize = 16;
            this.iconButtonUpdate.Location = new System.Drawing.Point(394, 158);
            this.iconButtonUpdate.Name = "iconButtonUpdate";
            this.iconButtonUpdate.Rotation = 0D;
            this.iconButtonUpdate.Size = new System.Drawing.Size(181, 36);
            this.iconButtonUpdate.TabIndex = 14;
            this.iconButtonUpdate.Text = "Update";
            this.iconButtonUpdate.UseVisualStyleBackColor = true;
            this.iconButtonUpdate.Click += new System.EventHandler(this.iconButtonUpdate_Click);
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButtonSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSave.IconColor = System.Drawing.Color.Black;
            this.iconButtonSave.IconSize = 16;
            this.iconButtonSave.Location = new System.Drawing.Point(168, 158);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Rotation = 0D;
            this.iconButtonSave.Size = new System.Drawing.Size(181, 36);
            this.iconButtonSave.TabIndex = 13;
            this.iconButtonSave.Text = "Save";
            this.iconButtonSave.UseVisualStyleBackColor = true;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // labelSectionCode
            // 
            this.labelSectionCode.AutoSize = true;
            this.labelSectionCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectionCode.Location = new System.Drawing.Point(613, 43);
            this.labelSectionCode.Name = "labelSectionCode";
            this.labelSectionCode.Size = new System.Drawing.Size(124, 24);
            this.labelSectionCode.TabIndex = 4;
            this.labelSectionCode.Text = "Section Code";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial,
            this.Id,
            this.sectionCodeDataGridViewTextBoxColumn,
            this.sectionNameDataGridViewTextBoxColumn,
            this.shiftNameDataGridViewTextBoxColumn,
            this.classNameDataGridViewTextBoxColumn,
            this.entryByDataGridViewTextBoxColumn,
            this.entryDateDataGridViewTextBoxColumn,
            this.Edit,
            this.shiftIdDataGridViewTextBoxColumn,
            this.classIdDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.sectionBindingSource2;
            this.dataGridView.Location = new System.Drawing.Point(34, 258);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1201, 629);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // sectionBindingSource2
            // 
            this.sectionBindingSource2.DataSource = typeof(SchoolManagmentSystem.Model.Model.Administration.Section);
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataSource = typeof(SchoolManagmentSystem.Model.Model.Administration.Section);
            // 
            // sectionBindingSource1
            // 
            this.sectionBindingSource1.DataSource = typeof(SchoolManagmentSystem.Model.Model.Administration.Section);
            // 
            // Serial
            // 
            this.Serial.HeaderText = "Serial";
            this.Serial.MinimumWidth = 6;
            this.Serial.Name = "Serial";
            this.Serial.Width = 125;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // sectionCodeDataGridViewTextBoxColumn
            // 
            this.sectionCodeDataGridViewTextBoxColumn.DataPropertyName = "SectionCode";
            this.sectionCodeDataGridViewTextBoxColumn.HeaderText = "SectionCode";
            this.sectionCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectionCodeDataGridViewTextBoxColumn.Name = "sectionCodeDataGridViewTextBoxColumn";
            this.sectionCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sectionNameDataGridViewTextBoxColumn
            // 
            this.sectionNameDataGridViewTextBoxColumn.DataPropertyName = "SectionName";
            this.sectionNameDataGridViewTextBoxColumn.HeaderText = "SectionName";
            this.sectionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectionNameDataGridViewTextBoxColumn.Name = "sectionNameDataGridViewTextBoxColumn";
            this.sectionNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // shiftNameDataGridViewTextBoxColumn
            // 
            this.shiftNameDataGridViewTextBoxColumn.DataPropertyName = "ShiftName";
            this.shiftNameDataGridViewTextBoxColumn.HeaderText = "ShiftName";
            this.shiftNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shiftNameDataGridViewTextBoxColumn.Name = "shiftNameDataGridViewTextBoxColumn";
            this.shiftNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "ClassName";
            this.classNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            this.classNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // entryByDataGridViewTextBoxColumn
            // 
            this.entryByDataGridViewTextBoxColumn.DataPropertyName = "EntryBy";
            this.entryByDataGridViewTextBoxColumn.HeaderText = "EntryBy";
            this.entryByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.entryByDataGridViewTextBoxColumn.Name = "entryByDataGridViewTextBoxColumn";
            this.entryByDataGridViewTextBoxColumn.Width = 125;
            // 
            // entryDateDataGridViewTextBoxColumn
            // 
            this.entryDateDataGridViewTextBoxColumn.DataPropertyName = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.HeaderText = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.entryDateDataGridViewTextBoxColumn.Name = "entryDateDataGridViewTextBoxColumn";
            this.entryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Id";
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 125;
            // 
            // shiftIdDataGridViewTextBoxColumn
            // 
            this.shiftIdDataGridViewTextBoxColumn.DataPropertyName = "ShiftId";
            this.shiftIdDataGridViewTextBoxColumn.HeaderText = "ShiftId";
            this.shiftIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shiftIdDataGridViewTextBoxColumn.Name = "shiftIdDataGridViewTextBoxColumn";
            this.shiftIdDataGridViewTextBoxColumn.Visible = false;
            this.shiftIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // classIdDataGridViewTextBoxColumn
            // 
            this.classIdDataGridViewTextBoxColumn.DataPropertyName = "ClassId";
            this.classIdDataGridViewTextBoxColumn.HeaderText = "ClassId";
            this.classIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classIdDataGridViewTextBoxColumn.Name = "classIdDataGridViewTextBoxColumn";
            this.classIdDataGridViewTextBoxColumn.Visible = false;
            this.classIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // SectionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "SectionUI";
            this.Size = new System.Drawing.Size(1267, 890);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private FontAwesome.Sharp.IconButton iconButtonUpdate;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private System.Windows.Forms.TextBox textBoxSctionCode;
        private System.Windows.Forms.Label labelSectionCode;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private System.Windows.Forms.TextBox textBoxSectionName;
        private System.Windows.Forms.Label labelSectionName;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.ComboBox comboBoxShift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButtonReset;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.BindingSource shiftBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sectionBindingSource1;
        private System.Windows.Forms.BindingSource sectionBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIdDataGridViewTextBoxColumn;
    }
}
