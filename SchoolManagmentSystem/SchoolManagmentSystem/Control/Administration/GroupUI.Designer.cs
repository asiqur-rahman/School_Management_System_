namespace SchoolManagmentSystem
{
    partial class GroupUI
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
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.iconButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconButtonReset);
            this.groupBox1.Controls.Add(this.iconButtonDelete);
            this.groupBox1.Controls.Add(this.textBoxGroupName);
            this.groupBox1.Controls.Add(this.iconButtonUpdate);
            this.groupBox1.Controls.Add(this.iconButtonSave);
            this.groupBox1.Controls.Add(this.labelGroupName);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(34, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1201, 128);
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
            this.iconButtonReset.Location = new System.Drawing.Point(871, 77);
            this.iconButtonReset.Name = "iconButtonReset";
            this.iconButtonReset.Rotation = 0D;
            this.iconButtonReset.Size = new System.Drawing.Size(181, 36);
            this.iconButtonReset.TabIndex = 17;
            this.iconButtonReset.Text = "Reset";
            this.iconButtonReset.UseVisualStyleBackColor = true;
            this.iconButtonReset.Click += new System.EventHandler(this.iconButtonReset_Click);
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
            this.iconButtonDelete.Location = new System.Drawing.Point(871, 21);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Rotation = 0D;
            this.iconButtonDelete.Size = new System.Drawing.Size(181, 36);
            this.iconButtonDelete.TabIndex = 16;
            this.iconButtonDelete.Text = "Delete";
            this.iconButtonDelete.UseVisualStyleBackColor = true;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupName.Location = new System.Drawing.Point(160, 53);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(242, 28);
            this.textBoxGroupName.TabIndex = 15;
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
            this.iconButtonUpdate.Location = new System.Drawing.Point(560, 77);
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
            this.iconButtonSave.Location = new System.Drawing.Point(560, 21);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Rotation = 0D;
            this.iconButtonSave.Size = new System.Drawing.Size(181, 36);
            this.iconButtonSave.TabIndex = 13;
            this.iconButtonSave.Text = "Save";
            this.iconButtonSave.UseVisualStyleBackColor = true;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // labelGroupName
            // 
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupName.Location = new System.Drawing.Point(27, 56);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(119, 24);
            this.labelGroupName.TabIndex = 4;
            this.labelGroupName.Text = "Group Name";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial,
            this.Id,
            this.groupNameDataGridViewTextBoxColumn,
            this.entryByDataGridViewTextBoxColumn,
            this.entryDateDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView.DataSource = this.groupBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(34, 163);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1201, 724);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(SchoolManagmentSystem.Model.Model.Administration.Group);
            // 
            // serial
            // 
            this.serial.HeaderText = "Serial";
            this.serial.MinimumWidth = 6;
            this.serial.Name = "serial";
            this.serial.Width = 125;
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
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            this.groupNameDataGridViewTextBoxColumn.Width = 125;
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
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Edit";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 125;
            // 
            // GroupUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "GroupUI";
            this.Size = new System.Drawing.Size(1267, 890);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private FontAwesome.Sharp.IconButton iconButtonUpdate;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Label labelGroupName;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private FontAwesome.Sharp.IconButton iconButtonReset;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}
