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
    public partial class SubmittAdmissionChallan : Telerik.WinControls.UI.RadForm
    {
        public SubmittAdmissionChallan()
        {
            InitializeComponent();
            UnpaidVouchers();
        }

        public void UnpaidVouchers()
        {
            DataTable dtvoucher = LogicKernal.FeeVouchers.GetUpaidVoucher();
            try
            {
                DataTable dtvouchers = dtvoucher.Copy();

                dtvouchers.Columns.Add("StudentName" as string);
                dtvouchers.Columns.Add("FatherName" as string);
                dtvouchers.Columns.Add("Address" as string);
                dtvouchers.Columns.Add("ContactNo" as string);
                int i = 0;
                foreach (DataRow dr in dtvouchers.Rows)
                {
                    int StudentID = Convert.ToInt32(dr["StudentID"]);

                    DataTable dtSt = LogicKernal.Students.GetStudentsByID(StudentID);

                    dtvouchers.Rows[i]["StudentName"] = dtSt.Rows[0]["StudentName"].ToString();
                    dtvouchers.Rows[i]["FatherName"] = dtSt.Rows[0]["FatherName"].ToString();
                    dtvouchers.Rows[i]["Address"] = dtSt.Rows[0]["Address"].ToString();
                    dtvouchers.Rows[i]["ContactNo"] = dtSt.Rows[0]["ContactNo"].ToString();
                    i++;
                }
                grdVouchers.DataSource = dtvouchers;
            }
            catch(Exception ex)
            {

            }

        }

        private void grdVouchers_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                var VoucherID = this.grdVouchers.CurrentRow.Cells[0].Value;
                DataTable dtVoucher = LogicKernal.FeeVouchers.GetFeeVouchersByID(Convert.ToInt16(VoucherID));
                DataTable dtStudent = LogicKernal.Students.GetStudentsByID(Convert.ToInt16(dtVoucher.Rows[0]["StudentID"]));
                txtStudentName.Text = dtStudent.Rows[0]["StudentName"].ToString();
                txtFatherName.Text = dtStudent.Rows[0]["FatherName"].ToString();
                txtContactNo.Text = dtStudent.Rows[0]["ContactNo"].ToString();
                txtAddress.Text = dtStudent.Rows[0]["Address"].ToString();
                txtCNIC.Text = dtStudent.Rows[0]["CNIC"].ToString();
                lblChallanID.Text = VoucherID.ToString();
            }
            catch(Exception ex)
            { }
          
        }

        private void txtSubmit_Click(object sender, EventArgs e)
        {
            if (lblChallanID.Text != "")
            {
                DataTable dtChallan = LogicKernal.FeeVouchers.GetFeeVouchersByID(Convert.ToInt16(lblChallanID.Text));
                BusinessEntities.FeeVouchers ObjVoucher = new BusinessEntities.FeeVouchers();
                ObjVoucher.VoucherID = Convert.ToInt16(lblChallanID.Text);
                ObjVoucher.StudentID = Convert.ToInt16(dtChallan.Rows[0]["StudentID"]);
                ObjVoucher.DateVoucherIssue = Convert.ToDateTime(dtChallan.Rows[0]["DateVoucherIssue"]);
                ObjVoucher.CollectedFee = dtChallan.Rows[0]["CollectedFee"].ToString();
                ObjVoucher.Remarks = txtRemarks.Text;
                ObjVoucher.IsEnabled = false;
                ObjVoucher.UserID = LogicKernal.Users.LoginInfo.UserID;
                ObjVoucher.DateVoucherSubmit = txtSubmittedDate.Text;
                if (LogicKernal.FeeVouchers.InsertUpdateFeeVouchers(ObjVoucher).Rows.Count > 0)
                {
                    MessageBox.Show("Voucher Submitted Successfuly...");
                    UnpaidVouchers();
                    lblChallanID.Text = "";
                    txtAddress.Text = "";
                    txtCNIC.Text = "";
                    txtContactNo.Text = "";
                    txtFatherName.Text = "";
                    txtRemarks.Text = "";
                    txtStudentName.Text = "";
                    txtSubmittedDate.Text = "";

                }
                else
                    MessageBox.Show("Error. Try Again....");
            }
            else
                MessageBox.Show("Please Select a Voucher First.....!!");
           

        }
    }
}
