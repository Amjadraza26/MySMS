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
    public partial class PrintAdmissionFeeChallan : Telerik.WinControls.UI.RadForm
    {
        public PrintAdmissionFeeChallan()
        {
            InitializeComponent();
            Students();
        }
        public void Students()
        {
            DataTable dtStudents = LogicKernal.Students.GetAllStudents();
            cmbStudents.DataSource = dtStudents;
            cmbStudents.ValueMember = "StudentID";
            cmbStudents.DisplayMember = "StudentName";

        }

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int StudentID = Convert.ToInt16(cmbStudents.SelectedValue);
                DataTable dtStudent = LogicKernal.Students.GetStudentsByID(StudentID);
                txtFatherName.Text = dtStudent.Rows[0]["FatherName"].ToString();
                txtContactNo.Text = dtStudent.Rows[0]["ContactNo"].ToString();
                txtAddress.Text = dtStudent.Rows[0]["Address"].ToString();
                txtCnic.Text = dtStudent.Rows[0]["CNIC"].ToString();

            }
            catch(Exception Ex)
            {

            }
            
        }


        private void pdPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            BusinessEntities.FeeVouchers ObjFeeVoucher = new BusinessEntities.FeeVouchers();
            ObjFeeVoucher.VoucherID = 0;
            ObjFeeVoucher.StudentID = Convert.ToInt16(cmbStudents.SelectedValue);
            ObjFeeVoucher.CollectedFee = txtFee.Text;
            ObjFeeVoucher.DateVoucherIssue = DateTime.Now;
            ObjFeeVoucher.DateVoucherSubmit = "";
            ObjFeeVoucher.IsEnabled = true;
            ObjFeeVoucher.Remarks = "";
            ObjFeeVoucher.UserID = LogicKernal.Users.LoginInfo.UserID;
            DataTable dtInserted = LogicKernal.FeeVouchers.InsertUpdateFeeVouchers(ObjFeeVoucher);
            if (dtInserted.Rows.Count>0)
            {
                e.Graphics.Clear(SystemColors.Control);
                e.Graphics.RotateTransform(90);
                e.Graphics.DrawString("Islamia University Bahawalpur", new Font("Arial", 15, FontStyle.Bold), SystemBrushes.ControlText, 20, -800);
                e.Graphics.DrawString("Phone No.   03007027795", new Font("Arial", 10, FontStyle.Regular), SystemBrushes.ControlText, 70, -765);
                e.Graphics.DrawString("--------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Regular), SystemBrushes.ControlText, 10, -785);
                e.Graphics.DrawString("--------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Regular), SystemBrushes.ControlText, 10, -780);
                e.Graphics.DrawString("Challan No: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 40, -700);
                e.Graphics.DrawString(dtInserted.Rows[0]["Column1"].ToString(), new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 140, -700);
                e.Graphics.DrawString("A/C " + "0641852583686", new Font("Arial", 8, FontStyle.Bold), SystemBrushes.ControlText, 120, -730);


                e.Graphics.DrawString("Student Name: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 40, -600);
                e.Graphics.DrawString(cmbStudents.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 140, -600);
                e.Graphics.DrawString("Father Name: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 40, -550);
                e.Graphics.DrawString(txtFatherName.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 140, -550);
                e.Graphics.DrawString("CNIC/B-Form: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 40, -500);
                e.Graphics.DrawString(txtCnic.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 140, -500);
                e.Graphics.DrawString("Address: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 40, -450);
                e.Graphics.DrawString(txtCnic.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 140, -450);
                e.Graphics.DrawString("Admission Fee: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 40, -300);
                e.Graphics.DrawString("RS." + txtFee.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 140, -300);
                e.Graphics.DrawString("Date Issue: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 40, -250);
                e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 140, -250);


                e.Graphics.DrawString("Islamia University Bahawalpur", new Font("Arial", 15, FontStyle.Bold), SystemBrushes.ControlText, 360, -800);
                e.Graphics.DrawString("Phone No.   03007027795", new Font("Arial", 10, FontStyle.Regular), SystemBrushes.ControlText, 410, -770);
                e.Graphics.DrawString("--------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Regular), SystemBrushes.ControlText, 360, -785);
                e.Graphics.DrawString("--------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Regular), SystemBrushes.ControlText, 360, -780);
                e.Graphics.DrawString("Challan No: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 380, -700);
                e.Graphics.DrawString(dtInserted.Rows[0]["Column1"].ToString(), new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 480, -700);
                e.Graphics.DrawString("A/C " + "0641852583686", new Font("Arial", 8, FontStyle.Bold), SystemBrushes.ControlText, 460, -730);

                e.Graphics.DrawString("Student Name: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 380, -600);
                e.Graphics.DrawString(cmbStudents.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 480, -600);
                e.Graphics.DrawString("Father Name: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 380, -550);
                e.Graphics.DrawString(txtFatherName.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 480, -550);
                e.Graphics.DrawString("CNIC/B-Form: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 380, -500);
                e.Graphics.DrawString(txtCnic.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 480, -500);
                e.Graphics.DrawString("Address: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 380, -450);
                e.Graphics.DrawString(txtCnic.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 480, -450);
                e.Graphics.DrawString("Admission Fee: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 380, -300);
                e.Graphics.DrawString("RS." + txtFee.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 480, -300);
                e.Graphics.DrawString("Date Issue: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 380, -250);
                e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 480, -250);


                e.Graphics.DrawString("Islamia University Bahawalpur", new Font("Arial", 15, FontStyle.Bold), SystemBrushes.ControlText, 710, -800);
                e.Graphics.DrawString("Phone No.   03007027795", new Font("Arial", 10, FontStyle.Regular), SystemBrushes.ControlText, 760, -770);

                e.Graphics.DrawString("--------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Regular), SystemBrushes.ControlText, 710, -785);
                e.Graphics.DrawString("--------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Regular), SystemBrushes.ControlText, 710, -780);
                e.Graphics.DrawString("Challan No: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 720, -700);
                e.Graphics.DrawString(dtInserted.Rows[0]["Column1"].ToString(), new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 820, -700);
                e.Graphics.DrawString("A/C " + "0641852583686", new Font("Arial", 8, FontStyle.Bold), SystemBrushes.ControlText, 800, -730);

                e.Graphics.DrawString("Student Name: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 720, -600);
                e.Graphics.DrawString(cmbStudents.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 820, -600);
                e.Graphics.DrawString("Father Name: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 720, -550);
                e.Graphics.DrawString(txtFatherName.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 820, -550);
                e.Graphics.DrawString("CNIC/B-Form: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 720, -500);
                e.Graphics.DrawString(txtCnic.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 820, -500);
                e.Graphics.DrawString("Address: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 720, -450);
                e.Graphics.DrawString(txtCnic.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 820, -450);
                e.Graphics.DrawString("Admission Fee: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 720, -300);
                e.Graphics.DrawString("RS." + txtFee.Text, new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 820, -300);
                e.Graphics.DrawString("Date Issue: ", new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 720, -250);
                e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 820, -250);
            }
            else
            {
                MessageBox.Show("Try Again");
            }

            


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            pdPrintDocument.Print();
        }
    }
}
