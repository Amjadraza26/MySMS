namespace SMS
{
    partial class DuesStructure
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.lblSectionID = new System.Windows.Forms.Label();
            this.grdDues = new Telerik.WinControls.UI.RadGridView();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnAddNew = new Telerik.WinControls.UI.RadButton();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.chkISEnabled = new Telerik.WinControls.UI.RadCheckBox();
            this.txtRemarks = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtAmount = new Telerik.WinControls.UI.RadTextBox();
            this.lblDueAmountID = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdDues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDues.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkISEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDueAmountID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSectionID
            // 
            this.lblSectionID.AutoSize = true;
            this.lblSectionID.Location = new System.Drawing.Point(123, 320);
            this.lblSectionID.Name = "lblSectionID";
            this.lblSectionID.Size = new System.Drawing.Size(0, 13);
            this.lblSectionID.TabIndex = 22;
            this.lblSectionID.Visible = false;
            // 
            // grdDues
            // 
            this.grdDues.Location = new System.Drawing.Point(489, 37);
            // 
            // 
            // 
            this.grdDues.MasterTemplate.AllowAddNewRow = false;
            this.grdDues.MasterTemplate.AllowColumnReorder = false;
            this.grdDues.MasterTemplate.AllowDeleteRow = false;
            this.grdDues.MasterTemplate.AllowEditRow = false;
            this.grdDues.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn9.FieldName = "DueAmountID";
            gridViewTextBoxColumn9.HeaderText = "DueAmountID";
            gridViewTextBoxColumn9.Name = "colDueAmountID";
            gridViewTextBoxColumn9.Width = 100;
            gridViewTextBoxColumn10.FieldName = "ClassName";
            gridViewTextBoxColumn10.HeaderText = "Class Name";
            gridViewTextBoxColumn10.Name = "colClassName";
            gridViewTextBoxColumn10.Width = 100;
            gridViewTextBoxColumn11.FieldName = "TotalFee";
            gridViewTextBoxColumn11.HeaderText = "Total Fee";
            gridViewTextBoxColumn11.Name = "colTotalFee";
            gridViewTextBoxColumn11.Width = 100;
            gridViewTextBoxColumn12.FieldName = "Remarks";
            gridViewTextBoxColumn12.HeaderText = "Remarks";
            gridViewTextBoxColumn12.Name = "colRemarks";
            gridViewTextBoxColumn12.Width = 100;
            this.grdDues.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.grdDues.MasterTemplate.ShowRowHeaderColumn = false;
            this.grdDues.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.grdDues.Name = "grdDues";
            this.grdDues.ReadOnly = true;
            this.grdDues.ShowGroupPanel = false;
            this.grdDues.Size = new System.Drawing.Size(398, 276);
            this.grdDues.TabIndex = 21;
            this.grdDues.Text = "Fee";
            this.grdDues.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grdDues_CellDoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(234, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(350, 289);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 24);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(123, 289);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(105, 24);
            this.btnAddNew.TabIndex = 18;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(123, 38);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(337, 21);
            this.cmbClass.TabIndex = 17;
            // 
            // chkISEnabled
            // 
            this.chkISEnabled.Location = new System.Drawing.Point(123, 95);
            this.chkISEnabled.Name = "chkISEnabled";
            this.chkISEnabled.Size = new System.Drawing.Size(15, 15);
            this.chkISEnabled.TabIndex = 16;
            // 
            // txtRemarks
            // 
            this.txtRemarks.AutoSize = false;
            this.txtRemarks.Location = new System.Drawing.Point(123, 118);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(337, 145);
            this.txtRemarks.TabIndex = 15;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel4.Location = new System.Drawing.Point(49, 116);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(62, 21);
            this.radLabel4.TabIndex = 14;
            this.radLabel4.Text = "Remarks:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel3.Location = new System.Drawing.Point(39, 92);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(72, 21);
            this.radLabel3.TabIndex = 13;
            this.radLabel3.Text = "Is Enabled:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(31, 37);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(80, 21);
            this.radLabel2.TabIndex = 12;
            this.radLabel2.Text = "Class Name:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(57, 68);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(54, 18);
            this.radLabel1.TabIndex = 23;
            this.radLabel1.Text = "Total Fee:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(123, 65);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(337, 20);
            this.txtAmount.TabIndex = 24;
            // 
            // lblDueAmountID
            // 
            this.lblDueAmountID.Location = new System.Drawing.Point(145, 95);
            this.lblDueAmountID.Name = "lblDueAmountID";
            this.lblDueAmountID.Size = new System.Drawing.Size(2, 2);
            this.lblDueAmountID.TabIndex = 25;
            this.lblDueAmountID.Visible = false;
            // 
            // DuesStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 368);
            this.Controls.Add(this.lblDueAmountID);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.lblSectionID);
            this.Controls.Add(this.grdDues);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.chkISEnabled);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Name = "DuesStructure";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "DuesStructure";
            ((System.ComponentModel.ISupportInitialize)(this.grdDues.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkISEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDueAmountID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSectionID;
        private Telerik.WinControls.UI.RadGridView grdDues;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnAddNew;
        private System.Windows.Forms.ComboBox cmbClass;
        private Telerik.WinControls.UI.RadCheckBox chkISEnabled;
        private Telerik.WinControls.UI.RadTextBox txtRemarks;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtAmount;
        private Telerik.WinControls.UI.RadLabel lblDueAmountID;
    }
}
