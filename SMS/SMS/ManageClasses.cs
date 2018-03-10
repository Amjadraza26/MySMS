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
    public partial class ManageClasses : Telerik.WinControls.UI.RadForm
    {
        public ManageClasses()
        {
            InitializeComponent();
            viewdata();
        }
        public void viewdata()
        {
            DataTable dtClasses = LogicKernal.Classes.GetAllClasses();
            DataTable dtClass = dtClasses.Copy();
            dtClass.Columns.Add("UserName" as string);
            dtClass.Columns.Remove("UserID");
            int i = 0;
            foreach (DataRow dr in dtClasses.Rows)
            {
                int UserID =Convert.ToInt32( dr["UserID"]);
                DataTable dtUser =LogicKernal.Users.GetUsersByID(UserID);
                dtClass.Rows[i]["UserName"] = dtUser.Rows[0]["UserName"].ToString();
                i++;
            }
            grdClasses.DataSource = dtClass;
          

        }

        private void grdClasses_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            var ClassID = this.grdClasses.CurrentRow.Cells[0].Value;
            DataTable dtClass = LogicKernal.Classes.GetClassesByID(Convert.ToInt32(ClassID));
            txtClassName.Text = dtClass.Rows[0]["ClassName"].ToString();
            txtNumericValue.Text = dtClass.Rows[0]["NumericName"].ToString();
            txtRemarks.Text = dtClass.Rows[0]["Remarks"].ToString();
            chkIsEnabled.Checked = Convert.ToBoolean(dtClass.Rows[0]["IsEnabled"]);
            lblClassID.Text = dtClass.Rows[0]["ClassID"].ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var ClassID = this.grdClasses.CurrentRow.Cells[0].Value;
            if(LogicKernal.Classes.DeleteClasses(Convert.ToInt32(ClassID)).Rows.Count>0)
            {
                MessageBox.Show("Deleted");
                viewdata();
            }
            else
            {
                MessageBox.Show("Can not be deleted");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BusinessEntities.Classes objClasses = new BusinessEntities.Classes();
            if (lblClassID.Text == "")
                objClasses.ClassID = 0;
            else
            objClasses.ClassID =Convert.ToInt32( lblClassID.Text);

            objClasses.ClassName = txtClassName.Text;
            objClasses.NumericName = txtNumericValue.Text;
            objClasses.DateCreated = System.DateTime.Now;
            objClasses.IsEnabled = chkIsEnabled.Checked;
            objClasses.UserID = LogicKernal.Users.LoginInfo.UserID;
            objClasses.Remarks = txtRemarks.Text;
            if(LogicKernal.Classes.InsertUpdateClasses(objClasses).Rows.Count>0)
            {
                MessageBox.Show("Inserted");
                txtClassName.Text = "";
                txtNumericValue.Text = "";
                txtRemarks.Text = "";
                chkIsEnabled.Checked = false;
                lblClassID.Text = "";
                viewdata();
            }
            else
            {
                MessageBox.Show("try Again");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassName.Text = "";
            txtNumericValue.Text = "";
            txtRemarks.Text = "";
            chkIsEnabled.Checked = false;
            lblClassID.Text = "";
        }


    }
}
