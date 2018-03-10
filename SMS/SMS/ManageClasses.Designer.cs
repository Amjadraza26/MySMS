namespace SMS
{
    partial class ManageClasses
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
            this.lblClassName = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtClassName = new Telerik.WinControls.UI.RadTextBox();
            this.txtNumericValue = new Telerik.WinControls.UI.RadTextBox();
            this.txtRemarks = new Telerik.WinControls.UI.RadTextBox();
            this.chkIsEnabled = new Telerik.WinControls.UI.RadCheckBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.lblClassID = new Telerik.WinControls.UI.RadLabel();
            this.grdClasses = new Telerik.WinControls.UI.RadGridView();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblClassName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumericValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblClassID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClasses.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(147, 289);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(105, 24);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblClassName
            // 
            this.lblClassName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(58, 38);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(78, 21);
            this.lblClassName.TabIndex = 4;
            this.lblClassName.Text = "Class Name:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(40, 70);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(99, 21);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Numeric Value:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel3.Location = new System.Drawing.Point(64, 97);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(72, 21);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Is Enabled:";
            // 
            // radLabel4
            // 
            this.radLabel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel4.Location = new System.Drawing.Point(74, 118);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(62, 21);
            this.radLabel4.TabIndex = 5;
            this.radLabel4.Text = "Remarks:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(147, 38);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(337, 20);
            this.txtClassName.TabIndex = 7;
            // 
            // txtNumericValue
            // 
            this.txtNumericValue.Location = new System.Drawing.Point(147, 70);
            this.txtNumericValue.Name = "txtNumericValue";
            this.txtNumericValue.Size = new System.Drawing.Size(337, 20);
            this.txtNumericValue.TabIndex = 8;
            // 
            // txtRemarks
            // 
            this.txtRemarks.AutoSize = false;
            this.txtRemarks.Location = new System.Drawing.Point(147, 118);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(337, 145);
            this.txtRemarks.TabIndex = 10;
            // 
            // chkIsEnabled
            // 
            this.chkIsEnabled.Location = new System.Drawing.Point(147, 97);
            this.chkIsEnabled.Name = "chkIsEnabled";
            // 
            // 
            // 
            this.chkIsEnabled.RootElement.UseSystemSkin = Telerik.WinControls.UseSystemSkinMode.YesLocal;
            this.chkIsEnabled.Size = new System.Drawing.Size(15, 15);
            this.chkIsEnabled.TabIndex = 11;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.chkIsEnabled.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 10F);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.chkIsEnabled.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(258, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblClassID
            // 
            this.lblClassID.Location = new System.Drawing.Point(157, 222);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(2, 2);
            this.lblClassID.TabIndex = 13;
            this.lblClassID.Visible = false;
            // 
            // grdClasses
            // 
            this.grdClasses.Location = new System.Drawing.Point(515, 38);
            // 
            // 
            // 
            this.grdClasses.MasterTemplate.AllowAddNewRow = false;
            this.grdClasses.MasterTemplate.AllowColumnReorder = false;
            this.grdClasses.MasterTemplate.AutoExpandGroups = true;
            this.grdClasses.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.FieldName = "ClassID";
            gridViewTextBoxColumn1.HeaderText = "Class ID";
            gridViewTextBoxColumn1.Name = "colClassID";
            gridViewTextBoxColumn2.FieldName = "ClassName";
            gridViewTextBoxColumn2.HeaderText = "Class Name";
            gridViewTextBoxColumn2.Name = "colClassName";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.FieldName = "NumericName";
            gridViewTextBoxColumn3.HeaderText = "Numeric Name";
            gridViewTextBoxColumn3.Name = "colNumericName";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "UserName";
            gridViewTextBoxColumn4.HeaderText = "Created By";
            gridViewTextBoxColumn4.Name = "colCreatedBy";
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.FieldName = "DateCreated";
            gridViewTextBoxColumn5.HeaderText = "Date Created";
            gridViewTextBoxColumn5.Name = "colDateCreated";
            gridViewTextBoxColumn5.Width = 150;
            this.grdClasses.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.grdClasses.MasterTemplate.EnableGrouping = false;
            this.grdClasses.MasterTemplate.ShowRowHeaderColumn = false;
            this.grdClasses.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdClasses.Name = "grdClasses";
            this.grdClasses.ReadOnly = true;
            // 
            // 
            // 
            this.grdClasses.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            this.grdClasses.RootElement.CanFocus = true;
            this.grdClasses.RootElement.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentPadding;
            this.grdClasses.Size = new System.Drawing.Size(503, 275);
            this.grdClasses.TabIndex = 3;
            this.grdClasses.Text = "Classes";
            this.grdClasses.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grdClasses_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(374, 289);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 24);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // ManageClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 365);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkIsEnabled);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtNumericValue);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.grdClasses);
            this.Controls.Add(this.btnAddNew);
            this.Name = "ManageClasses";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Manage Class";
           //this.Load += new System.EventHandler(this.ManageClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblClassName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumericValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblClassID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClasses.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btnAddNew;
        private Telerik.WinControls.UI.RadLabel lblClassName;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtClassName;
        private Telerik.WinControls.UI.RadTextBox txtNumericValue;
        private Telerik.WinControls.UI.RadTextBox txtRemarks;
        private Telerik.WinControls.UI.RadCheckBox chkIsEnabled;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadLabel lblClassID;
        private Telerik.WinControls.UI.RadGridView grdClasses;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadButton btnDelete;
    }
}
