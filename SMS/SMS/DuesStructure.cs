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
    public partial class DuesStructure : Telerik.WinControls.UI.RadForm
    {
        public DuesStructure()
        {
            InitializeComponent();
            Class();
            viewStrecture();
        }
        public void Class()
        {
            DataTable dtClass = LogicKernal.Classes.GetAllClasses();
            cmbClass.DataSource = dtClass;
            cmbClass.ValueMember = "ClassID";
            cmbClass.DisplayMember = "ClassName";

        }

        public void viewStrecture()
        {
            DataTable dtDues = LogicKernal.DuesStructure.GetAllDuesStructure();
            DataTable dtDue = dtDues.Copy();
            dtDue.Columns.Add("ClassName" as string);

            int i = 0;
            foreach (DataRow dr in dtDues.Rows)
            {
                int ClassID = Convert.ToInt32(dr["ClassID"]);
                DataTable dtClass = LogicKernal.Classes.GetClassesByID(ClassID);
                dtDue.Rows[i]["ClassName"] = dtClass.Rows[0]["ClassName"].ToString();
                i++;

            }
            grdDues.DataSource = dtDue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BusinessEntities.DuesStructure ObjDues = new BusinessEntities.DuesStructure();
            if (lblDueAmountID.Text == "")
            {
                ObjDues.DueAmountID = 0;
            }
            else
                ObjDues.DueAmountID = Convert.ToInt16(lblDueAmountID.Text);

            ObjDues.ClassID = Convert.ToInt16(cmbClass.SelectedValue);
            ObjDues.TotalFee = Convert.ToInt16( txtAmount.Text);
            ObjDues.DateCreated = System.DateTime.Now;
            ObjDues.IsEnabled = chkISEnabled.Checked;
            ObjDues.Remarks = txtRemarks.Text;
            
            if (LogicKernal.DuesStructure.InsertUpdateDuesStructure(ObjDues).Rows.Count > 0)
            {
                MessageBox.Show("Inserted");
                viewStrecture();
                Class();
                lblDueAmountID.Text = "";

                txtAmount.Text = "";
                txtRemarks.Text = "";
                chkISEnabled.Checked = false;
            }
            else
                MessageBox.Show("Try Again...");
        }

        private void grdDues_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            var DueAmountID = this.grdDues.CurrentRow.Cells[0].Value;
            DataTable dtDues = LogicKernal.DuesStructure.GetDuesStructureByID(Convert.ToInt16(DueAmountID));

            lblDueAmountID.Text = DueAmountID.ToString();
            cmbClass.SelectedValue = Convert.ToInt16(dtDues.Rows[0]["ClassID"]);
            txtAmount.Text = dtDues.Rows[0]["TotalFee"].ToString();
            txtRemarks.Text = dtDues.Rows[0]["Remarks"].ToString();
            chkISEnabled.Checked = Convert.ToBoolean(dtDues.Rows[0]["IsEnabled"]);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Class();
            lblDueAmountID.Text = "";
           
            txtAmount.Text = "";
            txtRemarks.Text = "";
            chkISEnabled.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var DueAmountID = this.grdDues.CurrentRow.Cells[0].Value;
            if (LogicKernal.DuesStructure.DeleteDuesStructure(Convert.ToInt16(DueAmountID)).Rows.Count > 0)
            {
                MessageBox.Show("Deleted");
                viewStrecture();
            }
            else
                MessageBox.Show("Try Again");
        }
    }
}
