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
    public partial class ClassStudents : Telerik.WinControls.UI.RadForm
    {
        public ClassStudents()
        {
            InitializeComponent();
            Class();
        }
        public void Class()
        {
            DataTable dtClass = LogicKernal.Classes.GetAllClasses();
            cmbClass.DataSource = dtClass;
            cmbClass.ValueMember = "ClassID";
            cmbClass.DisplayMember = "ClassName";

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

        private void btnViewClass_Click(object sender, EventArgs e)
        {
            Int16 ClassID = Convert.ToInt16(cmbClass.SelectedValue);
            Int16 SectionID = Convert.ToInt16(cmbSection.SelectedValue);
            DataTable dtStudents = LogicKernal.ClassStudents.ClassStudent(ClassID, SectionID);

            DataTable dtClassStudents = dtStudents.Copy();
            dtClassStudents.Columns.Add("StudentName" as string);
            dtClassStudents.Columns.Add("ClassName" as string);
            dtClassStudents.Columns.Add("SectionName" as string);
            dtClassStudents.Columns.Add("FatherName" as string);

            int i = 0;
            foreach (DataRow dr in dtStudents.Rows)
            {
                int StudentID = Convert.ToInt32(dr["StudentID"]);
                int classID = Convert.ToInt32(dr["ClassID"]);
                int sectionID = Convert.ToInt32(dr["SectionID"]);
                DataTable dtClass = LogicKernal.Classes.GetClassesByID(ClassID);
                DataTable dtSection = LogicKernal.ClassSections.GetClassSectionsByID(sectionID);
                DataTable dtStudent = LogicKernal.Students.GetStudentsByID(StudentID);

                dtClassStudents.Rows[i]["StudentName"] = dtStudent.Rows[0]["StudentName"].ToString();
                dtClassStudents.Rows[i]["FatherName"] = dtStudent.Rows[0]["FatherName"].ToString();
                dtClassStudents.Rows[i]["ClassName"] = dtClass.Rows[0]["ClassName"].ToString();
                dtClassStudents.Rows[i]["SectionName"] = dtSection.Rows[0]["SectionName"].ToString();
                i++;
            }
            grdClassStudents.DataSource = dtClassStudents;

        }
    }
}
