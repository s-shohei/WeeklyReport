using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyReport.model;
using System.Windows.Forms;
using System.IO;

namespace WeeklyReport.control
{
    class KaigyoControl
    {

        public SettingTextModel getSettingText()
        {
            SettingTextModel text = new SettingTextModel();

            string s1 = text.lastweek_mondai;
            s1 = s1.Replace(Environment.NewLine, "\r");
            s1 = s1.Trim('\r');
            string[] s2 = s1.Split('\r');
            
            return text;

        }



    }
        
 
}