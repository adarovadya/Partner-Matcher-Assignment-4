namespace PartnerMacher.View
{
    partial class ShowUserGroup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groups_gv = new System.Windows.Forms.DataGridView();
            this.NameOfGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaOfgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.join_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfMembersInGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_panel = new System.Windows.Forms.Panel();
            this.publishAds_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groups_gv)).BeginInit();
            this.search_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.groups_gv);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 360);
            this.panel1.TabIndex = 20;
            // 
            // groups_gv
            // 
            this.groups_gv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groups_gv.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groups_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.groups_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups_gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfGroup,
            this.areaOfgroup,
            this.join_date,
            this.numberOfMembersInGroup});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.groups_gv.DefaultCellStyle = dataGridViewCellStyle8;
            this.groups_gv.EnableHeadersVisualStyles = false;
            this.groups_gv.Location = new System.Drawing.Point(99, 69);
            this.groups_gv.Name = "groups_gv";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groups_gv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.groups_gv.Size = new System.Drawing.Size(764, 215);
            this.groups_gv.TabIndex = 23;
            // 
            // NameOfGroup
            // 
            this.NameOfGroup.HeaderText = "group name ";
            this.NameOfGroup.Name = "NameOfGroup";
            this.NameOfGroup.Width = 220;
            // 
            // areaOfgroup
            // 
            this.areaOfgroup.HeaderText = "group field";
            this.areaOfgroup.Name = "areaOfgroup";
            this.areaOfgroup.Width = 150;
            // 
            // join_date
            // 
            this.join_date.HeaderText = "joining date";
            this.join_date.Name = "join_date";
            this.join_date.Width = 150;
            // 
            // numberOfMembersInGroup
            // 
            this.numberOfMembersInGroup.HeaderText = "number of friends in group";
            this.numberOfMembersInGroup.Name = "numberOfMembersInGroup";
            this.numberOfMembersInGroup.Width = 200;
            // 
            // search_panel
            // 
            this.search_panel.Controls.Add(this.label1);
            this.search_panel.Controls.Add(this.publishAds_btn);
            this.search_panel.Controls.Add(this.panel1);
            this.search_panel.Location = new System.Drawing.Point(0, 0);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(973, 519);
            this.search_panel.TabIndex = 4;
            // 
            // publishAds_btn
            // 
            this.publishAds_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.publishAds_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.publishAds_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.publishAds_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.publishAds_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.publishAds_btn.Location = new System.Drawing.Point(776, 430);
            this.publishAds_btn.Name = "publishAds_btn";
            this.publishAds_btn.Size = new System.Drawing.Size(165, 62);
            this.publishAds_btn.TabIndex = 37;
            this.publishAds_btn.Text = "Publish ad for selected group";
            this.publishAds_btn.UseVisualStyleBackColor = false;
            this.publishAds_btn.Click += new System.EventHandler(this.publishAds_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(23, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(811, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "To publish an ad for a group please select the relevant row and click the Publish" +
    " button.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShowUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.search_panel);
            this.Name = "ShowUserGroup";
            this.Size = new System.Drawing.Size(973, 519);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groups_gv)).EndInit();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.DataGridView groups_gv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaOfgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn join_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfMembersInGroup;
        private System.Windows.Forms.Button publishAds_btn;
        private System.Windows.Forms.Label label1;
    }
}
