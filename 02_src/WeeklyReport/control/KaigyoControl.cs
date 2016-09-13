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
    public class KaigyoControl
    {

        // インスタンス変数
        SettingTextModel st_model;

        //コンストラクタ
        public KaigyoControl (SettingTextModel model)
        {
            // モデルクラスを受け取る
            st_model = model;
        }

      
        public String kaigyo_lastweek_mondai()
        {
            return kaigyoRePlace(st_model.lastweek_mondai);
        }

        public String kaigyo_lastweek_result()
        {
            return kaigyoRePlace(st_model.lastweek_result);
        }



        public String kaigyoRePlace(string setting_Text)
        {
            //改行コードで区切る
            string[] new_text = setting_Text.Split('\n');

            StringBuilder sb = new StringBuilder();
            foreach (string item in new_text)
            {
                sb.Append(item + "\r\n");
            }

            return sb.ToString();
            
        }

    }
    
}
