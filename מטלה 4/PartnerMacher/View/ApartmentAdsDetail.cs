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
    partial class ApartmentAdsDetail : UserControl
    {
        MyController myController;
        string m_groupName;
        public ApartmentAdsDetail(MyController myControl, string groupName)
        {
            myController = myControl;
            m_groupName = groupName;
            InitializeComponent();
        }

        private void publishApartmentAds_btn_Click(object sender, EventArgs e)
        {
            DateTime check;
            if (DateTime.TryParse(Expiration_dateTime.Text, out check) && check <= DateTime.Now)
            {
                myController.Output("Error", "past date");
                return;
            }
            string expirationDate = Expiration_dateTime.Value.ToString("d");
            myController.publishApartment(m_groupName, expirationDate, content_textBox.Text, city_txtbox.Text, street_textBox.Text,
                minAge_textBox.Text, maxAge_textBox.Text, jionMonth_comboBox.SelectedItem.ToString(), language_textBox.Text, 
                currentRoomates_textBox.Text, roomates_textBox.Text, contractLength_textBox.Text,
                furniture_checkBox.Checked);
        }
    }
}
