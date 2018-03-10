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
    public partial class ManageTeachers : Telerik.WinControls.UI.RadForm
    {
        public ManageTeachers()
        {
            InitializeComponent();
            Teachers();
        }
        public void Teachers()
        {
            DataTable dtteachers = LogicKernal.Teachers.GetAllTeachers();
            grdTeachers.DataSource = dtteachers;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BusinessEntities.Teachers ObjTeachers = new BusinessEntities.Teachers();
            if (lblTeacherID.Text == "")
            {
                ObjTeachers.TeacherID = 0;
            }
            else
                ObjTeachers.TeacherID = Convert.ToInt16(lblTeacherID.Text);
            ObjTeachers.TeacherName = txtTeacherName.Text;
            ObjTeachers.TeacherEmail = txtEmail.Text;
            ObjTeachers.TeacherEducation = txtEducation.Text;
            ObjTeachers.TeacherSpecialization = txtSpecialization.Text;
            ObjTeachers.TeacherContactNo = txtContactNo.Text;
            ObjTeachers.TeacherImage = txtImage.Text;
            ObjTeachers.DateCreated = System.DateTime.Now;
            ObjTeachers.IsEnabled = chkIsEnabled.Checked;
            ObjTeachers.Remarks = txtRemarks.Text;
            ObjTeachers.UserID = LogicKernal.Users.LoginInfo.UserID;
            if (LogicKernal.Teachers.InsertUpdateTeachers(ObjTeachers).Rows.Count > 0)
            {
                MessageBox.Show("Inserted!");
                lblTeacherID.Text = "";
                txtContactNo.Text = "";
                txtEducation.Text = "";
                txtEmail.Text = "";
                txtImage.Text = "";
                txtRemarks.Text = "";
                txtSpecialization.Text = "";
                txtTeacherName.Text = "";
                chkIsEnabled.Checked = false;
                SelectedImage.Image = Image.FromFile("D:\\SMS\\SMS\\SMS\\Images\\Teacher.png");
                Teachers();
            }
            else
                MessageBox.Show("Try Again");
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();


            if (dlg.ShowDialog() == DialogResult.OK)
            {

                txtImage.Text = dlg.FileName;
                SelectedImage.Image = Image.FromFile(dlg.FileName);
            }

            dlg.Dispose();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            lblTeacherID.Text = "";
            txtContactNo.Text = "";
            txtEducation.Text = "";
            txtEmail.Text = "";
            txtImage.Text = "";
            txtRemarks.Text = "";
            txtSpecialization.Text = "";
            txtTeacherName.Text = "";
            chkIsEnabled.Checked = false;
            SelectedImage.Image = Image.FromFile("D:\\SMS\\SMS\\SMS\\Images\\Teacher.png");
        }

        private void grdTeachers_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            var TeacherID = this.grdTeachers.CurrentRow.Cells[0].Value;
            DataTable dtTeacher = LogicKernal.Teachers.GetTeachersByID(Convert.ToInt16(TeacherID));
            lblTeacherID.Text = TeacherID.ToString();
            txtContactNo.Text = dtTeacher.Rows[0]["TeacherContactNo"].ToString();
            txtEducation.Text = dtTeacher.Rows[0]["TeacherEducation"].ToString();
            txtEmail.Text = dtTeacher.Rows[0]["TeacherEmail"].ToString();
            txtImage.Text = dtTeacher.Rows[0]["TeacherImage"].ToString();
            txtRemarks.Text = dtTeacher.Rows[0]["Remarks"].ToString();
            txtSpecialization.Text = dtTeacher.Rows[0]["TeacherSpecialization"].ToString();
            txtTeacherName.Text = dtTeacher.Rows[0]["TeacherName"].ToString();
            chkIsEnabled.Checked = Convert.ToBoolean(dtTeacher.Rows[0]["IsEnabled"]);
            SelectedImage.Image = Image.FromFile(dtTeacher.Rows[0]["TeacherImage"].ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var TeacherID = this.grdTeachers.CurrentRow.Cells[0].Value;
            if(LogicKernal.Teachers.DeleteTeachers(Convert.ToInt16(TeacherID)).Rows.Count>0)
            {
                MessageBox.Show("Record Deleted");
                Teachers();
            }
            else
            {
                MessageBox.Show("Try Again...");
            }
        }
    }
}
