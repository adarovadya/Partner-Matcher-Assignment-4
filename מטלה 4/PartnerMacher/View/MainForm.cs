using PartnerMacher.Controller;
using PartnerMacher.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartnerMacher
{
    public partial class MainForm : Form, IView
    {
        int togMove, valX, valY;
        MyController myControl;
        AboutPanel about_panel;
        LogInPanel logIn_panel;
        SignUpPanel signUp_panel;
        SearchPanel search_panel;
        /**/CreateGroupPanel create_group_panel;
        bool logged;
        bool flag;

        public MainForm(IController control)
        {
            myControl =(MyController) control;
            about_panel = new AboutPanel();
            search_panel = new SearchPanel(myControl);
            logIn_panel = new LogInPanel(myControl);
            signUp_panel = new SignUpPanel(myControl);
            create_group_panel = new CreateGroupPanel(myControl);
            InitializeComponent();
            userChangeChoose("Log In");
            logged = false;
            flag = false;
        }

        private void lableColor_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.BackColor = Color.Gainsboro;
        }

        private void lableColor_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.BackColor = Color.WhiteSmoke;
        }

        private void headerpanel_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = 0;
        }

        private void headerpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - valX, MousePosition.Y - valY);
            }
        }

        private void clickHere_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new Font(label.Font.Name, label.Font.SizeInPoints, FontStyle.Underline);
        }

        private void clickHere_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new Font(label.Font.Name, label.Font.SizeInPoints, FontStyle.Regular);
        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void headerpanel_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = 1;
            valX = e.X;
            valY = e.Y;
        }

        private void Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void Output(string title, string output)
        {
            MessageBox.Show(output, title);
        }

        private void ToolChanges_Click(object sender, EventArgs e)
        {
            var button = sender as ToolStripButton;            
            userChangeChoose(button.Text);
        }

        private void clearPanels(string userChoose)
        {
            tool_lbl.Text = userChoose;
            panel.Controls.Clear();
            aboutButton.Checked = false;
            logInButton.Checked = false;
            searchButton.Checked = false;
            SignUpButton.Checked = false;
            groupsButton.Checked = false;
            createGroupButton.Checked = false;
        }

        public void returnLogin()
        {
            logged = true;
        }

        private void userChangeChoose(string userChoose)
        {
            if (!flag && logged)
            {
                flag = true;
                loged_label.Text = myControl.getConecteduser();
            }
            switch (userChoose)
            {
                case "Search Partners":
                    if (!logged)
                    {
                        MessageBox.Show("In order to start searching you must first Login", "Error");
                        searchButton.Checked = false;
                    }
                    else
                    {
                        clearPanels(userChoose);
                        panel.Controls.Add(new SearchPanel(myControl));
                        searchButton.Checked = true;
                    }
                    break;
                case "Sign Up":
                    clearPanels(userChoose);
                    panel.Controls.Add(new SignUpPanel(myControl));
                    SignUpButton.Checked = true;
                    break;
                case "Log In":
                    clearPanels(userChoose);
                    panel.Controls.Add(new LogInPanel(myControl)/*logIn_panel*/);
                    logInButton.Checked = true;
                    break;
                case "About":
                    clearPanels(userChoose);
                    panel.Controls.Add(new AboutPanel()/*about_panel*/);
                    aboutButton.Checked = true;
                    break;

                case "My Groups":
                    if (!logged)
                    {
                        MessageBox.Show("In order to start searching you must first Login", "Error");
                        groupsButton.Checked = false;
                    }
                    else
                    {
                        clearPanels(userChoose);
                        panel.Controls.Add(new ShowUserGroup(myControl));
                        groupsButton.Checked = true;
                    }
                    break;
                case "Create Group":
                    if (!logged)
                    {
                        MessageBox.Show("In order to start searching you must first Login", "Error");
                        createGroupButton.Checked = false;
                    }
                    else
                    {
                        clearPanels(userChoose);
                        panel.Controls.Add(new CreateGroupPanel(myControl));
                        createGroupButton.Checked = true;
                    }
                    break;
            }
        }
    }
}

class MyRenderer : ToolStripProfessionalRenderer
{
    protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
    {
        if (!e.Item.Selected)
        {
            base.OnRenderButtonBackground(e);
        }
        else
        {
            Rectangle rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
            Color color = Color.FromArgb(01, 13, 25);
            Brush brush = new SolidBrush(color);
            e.Graphics.FillRectangle(brush, rectangle);
            e.Graphics.DrawRectangle(Pens.Gainsboro, rectangle);
        }
    }
}
