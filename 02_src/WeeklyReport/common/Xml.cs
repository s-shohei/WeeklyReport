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
    public class Xml
    {
        /// <summary>
        //setting.xml読込み
        /// <summary>
        public SettingTextModel setting_load()
        {
            System.IO.FileStream fs = new System.IO.FileStream(PathUtil.setting_file_location(), System.IO.FileMode.Open);

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(WeeklyReport.model.SettingTextModel));

            WeeklyReport.model.SettingTextModel model = (WeeklyReport.model.SettingTextModel)serializer.Deserialize(fs);

            fs.Close();

            return model;
        }

        /// <summary>
        /// setting.xml書き込み
        /// </summary>
        public void setting_write(Form1 f)
        {
            // インスタンス変数
            SettingTextModel model = new SettingTextModel();

            model = setting_load();
            model.lastweek_mondai_gyomu = f.MondaiKaizen_Gyomu.Text;
            model.lastweek_mondai_jiko  = f.MondaiKaizen_Jiko.Text;
            model.lastweek_result_gyomu = f.Result_Gyomu.Text;
            model.lastweek_result_jiko  = f.Result_Jiko.Text;


            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(WeeklyReport.model.SettingTextModel));

            System.IO.StreamWriter sw = new System.IO.StreamWriter(PathUtil.setting_file_location(), false, new System.Text.UTF8Encoding(false));

            //シリアル化し、XMLファイルに保存する
            serializer.Serialize(sw, model);

            //ファイルを閉じる

            sw.Close();
        }

        /// <summary>
        ///save_text.xmlの読み込み
        /// <summary>
        public SaveTextModel text_load()
        {
            System.IO.FileStream fs = new System.IO.FileStream(PathUtil.save_text_file_location(), System.IO.FileMode.Open);

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(WeeklyReport.model.SaveTextModel));

            WeeklyReport.model.SaveTextModel model = (WeeklyReport.model.SaveTextModel)serializer.Deserialize(fs);

            fs.Close();

            return model;
        }

        /// <summary>
        /// save_text.xml書き込み
        /// </summary>
        public void text_write(Form1 f)
        {
            // インスタンス変数
            SaveTextModel model = new SaveTextModel();

            model = text_load();

            //ファイル更新日付取得、保持
            model.write = DateTime.Today.ToString().Substring(0, 10);

            //日曜の内容を保持
            model.sunday          = f.work1.Text;
            model.sunday_start_hh = f.StartHH1.Text;
            model.sunday_start_mm = f.StartMM1.Text;
            model.sunday_end_hh   = f.EndHH1.Text;
            model.sunday_end_mm   = f.EndMM1.Text;
            model.sunday_kadou    = f.Kadou1.Text;

            //月曜の内容を保持
            model.monday          = f.work2.Text;
            model.monday_start_hh = f.StartHH2.Text;
            model.monday_start_mm = f.StartMM2.Text;
            model.monday_end_hh   = f.EndHH2.Text;
            model.monday_end_mm   = f.EndMM2.Text;
            model.monday_kadou    = f.Kadou2.Text;

            //火曜の内容を保持
            model.tuesday          = f.work3.Text;
            model.tuesday_start_hh = f.StartHH3.Text;
            model.tuesday_start_mm = f.StartMM3.Text;
            model.tuesday_end_hh   = f.EndHH3.Text;
            model.tuesday_end_mm   = f.EndMM3.Text;
            model.tuesday_kadou    = f.Kadou3.Text;

            //水曜の内容を保持
            model.wednesday          = f.work4.Text;
            model.wednesday_start_hh = f.StartHH4.Text;
            model.wednesday_start_mm = f.StartMM4.Text;
            model.wednesday_end_hh   = f.EndHH4.Text;
            model.wednesday_end_mm   = f.EndMM4.Text;
            model.wednesday_kadou    = f.Kadou4.Text;

            //木曜の内容を保持
            model.thursday          = f.work5.Text;
            model.thursday_start_hh = f.StartHH5.Text;
            model.thursday_start_mm = f.StartMM5.Text;
            model.thursday_end_hh   = f.EndHH5.Text;
            model.thursday_end_mm   = f.EndMM5.Text;
            model.thursday_kadou    = f.Kadou5.Text;

            //金曜の内容を保持
            model.friday          = f.work6.Text;
            model.friday_start_hh = f.StartHH6.Text;
            model.friday_start_mm = f.StartMM6.Text;
            model.friday_end_hh   = f.EndHH6.Text;
            model.friday_end_mm   = f.EndMM6.Text;
            model.friday_kadou    = f.Kadou6.Text;

            //土曜の内容を保持
            model.saturday          = f.work7.Text;
            model.saturday_start_hh = f.StartHH7.Text;
            model.saturday_start_mm = f.StartMM7.Text;
            model.saturday_end_hh   = f.EndHH7.Text;
            model.saturday_end_mm   = f.EndMM7.Text;
            model.saturday_kadou    = f.Kadou7.Text;

            // 今週の問題改善を保持
            model.mondaikaizen_gyomu = f.MondaiKaizen_Gyomu.Text;
            model.mondaikaizen_jiko = f.MondaiKaizen_Jiko.Text;

            // 今週の問題改善結果を保持
            model.result_gyomu = f.Result_Gyomu.Text;
            model.result_jiko = f.Result_Jiko.Text;

            // 今週の言いたいことを保持
            model.saying_gyoumugai = f.Play.Text;
            model.saying_gyoumunai = f.business.Text;
            
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(WeeklyReport.model.SaveTextModel));

            System.IO.StreamWriter sw = new System.IO.StreamWriter(PathUtil.save_text_file_location(), false, new System.Text.UTF8Encoding(false));

            //シリアル化し、XMLファイルに保存する
            serializer.Serialize(sw, model);

            //ファイルを閉じる

            sw.Close();
        }
    }
}
