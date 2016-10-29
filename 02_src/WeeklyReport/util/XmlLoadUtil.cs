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
        /// setting.xmlを読み込みモデルを返却
        /// </summary>
        public static SettingTextModel settingXmlLoad()
        {
            Xml read = new Xml();
            return read.setting_load();
        }

        // 一時保存のテキストが空の場合、デフォルトの値を設定
        public static string defaultValueCheck(string tagetString, string changeString)
        {
            string result = changeString;

            if(String.IsNullOrEmpty(changeString))
            {
                result = tagetString;
            }

            return result;
        }
    }
}
