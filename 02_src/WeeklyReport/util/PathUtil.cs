using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyReport.util
{
    public static class PathUtil
    {
        // TODO ★このような他のクラスでも使用できそうな（使用しそうな）メソッドはUtilクラスにするのもありかも
        // setting.xmlのファイルパスを返す
        public static string file_location()
        {
            string appPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "setting.xml";
            return appPath;
        }

        // TODO ★なにのフォルダパスを返すのか？
        // これも今後共通して使用できそうなのでUtilクラスにしましょうか。

        // setting.xmlのフォルダパスを返す
        public static string folder_location()
        {
            string appPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            return appPath;
        }




    }
}
