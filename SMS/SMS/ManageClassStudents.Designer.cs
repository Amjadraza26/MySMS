namespace SMS
{
    partial class ManageClassStudents
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
            this.chkIsEnabled = new Telerik.WinControls.UI.RadCheckBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtRemarks = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.grdClassStudents = new Telerik.WinControls.UI.RadGridView();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnAddNew = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClassStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClassStudents.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // chkIsEnabled
            // 
            this.chkIsEnabled.Location = new System.Drawing.Point(128, 110);
            this.chkIsEnabled.Name = "chkIsEnabled";
            this.chkIsEnabled.Size = new System.Drawing.Size(23, 18);
            this.chkIsEnabled.TabIndex = 70;
            this.chkIsEnabled.Text = " ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(207, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 24);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.AutoSize = false;
            this.txtRemarks.Location = new System.Drawing.Point(128, 134);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(257, 74);
            this.txtRemarks.TabIndex = 62;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtRemarks.GetChildAt(0).GetChildAt(0))).StretchVertically = true;
            // 
            // radLabel9
            // 
            this.radLabel9.Location = new System.Drawing.Point(71, 132);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(51, 18);
            this.radLabel9.TabIndex = 55;
            this.radLabel9.Text = "Remarks:";
            // 
            // radLabel8
            // 
            this.radLabel8.Location = new System.Drawing.Point(63, 107);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(59, 18);
            this.radLabel8.TabIndex = 54;
            this.radLabel8.Text = "Is Enabled:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(41, 31);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(81, 18);
            this.radLabel3.TabIndex = 49;
            this.radLabel3.Text = "Select Student:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(44, 86);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(78, 18);
            this.radLabel2.TabIndex = 48;
            this.radLabel2.Text = "Select Section:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(55, 62);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(67, 18);
            this.radLabel1.TabIndex = 47;
            this.radLabel1.Text = "Select Class:";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(128, 60);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(257, 21);
            this.cmbClass.TabIndex = 71;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // cmbSection
            // 
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(128, 87);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(257, 21);
            this.cmbSection.TabIndex = 72;
            // 
            // cmbStudents
            // 
            this.cmbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(128, 31);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(257, 21);
            this.cmbStudents.TabIndex = 73;
            // 
            // grdClassStudents
            // 
            this.grdClassStudents.AllowDrop = true;
            this.grdClassStudents.AutoGenerateHierarchy = true;
            this.grdClassStudents.Location = new System.Drawing.Point(414, 31);
            // 
            // 
            // 
            this.grdClassStudents.MasterTemplate.AllowAddNewRow = false;
            this.grdClassStudents.MasterTemplate.AllowColumnReorder = false;
            this.grdClassStudents.MasterTemplate.AllowDragToGroup = false;
            this.grdClassStudents.MasterTemplate.AllowRowReorder = true;
            this.grdClassStudents.MasterTemplate.AutoExpandGroups = true;
            this.grdClassStudents.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.FieldName = "ClassStudentID";
            gridViewTextBoxColumn1.HeaderText = "ClassStudentID";
            gridViewTextBoxColumn1.Name = "colCLassStudentID";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "StudentName";
            gridViewTextBoxColumn2.HeaderText = "Student Name";
            gridViewTextBoxColumn2.Name = "colStudentName";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.FieldName = "ClassName";
            gridViewTextBoxColumn3.HeaderText = "Class";
            gridViewTextBoxColumn3.Name = "colClassName";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "SectionName";
            gridViewTextBoxColumn4.HeaderText = "Section Name";
            gridViewTextBoxColumn4.Name = "colSection";
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.FieldName = "RollNo";
            gridViewTextBoxColumn5.HeaderText = "Roll No";
            gridViewTextBoxColumn5.Name = "coRollNO";
            this.grdClassStudents.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.grdClassStudents.MasterTemplate.EnableGrouping = false;
            this.grdClassStudents.MasterTemplate.ShowRowHeaderColumn = false;
            this.grdClassStudents.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdClassStudents.Name = "grdClassStudents";
            this.grdClassStudents.ReadOnly = true;
            this.grdClassStudents.Size = new System.Drawing.Size(450, 207);
            this.grdClassStudents.TabIndex = 74;
            this.grdClassStudents.Text = "grdClassStudents";
            this.grdClassStudents.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grdClassStudents_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(304, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 24);
            this.btnDelete.TabIndex = 75;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(128, 214);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(73, 24);
            this.btnAddNew.TabIndex = 76;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // ManageClassStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 287);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdClassStudents);
            this.Controls.Add(this.cmbStudents);
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
            this.Name = "ManageClassStudents";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ManageClassStudents";
            ((System.ComponentModel.ISupportInitialize)(this.chkIsEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClassStudents.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClassStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadCheckBox chkIsEnabled;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadTextBox txtRemarks;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.ComboBox cmbStudents;
        private Telerik.WinControls.UI.RadGridView grdClassStudents;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnAddNew;
    }
}
