using System;
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
using WeeklyReport.util;


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

            //日付計算結果を取得
            DayModel day = DayUtil.getWeekDays();

            //ラベルに代入
            SundayLabel.Text = day.dtSunday + "　（日）";
            MondayLabel.Text = day.dtMonday + "　（月）";
            TuesdayLabel.Text = day.dtTuesday + "　（火）";
            WednesdayLabel.Text = day.dtWednesday + "　（水）";
            ThursdayLabel.Text = day.dtThursday + "　（木）";
            FridayLabel.Text = day.dtFriday + "　（金）";
            SaturdayLabel.Text = day.dtSaturday + "　（土）";

            //分コンボボックスの中身を入れる
            ConboUtil.setTime(this);

            // 稼動状況コンボボックスの中身を入れる
            ConboUtil.setKadou(this);

            // ★TODO ここもXMLを扱うUtilクラスを作ってみてはどうだろうか。

            //一時保存の設定ファイルの読み込み





            MondaiKaizen_Gyomu.Text = re_text.kaigyo_lastweek_mondai_gyomu();
            MondaiKaizen_Jiko.Text = re_text.kaigyo_lastweek_mondai_jiko();
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
            o.weeklyReportFormat();
            o.textPrintOut();

            //setting.xmlに書き出す
            Xml w = new Xml();
            w.setting_write(this);

            MessageBox.Show("テキスト出力が完了しました。");

        }

        private void savebotton_Click(object sender, EventArgs e)
        {
            // 入力値をモデルにセット
            InputValueContorol input = new InputValueContorol(this);
            FormTextModel model = input.getFormText();

            //setting.xmlに書き出す
            Xml w = new Xml();
            w.text_write(this);

            MessageBox.Show("一次保存しました。");
        }

    }

}
