namespace PartnerMacher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SignUpButton = new System.Windows.Forms.ToolStripButton();
            this.logInButton = new System.Windows.Forms.ToolStripButton();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.createGroupButton = new System.Windows.Forms.ToolStripButton();
            this.groupsButton = new System.Windows.Forms.ToolStripButton();
            this.aboutButton = new System.Windows.Forms.ToolStripButton();
            this.logopanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logo_lbl = new System.Windows.Forms.Label();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.loged_label = new System.Windows.Forms.Label();
            this.minimized_lbl = new System.Windows.Forms.Label();
            this.exit_lbl = new System.Windows.Forms.Label();
            this.tool_lbl = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.sidepanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.logopanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidepanel.Controls.Add(this.toolStrip1);
            this.sidepanel.Controls.Add(this.logopanel);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(193, 601);
            this.sidepanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SignUpButton,
            this.logInButton,
            this.searchButton,
            this.createGroupButton,
            this.groupsButton,
            this.aboutButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 79);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(193, 522);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "menu_tool";
            // 
            // SignUpButton
            // 
            this.SignUpButton.AutoSize = false;
            this.SignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.SignUpButton.CheckOnClick = true;
            this.SignUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SignUpButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.LightGray;
            this.SignUpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(191, 48);
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.Click += new System.EventHandler(this.ToolChanges_Click);
            // 
            // logInButton
            // 
            this.logInButton.AutoSize = false;
            this.logInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.logInButton.CheckOnClick = true;
            this.logInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.logInButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.ForeColor = System.Drawing.Color.LightGray;
            this.logInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(191, 48);
            this.logInButton.Text = "Log In";
            this.logInButton.Click += new System.EventHandler(this.ToolChanges_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = false;
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.searchButton.CheckOnClick = true;
            this.searchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.LightGray;
            this.searchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(191, 48);
            this.searchButton.Text = "Search Partners";
            this.searchButton.Click += new System.EventHandler(this.ToolChanges_Click);
            // 
            // createGroupButton
            // 
            this.createGroupButton.AutoSize = false;
            this.createGroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.createGroupButton.CheckOnClick = true;
            this.createGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.createGroupButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGroupButton.ForeColor = System.Drawing.Color.LightGray;
            this.createGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createGroupButton.Name = "createGroupButton";
            this.createGroupButton.Size = new System.Drawing.Size(191, 48);
            this.createGroupButton.Text = "Create Group";
            this.createGroupButton.Click += new System.EventHandler(this.ToolChanges_Click);
            // 
            // groupsButton
            // 
            this.groupsButton.AutoSize = false;
            this.groupsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.groupsButton.CheckOnClick = true;
            this.groupsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.groupsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsButton.ForeColor = System.Drawing.Color.LightGray;
            this.groupsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(191, 48);
            this.groupsButton.Text = "My Groups";
            this.groupsButton.Click += new System.EventHandler(this.ToolChanges_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.AutoSize = false;
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.aboutButton.CheckOnClick = true;
            this.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.LightGray;
            this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(191, 48);
            this.aboutButton.Text = "About";
            this.aboutButton.Click += new System.EventHandler(this.ToolChanges_Click);
            // 
            // logopanel
            // 
            this.logopanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.logopanel.Controls.Add(this.tableLayoutPanel1);
            this.logopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(193, 79);
            this.logopanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.782609F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.21739F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Controls.Add(this.logo_lbl, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(193, 79);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // logo_lbl
            // 
            this.logo_lbl.AutoSize = true;
            this.logo_lbl.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_lbl.ForeColor = System.Drawing.Color.White;
            this.logo_lbl.Location = new System.Drawing.Point(21, 8);
            this.logo_lbl.Name = "logo_lbl";
            this.logo_lbl.Size = new System.Drawing.Size(134, 62);
            this.logo_lbl.TabIndex = 0;
            this.logo_lbl.Text = "Partner\nMatcher";
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headerpanel.Controls.Add(this.loged_label);
            this.headerpanel.Controls.Add(this.minimized_lbl);
            this.headerpanel.Controls.Add(this.exit_lbl);
            this.headerpanel.Controls.Add(this.tool_lbl);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(193, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(998, 79);
            this.headerpanel.TabIndex = 1;
            this.headerpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerpanel_MouseDown);
            this.headerpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerpanel_MouseMove);
            this.headerpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerpanel_MouseUp);
            // 
            // loged_label
            // 
            this.loged_label.AutoSize = true;
            this.loged_label.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loged_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.loged_label.Location = new System.Drawing.Point(646, 33);
            this.loged_label.Name = "loged_label";
            this.loged_label.Size = new System.Drawing.Size(72, 23);
            this.loged_label.TabIndex = 4;
            this.loged_label.Text = "Offline";
            // 
            // minimized_lbl
            // 
            this.minimized_lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimized_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.minimized_lbl.Location = new System.Drawing.Point(922, 9);
            this.minimized_lbl.Name = "minimized_lbl";
            this.minimized_lbl.Size = new System.Drawing.Size(29, 34);
            this.minimized_lbl.TabIndex = 3;
            this.minimized_lbl.Text = "-";
            this.minimized_lbl.Click += new System.EventHandler(this.Minimized_Click);
            this.minimized_lbl.MouseEnter += new System.EventHandler(this.lableColor_MouseEnter);
            this.minimized_lbl.MouseLeave += new System.EventHandler(this.lableColor_MouseLeave);
            // 
            // exit_lbl
            // 
            this.exit_lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.exit_lbl.Location = new System.Drawing.Point(957, 9);
            this.exit_lbl.Name = "exit_lbl";
            this.exit_lbl.Size = new System.Drawing.Size(29, 34);
            this.exit_lbl.TabIndex = 2;
            this.exit_lbl.Text = "X";
            this.exit_lbl.Click += new System.EventHandler(this.exit_lbl_Click);
            this.exit_lbl.MouseEnter += new System.EventHandler(this.lableColor_MouseEnter);
            this.exit_lbl.MouseLeave += new System.EventHandler(this.lableColor_MouseLeave);
            // 
            // tool_lbl
            // 
            this.tool_lbl.AutoSize = true;
            this.tool_lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tool_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.tool_lbl.Location = new System.Drawing.Point(19, 24);
            this.tool_lbl.Name = "tool_lbl";
            this.tool_lbl.Size = new System.Drawing.Size(216, 33);
            this.tool_lbl.TabIndex = 1;
            this.tool_lbl.Text = "Search Partners";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(199, 85);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(980, 504);
            this.panel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1191, 601);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.sidepanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRVT";
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.logopanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton logInButton;
        private System.Windows.Forms.ToolStripButton searchButton;
        private System.Windows.Forms.ToolStripButton aboutButton;
        private System.Windows.Forms.Label logo_lbl;
        private System.Windows.Forms.Label minimized_lbl;
        private System.Windows.Forms.Label exit_lbl;
        private System.Windows.Forms.Label tool_lbl;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label labelclick;
        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.ToolStripButton SignUpButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripButton groupsButton;
        private System.Windows.Forms.ToolStripButton createGroupButton;
        private System.Windows.Forms.Label loged_label;
    }
}

