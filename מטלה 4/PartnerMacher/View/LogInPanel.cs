using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PartnerMacher.Controller;

namespace PartnerMacher.View
{
    partial class LogInPanel : UserControl
    {
        private MyController myControl;

        public LogInPanel(MyController c)
        {
            InitializeComponent();
            myControl = c;
            password_txtbox.PasswordChar = '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            myControl.Login(email_txtbox.Text, password_txtbox.Text);
            email_txtbox.Text = "";
            password_txtbox.Text = "";
        }
    }
}
