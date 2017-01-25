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
    partial class SearchPanel : UserControl
    {
        private DataGridView currentGrid;
        private MyController myControl;
        public SearchPanel(MyController m)
        {
            currentGrid = new DataGridView();
            myControl = m;
            InitializeComponent();
            city_comboBox.DataSource = myControl.GetCities();
            findMatcher_comboBox.DataSource = myControl.GetFields();
            restart();
        }
        
        public void search_btn_Click(object sender, EventArgs e)
        {
            restart();           
            string findMatcher = findMatcher_comboBox.SelectedItem.ToString();
            DataTable dt = myControl.SearchByFieldLocation(findMatcher, city_comboBox.SelectedItem.ToString());
            currentGrid = new DataGridView();
            switch (findMatcher)
            {
                case "Date":
                    currentGrid = date_gv;
                    break;
                case "Sport":
                    currentGrid = sport_gv;
                    break;
                case "Trip":
                    currentGrid = travel_gv;
                    break;
                case "Apartment":
                    currentGrid = apartment_gv;
                    break;
            }

            foreach (DataRow dr in dt.Rows)
            {
                currentGrid.Rows.Add(dr.ItemArray);
            }
            currentGrid.Visible = true;
            AdsNum_lbl.Text = "Total Ads : " + dt.Rows.Count.ToString();
            AdsNum_lbl.Visible = true;
            massageToUser_lbl.Visible = true;
        }

        public void restart()
        {
            date_gv.Rows.Clear();
            date_gv.Visible = false;
            apartment_gv.Rows.Clear();
            apartment_gv.Visible = false;
            travel_gv.Rows.Clear();
            travel_gv.Visible = false;
            sport_gv.Rows.Clear();
            sport_gv.Visible = false;
            AdsNum_lbl.Visible = false;
            massageToUser_lbl.Visible = false;
        }
            
        private void restart_btn_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            if(currentGrid.SelectedRows.Count > 1)
            {
                myControl.Output("Error", "choose only 1 group in each request");
            }
            else
            {
                foreach (DataGridViewRow row in currentGrid.SelectedRows)
                {
                    string groupName = row.Cells[0].Value.ToString();
                    string publishName = row.Cells[1].Value.ToString();
                    myControl.joinGroup(groupName, publishName);
                }
            }            
        }
    }
}
