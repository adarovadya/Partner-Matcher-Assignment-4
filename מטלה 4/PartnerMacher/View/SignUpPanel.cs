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
    partial class SignUpPanel : UserControl
    {
        MyController myControl;
        public SignUpPanel(MyController m)
        {
            myControl = m;
            InitializeComponent();
        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            myControl.SignUp(email_textBox.Text, password_textBox.Text, 
                name_textBox.Text, address_textBox.Text, birthday_textBox.Text, sex_textBox.Text);
            email_textBox.Text = "";
            password_textBox.Text = "8 characters";
            name_textBox.Text = "";
            birthday_textBox.Text = "dd/mm/yyyy";
            sex_textBox.Text = "f/m";
            address_textBox.Text = "";
        }

        private void password_textBox_Click(object sender, EventArgs e)
        {
            password_textBox.Text = "";
        }

        private void sex_textBox_Click(object sender, EventArgs e)
        {
            sex_textBox.Text = "";
        }

        private void birthday_textBox_Click(object sender, EventArgs e)
        {
            birthday_textBox.Text = "";
        }
    }
}
