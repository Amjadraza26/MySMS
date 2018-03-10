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
    public partial class ManageClassTeachers : Telerik.WinControls.UI.RadForm
    {
        public ManageClassTeachers()
        {
            InitializeComponent();
            Class();
            Teachers();
            ClassTeachers();
        }
        public void ClassTeachers()
        {
            DataTable dtTeachers = LogicKernal.ClassTeachers.GetAllClassTeachers();
            DataTable dtTeacher = dtTeachers.Copy();
            dtTeacher.Columns.Add("ClassName" as string);
            dtTeacher.Columns.Add("SectionName" as string);
            dtTeacher.Columns.Add("SubjectName" as string);
            dtTeacher.Columns.Add("TeacherName" as string);

            int i = 0;
            foreach (DataRow dr in dtTeachers.Rows)
            {
                
                int ClassID = Convert.ToInt32(dr["ClassID"]);
                int SectionID = Convert.ToInt32(dr["SectionID"]);
                int SubjectID = Convert.ToInt32(dr["SubjectID"]);
                int TeacherID = Convert.ToInt32(dr["TeacherID"]);

                DataTable dtClass = LogicKernal.Classes.GetClassesByID(ClassID);
                DataTable dtSection = LogicKernal.ClassSections.GetClassSectionsByID(SectionID);
                DataTable dtSubject = LogicKernal.Subjects.GetSubjectsByID(SubjectID);
                DataTable dtTeacherName = LogicKernal.Teachers.GetTeachersByID(TeacherID);

                dtTeacher.Rows[i]["TeacherName"] = dtTeacherName.Rows[0]["TeacherName"].ToString();
                dtTeacher.Rows[i]["ClassName"] = dtClass.Rows[0]["ClassName"].ToString();
                dtTeacher.Rows[i]["SectionName"] = dtSection.Rows[0]["SectionName"].ToString();
                dtTeacher.Rows[i]["SubjectName"] = dtSubject.Rows[0]["SubjectName"].ToString();
                i++;
            }
            grdClassTeacher.DataSource = dtTeacher;
        }
        public void Class()
        {
            DataTable dtClass = LogicKernal.Classes.GetAllClasses();
            cmbClass.DataSource = dtClass;
            cmbClass.ValueMember = "ClassID";
            cmbClass.DisplayMember = "ClassName";

        }

        public void Teachers()
        {
            DataTable dtTeacher = LogicKernal.Teachers.GetAllTeachers();
            cmbTeacher.DataSource = dtTeacher;
            cmbTeacher.ValueMember = "TeacherID";
            cmbTeacher.DisplayMember = "TeacherName";
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

               
                DataTable dtSubjects = LogicKernal.Subjects.GetSubjectByClassID(ClassID);
                cmbSubjects.DataSource = dtSubjects;
                cmbSubjects.ValueMember = "SubjectID";
                cmbSubjects.DisplayMember = "SubjectName";
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BusinessEntities.ClassTeachers objTeacher = new BusinessEntities.ClassTeachers();
            if (lblClassTeacherID.Text == "")
            {
                objTeacher.ClassTeacherID = 0;
            }
            else
                objTeacher.ClassTeacherID = Convert.ToInt16(lblClassTeacherID.Text);
            objTeacher.ClassID = Convert.ToInt16(cmbClass.SelectedValue);
            objTeacher.DateCreated = DateTime.Now;
            objTeacher.IsEnabled = chkIsEnabled.Checked;
            objTeacher.Remarks = txtRemarks.Text;
            objTeacher.SectionID = Convert.ToInt16(cmbSection.SelectedValue);
            objTeacher.SubjectID = Convert.ToInt16(cmbSubjects.SelectedValue);
            objTeacher.TeacherID = Convert.ToInt16(cmbTeacher.SelectedValue);
            objTeacher.UserID = LogicKernal.Users.LoginInfo.UserID;
            if (LogicKernal.ClassTeachers.InsertUpdateClassTeachers(objTeacher).Rows.Count > 0)
            {
                MessageBox.Show("Inserted");
                ClassTeachers();
                txtRemarks.Text = "";
                chkIsEnabled.Checked = false;
                lblClassTeacherID.Text = "";
                Class();
                Teachers();
               

            }
            else
                MessageBox.Show("Try Again...");

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtRemarks.Text = "";
            chkIsEnabled.Checked = false;
            lblClassTeacherID.Text = "";
            Class();
            Teachers();
            ClassTeachers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var ClassTeacherID = this.grdClassTeacher.CurrentRow.Cells[0].Value;
            if (LogicKernal.ClassTeachers.DeleteClassTeachers(Convert.ToInt32(ClassTeacherID)).Rows.Count > 0)
            {
                MessageBox.Show("Deleted");
                ClassTeachers();
            }
            else
            {
                MessageBox.Show("Can not be deleted");
            }
        }

        private void grdClassTeacher_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            var ClassTeacherID = this.grdClassTeacher.CurrentRow.Cells[0].Value;
            DataTable dtTeacher = LogicKernal.ClassTeachers.GetClassTeachersByID(Convert.ToInt16(ClassTeacherID));
            cmbClass.SelectedValue = Convert.ToInt16(dtTeacher.Rows[0]["ClassID"]);
            cmbSection.SelectedValue = Convert.ToInt16(dtTeacher.Rows[0]["SectionID"]);
            cmbSubjects.SelectedValue = Convert.ToInt16(dtTeacher.Rows[0]["SubjectID"]);
            cmbTeacher.SelectedValue = Convert.ToInt16(dtTeacher.Rows[0]["TeacherID"]);
            lblClassTeacherID.Text = ClassTeacherID.ToString();
            txtRemarks.Text = dtTeacher.Rows[0]["Remarks"].ToString();
            chkIsEnabled.Checked = Convert.ToBoolean(dtTeacher.Rows[0]["IsEnabled"]);

        }
    }
}
