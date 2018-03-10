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
    public partial class ManageSections : Telerik.WinControls.UI.RadForm
    {
        public ManageSections()
        {
            InitializeComponent();
            Class();
            Sections();
        }
        public void Class()
        {
            DataTable dtClass = LogicKernal.Classes.GetAllClasses();
            cmbClass.DataSource = dtClass;
            cmbClass.ValueMember = "ClassID";
            cmbClass.DisplayMember = "ClassName";
            
        }
        public void Sections()
        {
            DataTable dtSections = LogicKernal.ClassSections.GetAllClassSections();
            DataTable dtSection = dtSections.Copy();
            dtSection.Columns.Add("UserName" as string);
            dtSection.Columns.Add("ClassName" as string);
            dtSection.Columns.Remove("UserID");
            int i = 0;
            foreach (DataRow dr in dtSections.Rows)
            {
                int UserID = Convert.ToInt32(dr["UserID"]);
                int ClassID= Convert.ToInt32(dr["ClassID"]);
                DataTable dtUser = LogicKernal.Users.GetUsersByID(UserID);
                DataTable dtClass = LogicKernal.Classes.GetClassesByID(ClassID);

                dtSection.Rows[i]["UserName"] = dtUser.Rows[0]["UserName"].ToString();
                dtSection.Rows[i]["ClassName"] = dtClass.Rows[0]["ClassName"].ToString();
                i++;
            }
            grdSection.DataSource = dtSection;
        }

        private void grdSection_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            var SectionID = this.grdSection.CurrentRow.Cells[0].Value;
            DataTable dtSection = LogicKernal.ClassSections.GetClassSectionsByID(Convert.ToInt16( SectionID));
            txtSectionName.Text = dtSection.Rows[0]["SectionName"].ToString();
            cmbClass.SelectedValue= dtSection.Rows[0]["ClassID"].ToString();
            txtRemarks.Text= dtSection.Rows[0]["Remarks"].ToString();
            chkISEnabled.Checked=Convert.ToBoolean (dtSection.Rows[0]["IsEnabled"]);
            lblSectionID.Text = SectionID.ToString();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            lblSectionID.Text = "";
            txtSectionName.Text = "";
            txtRemarks.Text = "";
            chkISEnabled.Checked = false;
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSectionName.Text != "")
            {
                BusinessEntities.ClassSections objSection = new BusinessEntities.ClassSections();
                if (lblSectionID.Text == "")
                {
                    objSection.SectionID = 0;
                }
                else
                    objSection.SectionID = Convert.ToInt16(lblSectionID.Text);
                objSection.SectionName = txtSectionName.Text;
                objSection.ClassID = Convert.ToInt16(cmbClass.SelectedValue);
                objSection.DateCreated = System.DateTime.Now;
                objSection.IsEnabled = chkISEnabled.Checked;
                objSection.Remarks = txtRemarks.Text;
                objSection.UserID = LogicKernal.Users.LoginInfo.UserID;
                if (LogicKernal.ClassSections.InsertUpdateClassSections(objSection).Rows.Count > 0)
                {
                    MessageBox.Show("Section Inserted");
                    Sections();
                    lblSectionID.Text = "";
                    txtSectionName.Text = "";
                    txtRemarks.Text = "";
                    chkISEnabled.Checked = false;
                }
                else
                    MessageBox.Show("Try Again ");
            }
            else
                MessageBox.Show("Please Enter Section Name...");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var SectionID = this.grdSection.CurrentRow.Cells[0].Value;
            if (LogicKernal.ClassSections.DeleteClassSections(Convert.ToInt32(SectionID)).Rows.Count > 0)
            {
                MessageBox.Show("Deleted");
                Sections();
            }
            else
            {
                MessageBox.Show("Can not be deleted");
            }
        }
        //testtingg
    }
}
