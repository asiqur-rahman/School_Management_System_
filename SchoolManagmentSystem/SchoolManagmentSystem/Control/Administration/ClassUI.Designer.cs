namespace SchoolManagmentSystem
{
    partial class ClassUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxShortName = new System.Windows.Forms.TextBox();
            this.labelShortName = new System.Windows.Forms.Label();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.iconButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.labelClassName = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.className = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iconButtonReset = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconButtonReset);
            this.groupBox1.Controls.Add(this.textBoxShortName);
            this.groupBox1.Controls.Add(this.labelShortName);
            this.groupBox1.Controls.Add(this.iconButtonDelete);
            this.groupBox1.Controls.Add(this.textBoxClassName);
            this.groupBox1.Controls.Add(this.iconButtonUpdate);
            this.groupBox1.Controls.Add(this.iconButtonSave);
            this.groupBox1.Controls.Add(this.labelClassName);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(34, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1201, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBoxShortName
            // 
            this.textBoxShortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShortName.Location = new System.Drawing.Point(160, 111);
            this.textBoxShortName.Name = "textBoxShortName";
            this.textBoxShortName.Size = new System.Drawing.Size(242, 28);
            this.textBoxShortName.TabIndex = 18;
            // 
            // labelShortName
            // 
            this.labelShortName.AutoSize = true;
            this.labelShortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShortName.Location = new System.Drawing.Point(27, 114);
            this.labelShortName.Name = "labelShortName";
            this.labelShortName.Size = new System.Drawing.Size(110, 24);
            this.labelShortName.TabIndex = 17;
            this.labelShortName.Text = "Short Name";
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
            this.iconButtonDelete.Location = new System.Drawing.Point(912, 44);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Rotation = 0D;
            this.iconButtonDelete.Size = new System.Drawing.Size(181, 36);
            this.iconButtonDelete.TabIndex = 16;
            this.iconButtonDelete.Text = "Delete";
            this.iconButtonDelete.UseVisualStyleBackColor = true;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClassName.Location = new System.Drawing.Point(160, 53);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(242, 28);
            this.textBoxClassName.TabIndex = 15;
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
            this.iconButtonUpdate.Location = new System.Drawing.Point(571, 108);
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
            this.iconButtonSave.Location = new System.Drawing.Point(571, 44);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Rotation = 0D;
            this.iconButtonSave.Size = new System.Drawing.Size(181, 36);
            this.iconButtonSave.TabIndex = 13;
            this.iconButtonSave.Text = "Save";
            this.iconButtonSave.UseVisualStyleBackColor = true;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassName.Location = new System.Drawing.Point(27, 56);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(111, 24);
            this.labelClassName.TabIndex = 4;
            this.labelClassName.Text = "Class Name";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.Id,
            this.className,
            this.classShortName,
            this.entryBy,
            this.entryDate,
            this.Edit,
            this.Delete});
            this.dataGridView.DataSource = this.classBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(34, 224);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1201, 663);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(SchoolManagmentSystem.Model.Model.Administration.Class);
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Serial";
            this.Sl.MinimumWidth = 6;
            this.Sl.Name = "Sl";
            this.Sl.Width = 125;
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
            // className
            // 
            this.className.DataPropertyName = "ClassName";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            this.className.DefaultCellStyle = dataGridViewCellStyle3;
            this.className.HeaderText = "ClassName";
            this.className.MinimumWidth = 6;
            this.className.Name = "className";
            this.className.Width = 125;
            // 
            // classShortName
            // 
            this.classShortName.DataPropertyName = "ClassShortName";
            this.classShortName.HeaderText = "ClassShortName";
            this.classShortName.MinimumWidth = 6;
            this.classShortName.Name = "classShortName";
            this.classShortName.Width = 125;
            // 
            // entryBy
            // 
            this.entryBy.DataPropertyName = "EntryBy";
            this.entryBy.HeaderText = "EntryBy";
            this.entryBy.MinimumWidth = 6;
            this.entryBy.Name = "entryBy";
            this.entryBy.Width = 125;
            // 
            // entryDate
            // 
            this.entryDate.DataPropertyName = "EntryDate";
            this.entryDate.HeaderText = "EntryDate";
            this.entryDate.MinimumWidth = 6;
            this.entryDate.Name = "entryDate";
            this.entryDate.Width = 125;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Id";
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 18;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Visible = false;
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Id";
            this.Delete.HeaderText = "Edit";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Edit";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
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
            this.iconButtonReset.Location = new System.Drawing.Point(912, 106);
            this.iconButtonReset.Name = "iconButtonReset";
            this.iconButtonReset.Rotation = 0D;
            this.iconButtonReset.Size = new System.Drawing.Size(181, 36);
            this.iconButtonReset.TabIndex = 19;
            this.iconButtonReset.Text = "Reset";
            this.iconButtonReset.UseVisualStyleBackColor = true;
            this.iconButtonReset.Click += new System.EventHandler(this.iconButtonReset_Click);
            // 
            // ClassUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClassUI";
            this.Size = new System.Drawing.Size(1267, 890);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButtonUpdate;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private System.Windows.Forms.TextBox textBoxClassName;
        private System.Windows.Forms.Label labelClassName;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private System.Windows.Forms.TextBox textBoxShortName;
        private System.Windows.Forms.Label labelShortName;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn className;
        private System.Windows.Forms.DataGridViewTextBoxColumn classShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDate;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private FontAwesome.Sharp.IconButton iconButtonReset;
    }
}
