namespace SMS
{
    partial class ManageClassTeachers
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnAddNew = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.grdClassTeacher = new Telerik.WinControls.UI.RadGridView();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.chkIsEnabled = new Telerik.WinControls.UI.RadCheckBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtRemarks = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.lblClassTeacherID = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClassTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClassTeacher.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblClassTeacherID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(131, 272);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(73, 24);
            this.btnAddNew.TabIndex = 90;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(307, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 24);
            this.btnDelete.TabIndex = 89;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grdClassTeacher
            // 
            this.grdClassTeacher.AllowDrop = true;
            this.grdClassTeacher.AutoGenerateHierarchy = true;
            this.grdClassTeacher.Location = new System.Drawing.Point(417, 41);
            // 
            // 
            // 
            this.grdClassTeacher.MasterTemplate.AllowAddNewRow = false;
            this.grdClassTeacher.MasterTemplate.AllowColumnReorder = false;
            this.grdClassTeacher.MasterTemplate.AllowDragToGroup = false;
            this.grdClassTeacher.MasterTemplate.AllowRowReorder = true;
            this.grdClassTeacher.MasterTemplate.AutoExpandGroups = true;
            this.grdClassTeacher.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.FieldName = "ClassTeacherID";
            gridViewTextBoxColumn1.HeaderText = "ClassTeacherID";
            gridViewTextBoxColumn1.Name = "colCLassTeacherID";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "TeacherName";
            gridViewTextBoxColumn2.HeaderText = "Teacher Name";
            gridViewTextBoxColumn2.Name = "colTeacherName";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.FieldName = "ClassName";
            gridViewTextBoxColumn3.HeaderText = "Class";
            gridViewTextBoxColumn3.Name = "colClassName";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "SectionName";
            gridViewTextBoxColumn4.HeaderText = "Section Name";
            gridViewTextBoxColumn4.Name = "colSection";
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.FieldName = "SubjectName";
            gridViewTextBoxColumn5.HeaderText = "Subject Name";
            gridViewTextBoxColumn5.Name = "colSubjectName";
            gridViewTextBoxColumn5.Width = 100;
            this.grdClassTeacher.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.grdClassTeacher.MasterTemplate.EnableGrouping = false;
            this.grdClassTeacher.MasterTemplate.ShowRowHeaderColumn = false;
            this.grdClassTeacher.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdClassTeacher.Name = "grdClassTeacher";
            this.grdClassTeacher.ReadOnly = true;
            this.grdClassTeacher.Size = new System.Drawing.Size(500, 255);
            this.grdClassTeacher.TabIndex = 88;
            this.grdClassTeacher.Text = "ClassTeacher";
            this.grdClassTeacher.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grdClassTeacher_CellDoubleClick);
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(131, 41);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(257, 21);
            this.cmbTeacher.TabIndex = 87;
            // 
            // cmbSection
            // 
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(131, 97);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(257, 21);
            this.cmbSection.TabIndex = 86;
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(131, 70);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(257, 21);
            this.cmbClass.TabIndex = 85;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // chkIsEnabled
            // 
            this.chkIsEnabled.Location = new System.Drawing.Point(131, 168);
            this.chkIsEnabled.Name = "chkIsEnabled";
            this.chkIsEnabled.Size = new System.Drawing.Size(23, 18);
            this.chkIsEnabled.TabIndex = 84;
            this.chkIsEnabled.Text = " ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(210, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 24);
            this.btnSave.TabIndex = 83;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.AutoSize = false;
            this.txtRemarks.Location = new System.Drawing.Point(131, 192);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(257, 74);
            this.txtRemarks.TabIndex = 82;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtRemarks.GetChildAt(0).GetChildAt(0))).StretchVertically = true;
            // 
            // radLabel9
            // 
            this.radLabel9.Location = new System.Drawing.Point(74, 190);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(51, 18);
            this.radLabel9.TabIndex = 81;
            this.radLabel9.Text = "Remarks:";
            // 
            // radLabel8
            // 
            this.radLabel8.Location = new System.Drawing.Point(66, 165);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(59, 18);
            this.radLabel8.TabIndex = 80;
            this.radLabel8.Text = "Is Enabled:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(44, 41);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(81, 18);
            this.radLabel3.TabIndex = 79;
            this.radLabel3.Text = "Select Teacher:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(47, 96);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(78, 18);
            this.radLabel2.TabIndex = 78;
            this.radLabel2.Text = "Select Section:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(58, 72);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(67, 18);
            this.radLabel1.TabIndex = 77;
            this.radLabel1.Text = "Select Class:";
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(131, 124);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(257, 21);
            this.cmbSubjects.TabIndex = 92;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(47, 126);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(78, 18);
            this.radLabel4.TabIndex = 91;
            this.radLabel4.Text = "Select Subject:";
            // 
            // lblClassTeacherID
            // 
            this.lblClassTeacherID.Location = new System.Drawing.Point(246, 165);
            this.lblClassTeacherID.Name = "lblClassTeacherID";
            this.lblClassTeacherID.Size = new System.Drawing.Size(2, 2);
            this.lblClassTeacherID.TabIndex = 93;
            this.lblClassTeacherID.Visible = false;
            // 
            // ManageClassTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 365);
            this.Controls.Add(this.lblClassTeacherID);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdClassTeacher);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.chkIsEnabled);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.radLabel9);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "ManageClassTeachers";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ManageClassTeachers";
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClassTeacher.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClassTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblClassTeacherID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnAddNew;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadGridView grdClassTeacher;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.ComboBox cmbClass;
        private Telerik.WinControls.UI.RadCheckBox chkIsEnabled;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadTextBox txtRemarks;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel lblClassTeacherID;
    }
}
