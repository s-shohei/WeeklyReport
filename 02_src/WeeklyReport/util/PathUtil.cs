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
        public static string file_location()
        {
            string appPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "setting.xml";
            return appPath;
        }

        /// <summary>
        /// setting.xmlのフォルダパスを返す
        /// </summary>
        /// <returns></returns>
        public static string folder_location()
        {
            string appPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            return appPath;
        }
    }
}
