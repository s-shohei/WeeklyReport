using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyReport.common;
using WeeklyReport.model;
using WeeklyReport.control;



namespace WeeklyReport.util
{
    class XmlLoadUtil
    {
        /// <summary>
        /// 前週の週報を読み込み
        /// </summary>
        public static void settingXmlLoad()
        {
            Xml read = new Xml();
           SettingTextModel st_text = read.setting_load();

            //読込んだ週報の改行を置換
            KaigyoControl re_st_text = new KaigyoControl(st_text);
        }

        /// <summary>
        /// 一時保存の内容を読み込み
        /// </summary>
        public static void saveXmlLoad()
        {
            Xml read = new Xml();
            SaveTextModel sv_text = read.text_load();

            //読込んだ週報の改行を置換
            KaigyoControl re_sv_text = new KaigyoControl(sv_text);
        }

    }
}
