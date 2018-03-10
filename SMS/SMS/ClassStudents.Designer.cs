namespace SMS
{
    partial class ClassStudents
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnViewClass = new Telerik.WinControls.UI.RadButton();
            this.grdClassStudents = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClassStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClassStudents.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSection
            // 
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(462, 48);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(228, 21);
            this.cmbSection.TabIndex = 76;
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(120, 48);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(220, 21);
            this.cmbClass.TabIndex = 75;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(378, 50);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(78, 18);
            this.radLabel2.TabIndex = 74;
            this.radLabel2.Text = "Select Section:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(47, 50);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(67, 18);
            this.radLabel1.TabIndex = 73;
            this.radLabel1.Text = "Select Class:";
            // 
            // btnViewClass
            // 
            this.btnViewClass.Location = new System.Drawing.Point(749, 45);
            this.btnViewClass.Name = "btnViewClass";
            this.btnViewClass.Size = new System.Drawing.Size(110, 24);
            this.btnViewClass.TabIndex = 77;
            this.btnViewClass.Text = "View Class";
            this.btnViewClass.Click += new System.EventHandler(this.btnViewClass_Click);
            // 
            // grdClassStudents
            // 
            this.grdClassStudents.Location = new System.Drawing.Point(47, 85);
            // 
            // 
            // 
            this.grdClassStudents.MasterTemplate.AllowAddNewRow = false;
            this.grdClassStudents.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.FieldName = "ClassStudentID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "colClassStudentID";
            gridViewTextBoxColumn2.FieldName = "RollNo";
            gridViewTextBoxColumn2.HeaderText = "Roll No.";
            gridViewTextBoxColumn2.Name = "colRollNo";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.FieldName = "StudentName";
            gridViewTextBoxColumn3.HeaderText = "Student Name";
            gridViewTextBoxColumn3.Name = "colStudentName";
            gridViewTextBoxColumn3.Width = 180;
            gridViewTextBoxColumn4.FieldName = "FatherName";
            gridViewTextBoxColumn4.HeaderText = "Father Name";
            gridViewTextBoxColumn4.Name = "colFatherName";
            gridViewTextBoxColumn4.Width = 180;
            gridViewTextBoxColumn5.FieldName = "ClassName";
            gridViewTextBoxColumn5.HeaderText = "Class Name";
            gridViewTextBoxColumn5.Name = "colClassName";
            gridViewTextBoxColumn5.Width = 150;
            gridViewTextBoxColumn6.FieldName = "SectionName";
            gridViewTextBoxColumn6.HeaderText = "Section Name";
            gridViewTextBoxColumn6.Name = "colSectionName";
            gridViewTextBoxColumn6.Width = 150;
            this.grdClassStudents.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.grdClassStudents.MasterTemplate.ShowRowHeaderColumn = false;
            this.grdClassStudents.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdClassStudents.Name = "grdClassStudents";
            this.grdClassStudents.ReadOnly = true;
            this.grdClassStudents.ShowGroupPanel = false;
            this.grdClassStudents.Size = new System.Drawing.Size(812, 365);
            this.grdClassStudents.TabIndex = 78;
            this.grdClassStudents.Text = "Class Students";
            // 
            // ClassStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 488);
            this.Controls.Add(this.grdClassStudents);
            this.Controls.Add(this.btnViewClass);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "ClassStudents";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ClassStudents";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClassStudents.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClassStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.ComboBox cmbClass;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnViewClass;
        private Telerik.WinControls.UI.RadGridView grdClassStudents;
    }
}
