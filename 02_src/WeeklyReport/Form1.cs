﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeklyReport.common;
using WeeklyReport.model;
using WeeklyReport.consts;
using WeeklyReport.control;

namespace WeeklyReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

      

        //Form1をロード！
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO 日付取得のロジック（クラス）はUtilクラスにしたほうがいいのではないだろうか。

            //日付インスタンスnewする！
            DayCal hiduke = new DayCal();
            //日付の計算してdayに代入！
            DayModel day =  hiduke.getWeekSelect();


            // TODO 一時変数(sundayとかmondayなど)に一旦入れいている意味は何でしょうか。

            DateTime sunday = DateTime.Parse(day.dtSunday);
            DateTime monday = DateTime.Parse(day.dtMonday);
            DateTime tuesday = DateTime.Parse(day.dtTuesday);
            DateTime wednesday = DateTime.Parse(day.dtWednesday);
            DateTime thursday = DateTime.Parse(day.dtThursday);
            DateTime friday = DateTime.Parse(day.dtFriday);
            DateTime saturday = DateTime.Parse(day.dtSaturday);

            //ラベルに代入していく！
            SundayLabel.Text = sunday.ToString().Substring(0,10) + "　（日）";
            MondayLabel.Text = monday.ToString().Substring(0, 10) + "　（月）";
            TuesdayLabel.Text = tuesday.ToString().Substring(0, 10) + "　（火）";
            WednesdayLabel.Text = wednesday.ToString().Substring(0, 10) + "　（水）";
            ThursdayLabel.Text = thursday.ToString().Substring(0, 10) + "　（木）";
            FridayLabel.Text = friday.ToString().Substring(0, 10) + "　（金）";
            SaturdayLabel.Text = saturday.ToString().Substring(0, 10) + "　（土）";


            // TODO ここもコンボボックスを扱うUtilクラスを作ってみてはどうだろうか。

            //分コンボボックスの中身を入れる
            TimeCnbControl time = new TimeCnbControl(this);

            time.setTime();

            // TODO ここもコンボボックスを扱うUtilクラスを作ってみてはどうだろうか。

            // 稼動状況コンボボックスの中身を入れる
            KadouCnbControl kadou = new KadouCnbControl(this);

            kadou.setKadou();

            // TODO ここもXMLを扱うUtilクラスを作ってみてはどうだろうか。
            // インスタンスを他のクラス含め、多数作るのはよろしくない。

            //前週の週報を読込む
            SettingXml read = new SettingXml();
            SettingTextModel st_text = read.load();

            //読込んだ週報の改行を置換し、フォームにセット
            KaigyoControl re_text = new KaigyoControl(st_text);

            MondaiKaizen.Text = re_text.kaigyo_lastweek_mondai();
            Result.Text = re_text.kaigyo_lastweek_result();
        }

        //テキスト出力ボタン押下
        private void textbotton_Click(object sender, EventArgs e)
        {

            // 入力値をモデルにセット
            InputValueContorol input = new InputValueContorol(this);
            FormTextModel model = input.getFormText();

            // 体裁を整える
            TextOutput o = new TextOutput(model);
            o.teisai();
            o.textPrintOut();

            //setting.xmlに書き出す
            SettingXml w = new SettingXml();
            w.write(this);

            MessageBox.Show("テキスト出力が完了しました。");

        }

        private void savebotton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Be Continue!");
        }
    }
}
