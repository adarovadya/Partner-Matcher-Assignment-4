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
    partial class TravelAdsDetails : UserControl
    {
        MyController myController;
        string m_groupName;
        public TravelAdsDetails(MyController myControl, string groupName)
        {
            myController = myControl;
            m_groupName = groupName;
            InitializeComponent();
        }

        private void publishTravel_btn_Click(object sender, EventArgs e)
        {
            DateTime check1;
            DateTime check2;
            if (DateTime.TryParse(dateTimePicker.Text, out check1) && check1 < DateTime.Now |
                DateTime.TryParse(Expiration_dateTime.Text, out check2) && check2 <= DateTime.Now)
            {
                myController.Output("Error", "past date");
                return;
            }
            string date = dateTimePicker.Value.ToString("d");
            string expirationDate = Expiration_dateTime.Value.ToString("d");
            myController.publishTravel(m_groupName, expirationDate, content_textBox.Text, destination_textBox.Text, wantedSex_txtbox.Text,
                minAge_textBox.Text, maxAge_textBox.Text, date, flexibility_textBox.Text, religion_comboBox.SelectedItem.ToString(),
                veggie_checkBox.Checked, education_comboBox.SelectedItem.ToString(), language_textBox.Text,
                approxLength_textBox.Text, Location_txtbox.Text);
        }
    }
}
