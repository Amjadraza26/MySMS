namespace SMS
{
    partial class ManageSubjects
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.grdSubjects = new Telerik.WinControls.UI.RadGridView();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnAddNew = new Telerik.WinControls.UI.RadButton();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.chkISEnabled = new Telerik.WinControls.UI.RadCheckBox();
            this.txtRemarks = new Telerik.WinControls.UI.RadTextBox();
            this.txtSubjectName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubjects.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkISEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubjectName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Location = new System.Drawing.Point(156, 325);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(0, 13);
            this.lblSubjectID.TabIndex = 24;
            this.lblSubjectID.Visible = false;
            // 
            // grdSubjects
            // 
            this.grdSubjects.Location = new System.Drawing.Point(522, 42);
            // 
            // 
            // 
            this.grdSubjects.MasterTemplate.AllowAddNewRow = false;
            this.grdSubjects.MasterTemplate.AllowColumnReorder = false;
            this.grdSubjects.MasterTemplate.AllowDeleteRow = false;
            this.grdSubjects.MasterTemplate.AllowEditRow = false;
            this.grdSubjects.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.FieldName = "SubjectID";
            gridViewTextBoxColumn1.HeaderText = "Subject ID";
            gridViewTextBoxColumn1.Name = "colSubjectID";
            gridViewTextBoxColumn1.Width = 75;
            gridViewTextBoxColumn2.FieldName = "ClassName";
            gridViewTextBoxColumn2.HeaderText = "Class Name";
            gridViewTextBoxColumn2.Name = "colClassName";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.FieldName = "SubjectName";
            gridViewTextBoxColumn3.HeaderText = "Subject Name";
            gridViewTextBoxColumn3.Name = "colSubjectName";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "Remarks";
            gridViewTextBoxColumn4.HeaderText = "Remarks";
            gridViewTextBoxColumn4.Name = "colRemarks";
            gridViewTextBoxColumn4.Width = 100;
            this.grdSubjects.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.grdSubjects.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdSubjects.Name = "grdSubjects";
            this.grdSubjects.ReadOnly = true;
            this.grdSubjects.ShowGroupPanel = false;
            this.grdSubjects.Size = new System.Drawing.Size(392, 276);
            this.grdSubjects.TabIndex = 23;
            this.grdSubjects.Text = "Subjects";
            this.grdSubjects.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grdSubjects_CellDoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(267, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(383, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 24);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(156, 294);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(105, 24);
            this.btnAddNew.TabIndex = 20;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(156, 70);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(337, 21);
            this.cmbClass.TabIndex = 19;
            // 
            // chkISEnabled
            // 
            this.chkISEnabled.Location = new System.Drawing.Point(156, 100);
            this.chkISEnabled.Name = "chkISEnabled";
            this.chkISEnabled.Size = new System.Drawing.Size(15, 15);
            this.chkISEnabled.TabIndex = 18;
            // 
            // txtRemarks
            // 
            this.txtRemarks.AutoSize = false;
            this.txtRemarks.Location = new System.Drawing.Point(156, 123);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(337, 145);
            this.txtRemarks.TabIndex = 17;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(156, 42);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(337, 20);
            this.txtSubjectName.TabIndex = 16;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel4.Location = new System.Drawing.Point(82, 121);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(62, 21);
            this.radLabel4.TabIndex = 15;
            this.radLabel4.Text = "Remarks:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel3.Location = new System.Drawing.Point(74, 97);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(72, 21);
            this.radLabel3.TabIndex = 14;
            this.radLabel3.Text = "Is Enabled:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(66, 69);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(80, 21);
            this.radLabel2.TabIndex = 13;
            this.radLabel2.Text = "Class Name:";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(55, 41);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(95, 21);
            this.radLabel1.TabIndex = 12;
            this.radLabel1.Text = "Subject Name:";
            // 
            // ManageSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 378);
            this.Controls.Add(this.lblSubjectID);
            this.Controls.Add(this.grdSubjects);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.chkISEnabled);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "ManageSubjects";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ManageSubjects";
            ((System.ComponentModel.ISupportInitialize)(this.grdSubjects.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkISEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubjectName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubjectID;
        private Telerik.WinControls.UI.RadGridView grdSubjects;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnAddNew;
        private System.Windows.Forms.ComboBox cmbClass;
        private Telerik.WinControls.UI.RadCheckBox chkISEnabled;
        private Telerik.WinControls.UI.RadTextBox txtRemarks;
        private Telerik.WinControls.UI.RadTextBox txtSubjectName;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
