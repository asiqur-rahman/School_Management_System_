namespace SchoolManagmentSystem
{
    partial class SubjectUI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonSubjective = new System.Windows.Forms.RadioButton();
            this.radioButtonObjective = new System.Windows.Forms.RadioButton();
            this.radioButtonSelective = new System.Windows.Forms.RadioButton();
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.labelSubjectName = new System.Windows.Forms.Label();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.textBoxSubjectCode = new System.Windows.Forms.TextBox();
            this.iconButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.labelSubjectCode = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iconButtonReset = new FontAwesome.Sharp.IconButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconButtonReset);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxSubjectName);
            this.groupBox1.Controls.Add(this.labelSubjectName);
            this.groupBox1.Controls.Add(this.iconButtonDelete);
            this.groupBox1.Controls.Add(this.textBoxSubjectCode);
            this.groupBox1.Controls.Add(this.iconButtonUpdate);
            this.groupBox1.Controls.Add(this.iconButtonSave);
            this.groupBox1.Controls.Add(this.labelSubjectCode);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(34, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1201, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonSubjective);
            this.groupBox2.Controls.Add(this.radioButtonObjective);
            this.groupBox2.Controls.Add(this.radioButtonSelective);
            this.groupBox2.Location = new System.Drawing.Point(489, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 74);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonSubjective
            // 
            this.radioButtonSubjective.AutoSize = true;
            this.radioButtonSubjective.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSubjective.Location = new System.Drawing.Point(54, 25);
            this.radioButtonSubjective.Name = "radioButtonSubjective";
            this.radioButtonSubjective.Size = new System.Drawing.Size(118, 28);
            this.radioButtonSubjective.TabIndex = 24;
            this.radioButtonSubjective.TabStop = true;
            this.radioButtonSubjective.Text = "Subjective";
            this.radioButtonSubjective.UseVisualStyleBackColor = true;
            // 
            // radioButtonObjective
            // 
            this.radioButtonObjective.AutoSize = true;
            this.radioButtonObjective.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonObjective.Location = new System.Drawing.Point(519, 25);
            this.radioButtonObjective.Name = "radioButtonObjective";
            this.radioButtonObjective.Size = new System.Drawing.Size(110, 28);
            this.radioButtonObjective.TabIndex = 23;
            this.radioButtonObjective.TabStop = true;
            this.radioButtonObjective.Text = "Objective";
            this.radioButtonObjective.UseVisualStyleBackColor = true;
            // 
            // radioButtonSelective
            // 
            this.radioButtonSelective.AutoSize = true;
            this.radioButtonSelective.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSelective.Location = new System.Drawing.Point(291, 25);
            this.radioButtonSelective.Name = "radioButtonSelective";
            this.radioButtonSelective.Size = new System.Drawing.Size(107, 28);
            this.radioButtonSelective.TabIndex = 22;
            this.radioButtonSelective.TabStop = true;
            this.radioButtonSelective.Text = "Selective";
            this.radioButtonSelective.UseVisualStyleBackColor = true;
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectName.Location = new System.Drawing.Point(160, 101);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(242, 28);
            this.textBoxSubjectName.TabIndex = 18;
            // 
            // labelSubjectName
            // 
            this.labelSubjectName.AutoSize = true;
            this.labelSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjectName.Location = new System.Drawing.Point(27, 104);
            this.labelSubjectName.Name = "labelSubjectName";
            this.labelSubjectName.Size = new System.Drawing.Size(129, 24);
            this.labelSubjectName.TabIndex = 17;
            this.labelSubjectName.Text = "Subject Name";
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
            this.iconButtonDelete.Location = new System.Drawing.Point(851, 107);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Rotation = 0D;
            this.iconButtonDelete.Size = new System.Drawing.Size(142, 36);
            this.iconButtonDelete.TabIndex = 16;
            this.iconButtonDelete.Text = "Delete";
            this.iconButtonDelete.UseVisualStyleBackColor = true;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // textBoxSubjectCode
            // 
            this.textBoxSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectCode.Location = new System.Drawing.Point(160, 53);
            this.textBoxSubjectCode.Name = "textBoxSubjectCode";
            this.textBoxSubjectCode.Size = new System.Drawing.Size(242, 28);
            this.textBoxSubjectCode.TabIndex = 15;
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
            this.iconButtonUpdate.Location = new System.Drawing.Point(671, 107);
            this.iconButtonUpdate.Name = "iconButtonUpdate";
            this.iconButtonUpdate.Rotation = 0D;
            this.iconButtonUpdate.Size = new System.Drawing.Size(142, 36);
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
            this.iconButtonSave.Location = new System.Drawing.Point(489, 107);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Rotation = 0D;
            this.iconButtonSave.Size = new System.Drawing.Size(142, 36);
            this.iconButtonSave.TabIndex = 13;
            this.iconButtonSave.Text = "Save";
            this.iconButtonSave.UseVisualStyleBackColor = true;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // labelSubjectCode
            // 
            this.labelSubjectCode.AutoSize = true;
            this.labelSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjectCode.Location = new System.Drawing.Point(27, 56);
            this.labelSubjectCode.Name = "labelSubjectCode";
            this.labelSubjectCode.Size = new System.Drawing.Size(124, 24);
            this.labelSubjectCode.TabIndex = 4;
            this.labelSubjectCode.Text = "Subject Code";
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
            this.subjectCodeDataGridViewTextBoxColumn,
            this.subjectNameDataGridViewTextBoxColumn,
            this.subjectTypeDataGridViewTextBoxColumn,
            this.entryByDataGridViewTextBoxColumn,
            this.entryDateDataGridViewTextBoxColumn,
            this.Edit});
            this.dataGridView.DataSource = this.subjectBindingSource1;
            this.dataGridView.Location = new System.Drawing.Point(34, 237);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1201, 650);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Serial
            // 
            this.Serial.HeaderText = "Serial";
            this.Serial.MinimumWidth = 6;
            this.Serial.Name = "Serial";
            this.Serial.Width = 125;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Id";
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 125;
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
            this.iconButtonReset.Location = new System.Drawing.Point(1030, 107);
            this.iconButtonReset.Name = "iconButtonReset";
            this.iconButtonReset.Rotation = 0D;
            this.iconButtonReset.Size = new System.Drawing.Size(142, 36);
            this.iconButtonReset.TabIndex = 23;
            this.iconButtonReset.Text = "Reset";
            this.iconButtonReset.UseVisualStyleBackColor = true;
            this.iconButtonReset.Click += new System.EventHandler(this.iconButtonReset_Click);
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
            // subjectCodeDataGridViewTextBoxColumn
            // 
            this.subjectCodeDataGridViewTextBoxColumn.DataPropertyName = "SubjectCode";
            this.subjectCodeDataGridViewTextBoxColumn.HeaderText = "SubjectCode";
            this.subjectCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectCodeDataGridViewTextBoxColumn.Name = "subjectCodeDataGridViewTextBoxColumn";
            this.subjectCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            this.subjectNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectTypeDataGridViewTextBoxColumn
            // 
            this.subjectTypeDataGridViewTextBoxColumn.DataPropertyName = "SubjectType";
            this.subjectTypeDataGridViewTextBoxColumn.HeaderText = "SubjectType";
            this.subjectTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectTypeDataGridViewTextBoxColumn.Name = "subjectTypeDataGridViewTextBoxColumn";
            this.subjectTypeDataGridViewTextBoxColumn.Width = 125;
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
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataSource = typeof(SchoolManagmentSystem.Model.Model.Administration.Subject);
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataSource = typeof(SchoolManagmentSystem.Model.Model.Administration.Section);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(SchoolManagmentSystem.Model.Model.Administration.Subject);
            // 
            // SubjectUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubjectUI";
            this.Size = new System.Drawing.Size(1267, 890);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private FontAwesome.Sharp.IconButton iconButtonUpdate;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private System.Windows.Forms.TextBox textBoxSubjectCode;
        private System.Windows.Forms.Label labelSubjectCode;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.Label labelSubjectName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSubjective;
        private System.Windows.Forms.RadioButton radioButtonObjective;
        private System.Windows.Forms.RadioButton radioButtonSelective;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private FontAwesome.Sharp.IconButton iconButtonReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.BindingSource subjectBindingSource1;
    }
}
