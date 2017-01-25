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
    partial class CreateGroupPanel : UserControl
    {
        MyController m_controller;
        public CreateGroupPanel(MyController c)
        {
            m_controller = c;
            InitializeComponent();
        }

        private void create_grp_btn_Click(object sender, EventArgs e)
        {
            m_controller.CreateGroup(email_textBox.Text, grpName_textBox.Text, area_textBox.Text);
            email_textBox.Text = "";
            grpName_textBox.Text = "";
            area_textBox.Text = "trip\\ date\\ sport\\ apartment";
        }

        private void area_textBox_Click(object sender, EventArgs e)
        {
            area_textBox.Text = "";
        }
    }
}
