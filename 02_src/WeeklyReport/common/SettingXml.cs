using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyReport.common;
using WeeklyReport.model;
using System.Xml;
using WeeklyReport.util;


namespace WeeklyReport.common
{
    //setting.xmlを扱うクラス
    public class SettingXml
    {

        //setting.xml読込み
        public SettingTextModel load()
        {
            System.IO.FileStream fs = new System.IO.FileStream(PathUtil.file_location(), System.IO.FileMode.Open);

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
            model.lastweek_mondai_gyomu = f.MondaiKaizen_Gyomu.Text;
            model.lastweek_mondai_jiko = f.MondaiKaizen_Jiko.Text;
            model.lastweek_result = f.Result.Text;

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(WeeklyReport.model.SettingTextModel));

            System.IO.StreamWriter sw = new System.IO.StreamWriter(PathUtil.file_location(), false, new System.Text.UTF8Encoding(false));

            //シリアル化し、XMLファイルに保存する
            serializer.Serialize(sw, model);

            //ファイルを閉じる

            sw.Close();

        }
    }
}
