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
        SettingTextModel st_model = new SettingTextModel();
        SaveTextModel sv_model = new SaveTextModel();


        //setting.xmlコンストラクタ
        public KaigyoControl (SettingTextModel model)
        {
            // モデルクラスを受け取る
            st_model = model;
        }

        //save_text.xmlコンストラクタ
        public KaigyoControl(SaveTextModel model)
        {
            // モデルクラスを受け取る
            sv_model = model;
        }

        public String kaigyo_sunday()
        {
            return kaigyoReplace(sv_model.sunday);
        }

        public String kaigyo_monday()
        {
            return kaigyoReplace(sv_model.monday);
        }

        public String kaigyo_tuesday()
        {
            return kaigyoReplace(sv_model.tuesday);
        }

        public String kaigyo_wednesday()
        {
            return kaigyoReplace(sv_model.wednesday);
        }

        public String kaigyo_thursday()
        {
            return kaigyoReplace(sv_model.thursday);
        }

        public String kaigyo_friday()
        {
            return kaigyoReplace(sv_model.friday);
        }

        public String kaigyo_saturday()
        {
            return kaigyoReplace(sv_model.saturday);
        }

        public String kaigyo_lastweek_mondai_gyomu()
        {
            return kaigyoReplace(st_model.lastweek_mondai_gyomu);
        }

        public String kaigyo_lastweek_mondai_jiko()
        {
            return kaigyoReplace(st_model.lastweek_mondai_jiko);
        }

        public String kaigyo_lastweek_result()
        {
            return kaigyoReplace(st_model.lastweek_result);
        }

        //改行メソッド
        public String kaigyoReplace(string setting_Text)
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
