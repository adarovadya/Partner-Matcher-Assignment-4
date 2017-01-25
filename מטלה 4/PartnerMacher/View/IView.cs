using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerMacher.View
{
    interface IView
    {
        void Output(string title, string output);
        void returnLogin();
    }
}
