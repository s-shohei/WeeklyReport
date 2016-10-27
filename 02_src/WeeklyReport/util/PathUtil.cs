using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyReport.util
{
    public static class PathUtil
    {
        // setting.xmlのファイルパスを返す
        public static string setting_file_location()
        {
            string appPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "setting.xml";
            return appPath;
        }

        /// <summary>
        /// setting.xmlのフォルダパスを返す
        /// </summary>
        /// <returns></returns>
        public static string setting_folder_location()
        {
            string appPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            return appPath;
        }

        // save_text.xmlのファイルパスを返す
        public static string save_text_file_location()
        {
            string appPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "save_text.xml";
            return appPath;
        }

        /// <summary>
        /// save_text.xmlのフォルダパスを返す
        /// </summary>
        /// <returns></returns>
        public static string save_text_folder_location()
        {
            string appPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            return appPath;
        }
    }
}
