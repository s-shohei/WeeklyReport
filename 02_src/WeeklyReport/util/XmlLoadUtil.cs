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

            //読込んだ週報の改行を置換し、フォームにセット
            KaigyoControl re_text = new KaigyoControl(st_text);
        }

        /// <summary>
        /// 一時保存の内容を読み込み
        /// </summary>
        public static void saveXmlLoad()
        {

            //読み込んだxmlのタイトルを抽出して、週報記述期間内だった場合、読み込む

            //if (weekend < dtToday.AddDays(-7))
            //{
            //    XmlLoad.saveXmlLoad();
            //}
            Xml read = new Xml();
            SaveTextModel sv_text = read.text_load();

            //読込んだ週報の改行を置換し、フォームにセット
            KaigyoControl re_text = new KaigyoControl(sv_text);
        }

    }
}
