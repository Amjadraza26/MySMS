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
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            int UserID = LogicKernal.Users.Login(Email, Password);
            if (UserID > 0)
            {
                LogicKernal.Users.LoginInfo.UserID = UserID;
                
                DashBoard dashboard = new DashBoard();
                dashboard.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Try Again");
        }
    }
}
