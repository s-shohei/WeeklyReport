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
            return sv_KaigyoRePlace(sv_model.sunday);
        }

        public String kaigyo_monday()
        {
            return sv_KaigyoRePlace(sv_model.monday);
        }

        public String kaigyo_tuesday()
        {
            return sv_KaigyoRePlace(sv_model.tuesday);
        }

        public String kaigyo_wednesday()
        {
            return sv_KaigyoRePlace(sv_model.wednesday);
        }

        public String kaigyo_thursday()
        {
            return sv_KaigyoRePlace(sv_model.thursday);
        }

        public String kaigyo_friday()
        {
            return sv_KaigyoRePlace(sv_model.friday);
        }

        public String kaigyo_saturday()
        {
            return sv_KaigyoRePlace(sv_model.saturday);
        }

        public String kaigyo_lastweek_mondai_gyomu()
        {
            return st_KaigyoRePlace(st_model.lastweek_mondai_gyomu);
        }

        public String kaigyo_lastweek_mondai_jiko()
        {
            return st_KaigyoRePlace(st_model.lastweek_mondai_jiko);
        }

        public String kaigyo_lastweek_result()
        {
            return st_KaigyoRePlace(st_model.lastweek_result);
        }

        //改行メソッド
        public String st_KaigyoRePlace(string setting_Text)
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

        public String sv_KaigyoRePlace(string save_Text)
        {
            //改行コードで区切る
            string[] new_text = save_Text.Split('\n');

            StringBuilder sb = new StringBuilder();
            foreach (string item in new_text)
            {
                sb.Append(item + "\r\n");
            }

            return sb.ToString();

        }

    }
    
}
