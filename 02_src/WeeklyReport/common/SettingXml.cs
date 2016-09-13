using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyReport.common;
using WeeklyReport.model;
using System.Xml;

namespace WeeklyReport.common
{
    //setting.xmlを扱うクラス
    public class SettingXml
    {

        //setting.xml読込み
        public SettingTextModel load()
        {
            System.IO.FileStream fs = new System.IO.FileStream(location(), System.IO.FileMode.Open);

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(WeeklyReport.model.SettingTextModel));

            WeeklyReport.model.SettingTextModel model = (WeeklyReport.model.SettingTextModel)serializer.Deserialize(fs);

            fs.Close();

            return model;
        }

        /// <summary>
        /// setting.xml書き込み
        /// </summary>
        public void write(Form1 f)
        {
            // インスタンス変数
            SettingTextModel model = new SettingTextModel();

            model = load();
            model.lastweek_mondai = f.MondaiKaizen.Text;
            model.lastweek_result = f.Result.Text;

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(WeeklyReport.model.SettingTextModel));

            System.IO.StreamWriter sw = new System.IO.StreamWriter(location(), false, new System.Text.UTF8Encoding(false));

            //シリアル化し、XMLファイルに保存する
            serializer.Serialize(sw, model);

            //ファイルを閉じる

            sw.Close();

        }


        // TODO このような他のクラスでも使用できそうな（使用しそうな）メソッドはUtilクラスにするのもありかも
        /// <summary>
        /// setting.xmlファイルパスを返す
        /// </summary>
        public string location()
        {
            string appPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "setting.xml";
            return appPath;
        }

    }
}
