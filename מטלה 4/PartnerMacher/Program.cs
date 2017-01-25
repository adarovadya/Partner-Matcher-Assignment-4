using PartnerMacher.Controller;
using PartnerMacher.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartnerMacher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyController control = new MyController();
            MyModel model = new MyModel(control);
            control.SetModel(model);
            MainForm main = new MainForm(control);
            control.SetView(main);
            control.initiate();
            Application.Run(main);
        }
    }
}
