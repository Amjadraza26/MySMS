namespace SMS
{
    partial class DashBoard
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
            this.btnExit = new Telerik.WinControls.UI.RadMenuItem();
            this.btnDashBoard = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.btnClasses = new Telerik.WinControls.UI.RadMenuItem();
            this.btnSections = new Telerik.WinControls.UI.RadMenuItem();
            this.btnSubjects = new Telerik.WinControls.UI.RadMenuItem();
            this.btnStudents = new Telerik.WinControls.UI.RadMenuItem();
            this.btnManageStudents = new Telerik.WinControls.UI.RadMenuItem();
            this.btnManageClassStudents = new Telerik.WinControls.UI.RadMenuItem();
            this.btnClassStudents = new Telerik.WinControls.UI.RadMenuItem();
            this.btnAdmissionFee = new Telerik.WinControls.UI.RadMenuItem();
            this.btnPrintVoucher = new Telerik.WinControls.UI.RadMenuItem();
            this.BtnSubmitVoucher = new Telerik.WinControls.UI.RadMenuItem();
            this.btnTeacher = new Telerik.WinControls.UI.RadMenuItem();
            this.btnManageTeachers = new Telerik.WinControls.UI.RadMenuItem();
            this.btnManageClassTeacher = new Telerik.WinControls.UI.RadMenuItem();
            this.btnExams = new Telerik.WinControls.UI.RadMenuItem();
            this.btnAccounting = new Telerik.WinControls.UI.RadMenuItem();
            this.btnDuesStructure = new Telerik.WinControls.UI.RadMenuItem();
            this.btnDues = new Telerik.WinControls.UI.RadMenuItem();
            this.mainmenu = new Telerik.WinControls.UI.RadMenu();
            ((System.ComponentModel.ISupportInitialize)(this.mainmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AccessibleDescription = "Exit";
            this.btnExit.AccessibleName = "Exit";
            this.btnExit.Name = "btnExit";
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.AccessibleDescription = "DashBoard";
            this.btnDashBoard.AccessibleName = "DashBoard";
            this.btnDashBoard.Image = global::SMS.Properties.Resources.dashBoard1;
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "Classes";
            this.radMenuItem1.AccessibleName = "Classes";
            this.radMenuItem1.Image = global::SMS.Properties.Resources.Class;
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnClasses,
            this.btnSections,
            this.btnSubjects});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Classes";
            // 
            // btnClasses
            // 
            this.btnClasses.AccessibleDescription = "Manage Classes";
            this.btnClasses.AccessibleName = "Manage Classes";
            this.btnClasses.Image = global::SMS.Properties.Resources.ClassStudents;
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Text = "Manage Classes";
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btnSections
            // 
            this.btnSections.AccessibleDescription = "Manage Section";
            this.btnSections.AccessibleName = "Manage Section";
            this.btnSections.Image = global::SMS.Properties.Resources.Section;
            this.btnSections.Name = "btnSections";
            this.btnSections.Text = "Manage Section";
            this.btnSections.Click += new System.EventHandler(this.btnSections_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.AccessibleDescription = "Manage Subjects";
            this.btnSubjects.AccessibleName = "Manage Subjects";
            this.btnSubjects.Image = global::SMS.Properties.Resources.Subjets;
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Text = "Manage Subjects";
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.AccessibleDescription = "Students";
            this.btnStudents.AccessibleName = "Students";
            this.btnStudents.Image = global::SMS.Properties.Resources.Students;
            this.btnStudents.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnManageStudents,
            this.btnManageClassStudents,
            this.btnClassStudents,
            this.btnAdmissionFee});
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Text = "Students";
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.AccessibleDescription = "Manage Students";
            this.btnManageStudents.AccessibleName = "Manage Students";
            this.btnManageStudents.Image = global::SMS.Properties.Resources.Students;
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Text = "Manage Students";
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // btnManageClassStudents
            // 
            this.btnManageClassStudents.AccessibleDescription = "Manage Class Students";
            this.btnManageClassStudents.AccessibleName = "Manage Class Students";
            this.btnManageClassStudents.Image = global::SMS.Properties.Resources.ClassStudents;
            this.btnManageClassStudents.Name = "btnManageClassStudents";
            this.btnManageClassStudents.Text = "Manage Class Students";
            this.btnManageClassStudents.Click += new System.EventHandler(this.btnManageClassStudents_Click);
            // 
            // btnClassStudents
            // 
            this.btnClassStudents.AccessibleDescription = "radMenuItem2";
            this.btnClassStudents.AccessibleName = "radMenuItem2";
            this.btnClassStudents.Image = global::SMS.Properties.Resources.Class;
            this.btnClassStudents.Name = "btnClassStudents";
            this.btnClassStudents.Text = "Class Students";
            this.btnClassStudents.Click += new System.EventHandler(this.btnClassStudents_Click);
            // 
            // btnAdmissionFee
            // 
            this.btnAdmissionFee.AccessibleDescription = "Admission Fee";
            this.btnAdmissionFee.AccessibleName = "Admission Fee";
            this.btnAdmissionFee.Image = global::SMS.Properties.Resources.Dues;
            this.btnAdmissionFee.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnPrintVoucher,
            this.BtnSubmitVoucher});
            this.btnAdmissionFee.Name = "btnAdmissionFee";
            this.btnAdmissionFee.Text = "Admission Fee";
            // 
            // btnPrintVoucher
            // 
            this.btnPrintVoucher.AccessibleDescription = "PrintChallan";
            this.btnPrintVoucher.AccessibleName = "PrintChallan";
            this.btnPrintVoucher.Image = global::SMS.Properties.Resources.Due1;
            this.btnPrintVoucher.Name = "btnPrintVoucher";
            this.btnPrintVoucher.Text = "PrintChallan";
            this.btnPrintVoucher.Click += new System.EventHandler(this.btnPrintVoucher_Click);
            // 
            // BtnSubmitVoucher
            // 
            this.BtnSubmitVoucher.AccessibleDescription = "Submit Challan";
            this.BtnSubmitVoucher.AccessibleName = "Submit Challan";
            this.BtnSubmitVoucher.Image = global::SMS.Properties.Resources.Submit;
            this.BtnSubmitVoucher.Name = "BtnSubmitVoucher";
            this.BtnSubmitVoucher.Text = "Submit Challan";
            this.BtnSubmitVoucher.Click += new System.EventHandler(this.BtnSubmitVoucher_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.AccessibleDescription = "Teacher";
            this.btnTeacher.AccessibleName = "Teacher";
            this.btnTeacher.Image = global::SMS.Properties.Resources.Teacher;
            this.btnTeacher.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnManageTeachers,
            this.btnManageClassTeacher});
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Text = "Teacher";
            // 
            // btnManageTeachers
            // 
            this.btnManageTeachers.AccessibleDescription = "Manage Teacher";
            this.btnManageTeachers.AccessibleName = "Manage Teacher";
            this.btnManageTeachers.Image = global::SMS.Properties.Resources.Teacher;
            this.btnManageTeachers.Name = "btnManageTeachers";
            this.btnManageTeachers.Text = "Manage Teacher";
            this.btnManageTeachers.Click += new System.EventHandler(this.btnManageTeachers_Click);
            // 
            // btnManageClassTeacher
            // 
            this.btnManageClassTeacher.AccessibleDescription = "Manage Class Teachers";
            this.btnManageClassTeacher.AccessibleName = "Manage Class Teachers";
            this.btnManageClassTeacher.Image = global::SMS.Properties.Resources.Teacher;
            this.btnManageClassTeacher.Name = "btnManageClassTeacher";
            this.btnManageClassTeacher.Text = "Manage Class Teachers";
            this.btnManageClassTeacher.Click += new System.EventHandler(this.btnManageClassTeacher_Click);
            // 
            // btnExams
            // 
            this.btnExams.AccessibleDescription = "Exams";
            this.btnExams.AccessibleName = "Exams";
            this.btnExams.Image = global::SMS.Properties.Resources.Marks;
            this.btnExams.Name = "btnExams";
            this.btnExams.Text = "Exams";
            // 
            // btnAccounting
            // 
            this.btnAccounting.AccessibleDescription = "Accounting";
            this.btnAccounting.AccessibleName = "Accounting";
            this.btnAccounting.Image = global::SMS.Properties.Resources.blnce;
            this.btnAccounting.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnDuesStructure});
            this.btnAccounting.Name = "btnAccounting";
            this.btnAccounting.Text = "Accounting";
            // 
            // btnDuesStructure
            // 
            this.btnDuesStructure.AccessibleDescription = "Dues Schedule";
            this.btnDuesStructure.AccessibleName = "Dues Schedule";
            this.btnDuesStructure.Name = "btnDuesStructure";
            this.btnDuesStructure.Text = "Dues Structure";
            this.btnDuesStructure.Click += new System.EventHandler(this.btnDuesStructure_Click);
            // 
            // btnDues
            // 
            this.btnDues.AccessibleDescription = "Dues";
            this.btnDues.AccessibleName = "Dues";
            this.btnDues.Image = global::SMS.Properties.Resources.Due;
            this.btnDues.Name = "btnDues";
            this.btnDues.Text = "Dues";
            // 
            // mainmenu
            // 
            this.mainmenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mainmenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnDashBoard,
            this.radMenuItem1,
            this.btnStudents,
            this.btnTeacher,
            this.btnExams,
            this.btnAccounting,
            this.btnDues,
            this.btnExit});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(1266, 35);
            this.mainmenu.TabIndex = 1;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1266, 505);
            this.Controls.Add(this.mainmenu);
            this.IsMdiContainer = true;
            this.Name = "DashBoard";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadMenuItem btnDashBoard;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem btnClasses;
        private Telerik.WinControls.UI.RadMenuItem btnSections;
        private Telerik.WinControls.UI.RadMenuItem btnSubjects;
        private Telerik.WinControls.UI.RadMenuItem btnStudents;
        private Telerik.WinControls.UI.RadMenuItem btnTeacher;
        private Telerik.WinControls.UI.RadMenuItem btnExams;
        private Telerik.WinControls.UI.RadMenuItem btnAccounting;
        private Telerik.WinControls.UI.RadMenuItem btnManageStudents;
        private Telerik.WinControls.UI.RadMenuItem btnManageClassStudents;
        private Telerik.WinControls.UI.RadMenuItem btnManageTeachers;
        private Telerik.WinControls.UI.RadMenuItem btnManageClassTeacher;
        private Telerik.WinControls.UI.RadMenuItem btnClassStudents;
        private Telerik.WinControls.UI.RadMenuItem btnDues;
        private Telerik.WinControls.UI.RadMenuItem btnDuesStructure;
        private Telerik.WinControls.UI.RadMenuItem btnExit;
        private Telerik.WinControls.UI.RadMenuItem btnAdmissionFee;
        private Telerik.WinControls.UI.RadMenuItem btnPrintVoucher;
        private Telerik.WinControls.UI.RadMenuItem BtnSubmitVoucher;
        private Telerik.WinControls.UI.RadMenu mainmenu;
    }
}