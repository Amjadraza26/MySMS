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
    public partial class ManageSubjects : Telerik.WinControls.UI.RadForm
    {
        public ManageSubjects()
        {
            InitializeComponent();
            Class();
            Subjects();
        }
        public void Class()
        {
            DataTable dtClass = LogicKernal.Classes.GetAllClasses();
            cmbClass.DataSource = dtClass;
            cmbClass.ValueMember = "ClassID";
            cmbClass.DisplayMember = "ClassName";

        }
        public void Subjects()
        {
            DataTable dtSubjects = LogicKernal.Subjects.GetAllSubjects();
            DataTable dtSubject = dtSubjects.Copy();
            dtSubject.Columns.Add("UserName" as string);
            dtSubject.Columns.Add("ClassName" as string);
            dtSubject.Columns.Remove("UserID");
            int i = 0;
            foreach (DataRow dr in dtSubjects.Rows)
            {
                int UserID = Convert.ToInt32(dr["UserID"]);
                int ClassID = Convert.ToInt32(dr["ClassID"]);
                DataTable dtUser = LogicKernal.Users.GetUsersByID(UserID);
                DataTable dtClass = LogicKernal.Classes.GetClassesByID(ClassID);

                dtSubject.Rows[i]["UserName"] = dtUser.Rows[0]["UserName"].ToString();
                dtSubject.Rows[i]["ClassName"] = dtClass.Rows[0]["ClassName"].ToString();
                i++;
            }
            grdSubjects.DataSource = dtSubject;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSubjectName.Text != "")
            {
                BusinessEntities.Subjects objSubject = new BusinessEntities.Subjects();
                if (lblSubjectID.Text == "")
                {
                    objSubject.SubjectID = 0;
                }
                else
                    objSubject.SubjectID = Convert.ToInt16(lblSubjectID.Text);
                objSubject.SubjectName = txtSubjectName.Text;
                objSubject.ClassID = Convert.ToInt16(cmbClass.SelectedValue);
                objSubject.DateCreated = System.DateTime.Now;
                objSubject.IsEnabled = chkISEnabled.Checked;
                objSubject.Remarks = txtRemarks.Text;
                objSubject.UserID = LogicKernal.Users.LoginInfo.UserID;
                if (LogicKernal.Subjects.InsertUpdateSubjects(objSubject).Rows.Count > 0)
                {
                    MessageBox.Show("Section Inserted");
                    Subjects();
                    lblSubjectID.Text = "";
                    txtSubjectName.Text = "";
                    txtRemarks.Text = "";
                    chkISEnabled.Checked = false;
                }
                else
                    MessageBox.Show("Try Again ");
            }
            else
                MessageBox.Show("Please Enter Subject Name...");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var SubjectID = this.grdSubjects.CurrentRow.Cells[0].Value;
            if (LogicKernal.Subjects.DeleteSubjects(Convert.ToInt32(SubjectID)).Rows.Count > 0)
            {
                MessageBox.Show("Deleted");
                Subjects();
            }
            else
            {
                MessageBox.Show("Can not be deleted");
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            lblSubjectID.Text = "";
            txtSubjectName.Text = "";
            txtRemarks.Text = "";
            chkISEnabled.Checked = false;
        }

        private void grdSubjects_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            var SubjectID = this.grdSubjects.CurrentRow.Cells[0].Value;
            DataTable dtSubject = LogicKernal.Subjects.GetSubjectsByID(Convert.ToInt16(SubjectID));
            lblSubjectID.Text = SubjectID.ToString();
            txtSubjectName.Text = dtSubject.Rows[0]["SubjectName"].ToString();
            txtRemarks.Text = dtSubject.Rows[0]["Remarks"].ToString();
            chkISEnabled.Checked = Convert.ToBoolean(dtSubject.Rows[0]["IsEnabled"]);


        }
    }
}
