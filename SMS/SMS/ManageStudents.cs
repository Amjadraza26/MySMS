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
    public partial class ManageStudents : Telerik.WinControls.UI.RadForm
    {
        public ManageStudents()
        {
            InitializeComponent();
            Students();
        }
        public void Students()
        {
            DataTable dtStudents = LogicKernal.Students.GetAllStudents();
            DataTable dtStudent = dtStudents.Copy();
            dtStudent.Columns.Add("Genders" as string);
            int i = 0;
            foreach (DataRow dr in dtStudents.Rows)
            {
               if(Convert.ToBoolean( dr["Gender"])==true)
                dtStudent.Rows[i]["Genders"] = "Female";
               else
                    dtStudent.Rows[i]["Genders"] = "Male";
                i++;
            }
            grdStudents.DataSource = dtStudent;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();


            if (dlg.ShowDialog() == DialogResult.OK)
            {
               
                txtImage.Text=dlg.FileName;
                SelectedImage.Image = Image.FromFile(dlg.FileName);
            }

            dlg.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BusinessEntities.Students objStudents = new BusinessEntities.Students();
            if(lblStudentID.Text=="")
            {
                objStudents.StudentID = 0;
            }
            else
                objStudents.StudentID=Convert.ToInt16(lblStudentID.Text);

            if(drpGender.SelectedIndex==0)
            {
                objStudents.Gender = true;
            }
            else
                objStudents.Gender = false;

            objStudents.StudentName = txtStudentName.Text;
            objStudents.FatherName = txtfatherName.Text;
            objStudents.DOB = Convert.ToDateTime(txtDob.Text);
            objStudents.CNIC = txtCNIC.Text;
            objStudents.Email = txtEmail.Text;
            objStudents.ContactNo = txtContactNo.Text;
            objStudents.Address = txtAddress.Text;
            objStudents.Image = txtImage.Text;
            objStudents.IsEnabled = chkIsEnabled.Checked;
            objStudents.Disability = chkDisability.Checked;
            objStudents.Discounted = chkDiscounted.Checked;
            objStudents.DateCreated = System.DateTime.Now;
            objStudents.Remarks = txtRemarks.Text;
            objStudents.UserID = LogicKernal.Users.LoginInfo.UserID;
            if (LogicKernal.Students.InsertUpdateStudents(objStudents).Rows.Count >0)
            {
                MessageBox.Show("Insered");
                Students();
                lblStudentID.Text = "";
                txtCNIC.Text = "";
                chkDiscounted.Checked = false;
                chkDisability.Checked = false;
                drpGender.SelectedIndex = 0;
                txtStudentName.Text = "";
                txtfatherName.Text = "";
                txtDob.Text = "";
                txtEmail.Text = "";
                txtContactNo.Text = "";
                txtAddress.Text = "";
                txtImage.Text = "";
                SelectedImage.Image = Image.FromFile("D:\\SMS\\SMS\\SMS\\Images\\ClassStudents.png");
                chkIsEnabled.Checked = false;
                txtRemarks.Text = "";

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var StudentID = this.grdStudents.CurrentRow.Cells[0].Value;
            if (LogicKernal.Students.DeleteStudents(Convert.ToInt32(StudentID)).Rows.Count > 0)
            {
                MessageBox.Show("Deleted");
                Students();
            }
            else
            {
                MessageBox.Show("Can not be deleted");
            }
        }

        private void grdStudents_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            var StudentID = this.grdStudents.CurrentRow.Cells[0].Value;
            DataTable DtStudent = LogicKernal.Students.GetStudentsByID(Convert.ToInt16(StudentID));
            lblStudentID.Text = StudentID.ToString();
            txtStudentName.Text = DtStudent.Rows[0]["StudentName"].ToString();
            txtfatherName.Text= DtStudent.Rows[0]["FatherName"].ToString();
            txtDob.Text= DtStudent.Rows[0]["DOB"].ToString();
            txtEmail.Text= DtStudent.Rows[0]["Email"].ToString();
            txtContactNo.Text= DtStudent.Rows[0]["ContactNo"].ToString();
            txtAddress.Text= DtStudent.Rows[0]["Address"].ToString();
            txtImage.Text= DtStudent.Rows[0]["Image"].ToString();
            SelectedImage.Image=Image.FromFile(DtStudent.Rows[0]["Image"].ToString());
            chkIsEnabled.Checked=Convert.ToBoolean(DtStudent.Rows[0]["IsEnabled"]);
            txtRemarks.Text= DtStudent.Rows[0]["Remarks"].ToString();
            txtCNIC.Text= DtStudent.Rows[0]["CNIC"].ToString();
            chkDiscounted.Checked = Convert.ToBoolean(DtStudent.Rows[0]["Discounted"]);
            chkDisability.Checked = Convert.ToBoolean(DtStudent.Rows[0]["Disability"]);
            drpGender.SelectedIndex = Convert.ToInt16(DtStudent.Rows[0]["Gender"]);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {


            lblStudentID.Text = "";
            txtStudentName.Text = "";
            txtfatherName.Text = "";
            txtDob.Text = "";
            txtEmail.Text = "";
            txtContactNo.Text = "";
            txtAddress.Text = "";
            txtImage.Text = "";
            SelectedImage.Image = Image.FromFile("D:\\SMS\\SMS\\SMS\\Images\\ClassStudents.png");
            chkIsEnabled.Checked = false;
            txtRemarks.Text = "";
            chkDiscounted.Checked = false;
            chkDisability.Checked = false;
            drpGender.SelectedIndex = 0;
        }
    }
}
