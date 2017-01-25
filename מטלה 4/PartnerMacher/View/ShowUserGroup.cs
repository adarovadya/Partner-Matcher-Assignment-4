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
     partial class ShowUserGroup : UserControl
    {
        private DataGridView currentGrid;
        private MyController myControl;

        public ShowUserGroup(MyController m)
        {
            currentGrid = new DataGridView();
            myControl = m;
            InitializeComponent();
            Show_btn_Click();
        }

        public void Show_btn_Click()
        {
            DataTable dt = myControl.ShowUserGroups();
            DataGridView currentGrid = new DataGridView();
            currentGrid = groups_gv;
            groups_gv.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                currentGrid.Rows.Add(dr.ItemArray);
            }
            visiblePanel(true);           
        }

        private void publishAds_btn_Click(object sender, EventArgs e)
        {
            string fieldGroup = "";
            string groupName = "";
            if (groups_gv.SelectedRows.Count == 0)
            {
                myControl.Output("Wrong", "Please select all row");
                return;
            }
            if (groups_gv.SelectedRows.Count > 1)
            {
                myControl.Output("Error", "choose only 1 group in each publish");
            }
            else
            {
                foreach (DataGridViewRow row in groups_gv.SelectedRows)
                {
                    fieldGroup = row.Cells[1].Value.ToString();
                    groupName = row.Cells[0].Value.ToString();
                }
                switch (fieldGroup.ToLower())
                {
                    case "sport":
                        visiblePanel(false);
                        panel1.Controls.Add(new SportAdsDetails(myControl, groupName));
                        break;
                    case "date":
                        visiblePanel(false);
                        panel1.Controls.Add(new DateAdsDetails(myControl, groupName));
                        break;
                    case "travel":
                        visiblePanel(false);
                        panel1.Controls.Add(new TravelAdsDetails(myControl, groupName));
                        break;
                    case "apartment":
                        visiblePanel(false);
                        panel1.Controls.Add(new ApartmentAdsDetail(myControl, groupName));
                        break;
                }
            }
        }

        private void visiblePanel(bool visible)
        {
            groups_gv.Visible = visible;
            publishAds_btn.Visible = visible;
        }
    }
}
