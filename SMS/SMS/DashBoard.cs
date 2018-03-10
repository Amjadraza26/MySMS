using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMS
{
    public partial class DashBoard : Telerik.WinControls.UI.RadForm
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(LogicKernal.Users.LoginInfo.UserID>0)
            {
                
            }
            else
            {
               
                Login frmLogin = new Login();
                frmLogin.Show();
            }
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            ManageClasses Classes = new ManageClasses();
            Classes.MdiParent = this;
            Classes.Show();

        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            ManageStudents Students = new ManageStudents();
            Students.MdiParent = this;
            Students.Show();
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            ManageSections ManageSection = new ManageSections();
            ManageSection.MdiParent = this;
            ManageSection.Show();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            ManageSubjects ManageSubject = new ManageSubjects();
            ManageSubject.MdiParent = this;
            ManageSubject.Show();
        }

        private void btnManageTeachers_Click(object sender, EventArgs e)
        {
            ManageTeachers ManageTeachers = new ManageTeachers();
            ManageTeachers.MdiParent = this;
            ManageTeachers.Show();
        }

        private void btnManageClassStudents_Click(object sender, EventArgs e)
        {
            ManageClassStudents managestudents = new ManageClassStudents();
            managestudents.MdiParent = this;
            managestudents.Show();
        }

        private void btnManageClassTeacher_Click(object sender, EventArgs e)
        {
            ManageClassTeachers ManageClassTeacher = new ManageClassTeachers();
            ManageClassTeacher.MdiParent = this;
            ManageClassTeacher.Show();
        }

        private void btnClassStudents_Click(object sender, EventArgs e)
        {
            ClassStudents ClassStudents = new ClassStudents();
            ClassStudents.MdiParent = this;
            ClassStudents.Show();
        }

        private void btnDues_Click(object sender, EventArgs e)
        {
            ManageDues Managedues = new ManageDues();
            Managedues.MdiParent = this;
            Managedues.Show();
        }

        private void btnDuesStructure_Click(object sender, EventArgs e)
        {
            DuesStructure duesStructure = new DuesStructure();
            duesStructure.MdiParent = this;
            duesStructure.Show();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnPrintVoucher_Click(object sender, EventArgs e)
        {
            PrintAdmissionFeeChallan Challan = new PrintAdmissionFeeChallan();
            Challan.MdiParent = this;
            Challan.Show();
        }

        private void BtnSubmitVoucher_Click(object sender, EventArgs e)
        {
            SubmittAdmissionChallan Challan = new SubmittAdmissionChallan();
            Challan.MdiParent = this;
            Challan.Show();
        }
    }
}
