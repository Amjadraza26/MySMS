using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SMS
{
    public partial class ManageClassStudents : Telerik.WinControls.UI.RadForm
    {
        public ManageClassStudents()
        {
            InitializeComponent();
            Class();
            Students();
            ClassStudents();
        }
        public void ClassStudents()
        {
            DataTable dtStudents = LogicKernal.ClassStudents.GetAllClassStudents();
            DataTable dtStudent = dtStudents.Copy();
            dtStudent.Columns.Add("ClassName" as string);
            dtStudent.Columns.Add("StudentName" as string);
            dtStudent.Columns.Add("SectionName" as string);
            int i = 0;
            foreach (DataRow dr in dtStudents.Rows)
            {
                int StudentID = Convert.ToInt32(dr["StudentID"]);
                int SectionID = Convert.ToInt32(dr["SectionID"]);
                int ClassID = Convert.ToInt32(dr["ClassID"]);
                
                DataTable dtClass = LogicKernal.Classes.GetClassesByID(ClassID);
                DataTable dtSt = LogicKernal.Students.GetStudentsByID(StudentID);
                DataTable dtSection = LogicKernal.ClassSections.GetClassSectionsByID(SectionID);

                dtStudent.Rows[i]["StudentName"] = dtSt.Rows[0]["StudentName"].ToString();
                dtStudent.Rows[i]["ClassName"] = dtClass.Rows[0]["ClassName"].ToString();
                dtStudent.Rows[i]["SectionName"] = dtSection.Rows[0]["SectionName"].ToString();
                i++;
            }
            grdClassStudents.DataSource = dtStudent;
        }
        public void Class()
        {
            DataTable dtClass = LogicKernal.Classes.GetAllClasses();
            cmbClass.DataSource = dtClass;
            cmbClass.ValueMember = "ClassID";
            cmbClass.DisplayMember = "ClassName";

        }
        public void Students()
        {
            DataTable dtStudents= LogicKernal.Students.GetAllStudents();
            cmbStudents.DataSource = dtStudents;
            cmbStudents.ValueMember = "StudentID";
            cmbStudents.DisplayMember = "StudentName";

        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ClassID = Convert.ToInt16(cmbClass.SelectedValue);
                DataTable dtSection = LogicKernal.ClassSections.GetSectionByClassID(ClassID);
                cmbSection.DataSource = dtSection;
                cmbSection.ValueMember = "SectionID";
                cmbSection.DisplayMember = "SectionName";
            }
            catch (Exception ex)
            {
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ClassID = Convert.ToInt16(cmbClass.SelectedValue);
            int SectionID = Convert.ToInt16(cmbSection.SelectedValue);

            DataTable dtStudents = LogicKernal.ClassStudents.ClassStudent(ClassID, SectionID);
            int ClassCount = dtStudents.Rows.Count;
            BusinessEntities.ClassStudents objStudent = new BusinessEntities.ClassStudents();
            objStudent.ClassStudentID = 0;
            objStudent.StudentID = Convert.ToInt16(cmbStudents.SelectedValue);
            objStudent.ClassID= Convert.ToInt16(cmbClass.SelectedValue);
            objStudent.SectionID= Convert.ToInt16(cmbSection.SelectedValue);
            objStudent.UserID = LogicKernal.Users.LoginInfo.UserID;
            objStudent.DateCreated = System.DateTime.Now;
            objStudent.RollNo = ClassCount + 1;
            objStudent.IsEnabled = chkIsEnabled.Checked;
            objStudent.Remarks = txtRemarks.Text;
            if (LogicKernal.ClassStudents.InsertUpdateClassStudents(objStudent).Rows.Count > 0)
            {
                MessageBox.Show("Inserted");
                Class();
                Students();
                ClassStudents();
                txtRemarks.Text = "";
                chkIsEnabled.Checked = false;

            }
            else
                MessageBox.Show("Try Again...!");
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Class();
            Students();
            ClassStudents();
            txtRemarks.Text = "";
            chkIsEnabled.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var ClassStudentID = this.grdClassStudents.CurrentRow.Cells[0].Value;
            if (LogicKernal.ClassStudents.DeleteClassStudents(Convert.ToInt32(ClassStudentID)).Rows.Count > 0)
            {
                MessageBox.Show("Deleted");
                ClassStudents();
            }
            else
            {
                MessageBox.Show("Can not be deleted");
            }
        }

        private void grdClassStudents_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            var ClassStudentID = this.grdClassStudents.CurrentRow.Cells[0].Value;
            DataTable dtStudents = LogicKernal.ClassStudents.GetClassStudentsByID(Convert.ToInt16(ClassStudentID));
            cmbClass.SelectedValue = Convert.ToInt16(dtStudents.Rows[0]["ClassID"]);
            cmbSection.SelectedValue = Convert.ToInt16(dtStudents.Rows[0]["SectionID"]);
            cmbStudents.SelectedValue = Convert.ToInt16(dtStudents.Rows[0]["StudentID"]);
            txtRemarks.Text = dtStudents.Rows[0]["Remarks"].ToString();
            chkIsEnabled.Checked = Convert.ToBoolean(dtStudents.Rows[0]["IsEnabled"]);
        }
    }
}
