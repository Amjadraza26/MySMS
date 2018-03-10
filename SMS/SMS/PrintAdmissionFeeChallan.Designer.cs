namespace SMS
{
    partial class PrintAdmissionFeeChallan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintAdmissionFeeChallan));
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.lblFatherName = new Telerik.WinControls.UI.RadLabel();
            this.txtFatherName = new Telerik.WinControls.UI.RadTextBox();
            this.lblfee = new Telerik.WinControls.UI.RadLabel();
            this.txtFee = new Telerik.WinControls.UI.RadTextBox();
            this.txtContactNo = new Telerik.WinControls.UI.RadTextBox();
            this.lblContactNO = new Telerik.WinControls.UI.RadLabel();
            this.txtCnic = new Telerik.WinControls.UI.RadTextBox();
            this.lblAddress = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.lblStudentName = new Telerik.WinControls.UI.RadLabel();
            this.ppPrintPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.pdPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            this.txtRemarks = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtAddress = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lblFatherName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatherName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblfee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblContactNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCnic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStudentName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStudents
            // 
            this.cmbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(127, 36);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(321, 21);
            this.cmbStudents.TabIndex = 2;
            this.cmbStudents.SelectedIndexChanged += new System.EventHandler(this.cmbStudents_SelectedIndexChanged);
            // 
            // lblFatherName
            // 
            this.lblFatherName.Location = new System.Drawing.Point(48, 65);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(73, 18);
            this.lblFatherName.TabIndex = 3;
            this.lblFatherName.Text = "Father Name:";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(127, 63);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(321, 20);
            this.txtFatherName.TabIndex = 4;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtFatherName.GetChildAt(0).GetChildAt(0))).Enabled = false;
            // 
            // lblfee
            // 
            this.lblfee.Location = new System.Drawing.Point(40, 175);
            this.lblfee.Name = "lblfee";
            this.lblfee.Size = new System.Drawing.Size(81, 18);
            this.lblfee.TabIndex = 5;
            this.lblfee.Text = "Admission Fee:";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(127, 175);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(321, 20);
            this.txtFee.TabIndex = 6;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(126, 89);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(322, 20);
            this.txtContactNo.TabIndex = 10;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtContactNo.GetChildAt(0).GetChildAt(0))).Enabled = false;
            // 
            // lblContactNO
            // 
            this.lblContactNO.Location = new System.Drawing.Point(55, 91);
            this.lblContactNO.Name = "lblContactNO";
            this.lblContactNO.Size = new System.Drawing.Size(66, 18);
            this.lblContactNO.TabIndex = 9;
            this.lblContactNO.Text = "Contact No:";
            // 
            // txtCnic
            // 
            this.txtCnic.Location = new System.Drawing.Point(127, 118);
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(321, 20);
            this.txtCnic.TabIndex = 12;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtCnic.GetChildAt(0).GetChildAt(0))).Enabled = false;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(46, 120);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 18);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "CNIC/B-Form:";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(47, 157);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(2, 2);
            this.radLabel4.TabIndex = 13;
            // 
            // lblStudentName
            // 
            this.lblStudentName.Location = new System.Drawing.Point(40, 38);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(81, 18);
            this.lblStudentName.TabIndex = 15;
            this.lblStudentName.Text = "Student Name:";
            // 
            // ppPrintPreview
            // 
            this.ppPrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppPrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppPrintPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.ppPrintPreview.Enabled = true;
            this.ppPrintPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("ppPrintPreview.Icon")));
            this.ppPrintPreview.Name = "ppPrintPreview";
            this.ppPrintPreview.Visible = false;
            // 
            // pdPrintDocument
            // 
            this.pdPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdPrintDocument_PrintPage);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::SMS.Properties.Resources.print_icon;
            this.btnPrint.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.Location = new System.Drawing.Point(335, 287);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 66);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.AutoSize = false;
            this.txtRemarks.Location = new System.Drawing.Point(126, 203);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(321, 75);
            this.txtRemarks.TabIndex = 17;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(70, 203);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(51, 18);
            this.radLabel1.TabIndex = 16;
            this.radLabel1.Text = "Remarks:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(127, 148);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(321, 20);
            this.txtAddress.TabIndex = 19;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtAddress.GetChildAt(0).GetChildAt(0))).Enabled = false;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(72, 150);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(49, 18);
            this.radLabel2.TabIndex = 18;
            this.radLabel2.Text = "Address:";
            // 
            // PrintAdmissionFeeChallan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 365);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.lblContactNO);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.lblfee);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.cmbStudents);
            this.Name = "PrintAdmissionFeeChallan";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "PrintAdmissionFeeChallan";
            ((System.ComponentModel.ISupportInitialize)(this.lblFatherName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatherName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblfee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblContactNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCnic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStudentName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbStudents;
        private Telerik.WinControls.UI.RadLabel lblFatherName;
        private Telerik.WinControls.UI.RadTextBox txtFatherName;
        private Telerik.WinControls.UI.RadLabel lblfee;
        private Telerik.WinControls.UI.RadTextBox txtFee;
        private Telerik.WinControls.UI.RadButton btnPrint;
        private Telerik.WinControls.UI.RadTextBox txtContactNo;
        private Telerik.WinControls.UI.RadLabel lblContactNO;
        private Telerik.WinControls.UI.RadTextBox txtCnic;
        private Telerik.WinControls.UI.RadLabel lblAddress;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel lblStudentName;
        private System.Windows.Forms.PrintPreviewDialog ppPrintPreview;
        private System.Drawing.Printing.PrintDocument pdPrintDocument;
        private Telerik.WinControls.UI.RadTextBox txtRemarks;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtAddress;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
