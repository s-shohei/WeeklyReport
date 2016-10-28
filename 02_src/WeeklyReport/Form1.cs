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
        //インスタンス
        Xml read = new Xml();
        SettingTextModel st_text = new SettingTextModel();
        SaveTextModel sv_text    = new SaveTextModel();

        //日付計算結果を取得
        DayModel day = DayUtil.getWeekDays();

        public Form1()
        {
            InitializeComponent();
        }

        //Form1をロード！
        public void Form1_Load(object sender, EventArgs e)
        {

            //コンストラクタ
            SettingTextModel st_text = read.setting_load();

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

            //一時保存の設定ファイルを読み込み
            savetext_Yuko_Check();

            //前週の週報ファイルの読み込み
            KaigyoControl re_st_text = new KaigyoControl(st_text);

            MondaiKaizen_Gyomu.Text = re_st_text.kaigyo_lastweek_mondai_gyomu();
            MondaiKaizen_Jiko.Text = re_st_text.kaigyo_lastweek_mondai_jiko();
            Result.Text = re_st_text.kaigyo_lastweek_result();
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

        //一時保存ボタン押下
        private void savebotton_Click(object sender, EventArgs e)
        {
            // 入力値をモデルにセット
            InputValueContorol input = new InputValueContorol(this);
            FormTextModel model = input.getFormText();

            //save_text.xml、setting.xmlに書き出す
            Xml w = new Xml();
            w.text_write(this);
            w.setting_write(this);

            MessageBox.Show("保存しました。");
        }

        //一時保存ファイルの日付有効チェック
        private void savetext_Yuko_Check()
        {
            SaveTextModel sv_text = read.text_load();

            if (DateTime.Parse(sv_text.write) < DateTime.Parse(day.dtSaturday))
            {
                KaigyoControl re_sv_text = new KaigyoControl(sv_text);

                StartHH1.Text = sv_text.sunday_start_hh;
                StartMM1.Text = sv_text.sunday_start_mm;
                EndHH1.Text   = sv_text.sunday_end_hh;
                EndMM1.Text   = sv_text.sunday_end_mm;
                Kadou1.Text   = sv_text.sunday_kadou;
                work1.Text    = re_sv_text.kaigyo_sunday();

                StartHH2.Text = sv_text.monday_start_hh;
                StartMM2.Text = sv_text.monday_start_mm;
                EndHH2.Text   = sv_text.monday_end_hh;
                EndMM2.Text   = sv_text.monday_end_mm;
                Kadou2.Text   = sv_text.monday_kadou;
                work2.Text    = re_sv_text.kaigyo_monday();

                StartHH3.Text = sv_text.tuesday_start_hh;
                StartMM3.Text = sv_text.tuesday_start_mm;
                EndHH3.Text   = sv_text.tuesday_end_hh;
                EndMM3.Text   = sv_text.tuesday_end_mm;
                Kadou3.Text   = sv_text.tuesday_kadou;
                work3.Text    = re_sv_text.kaigyo_tuesday();

                StartHH4.Text = sv_text.wednesday_start_hh;
                StartMM4.Text = sv_text.wednesday_start_mm;
                EndHH4.Text   = sv_text.wednesday_end_hh;
                EndMM4.Text   = sv_text.wednesday_end_mm;
                Kadou4.Text   = sv_text.wednesday_kadou;
                work4.Text    = re_sv_text.kaigyo_wednesday();

                StartHH5.Text = sv_text.thursday_start_hh;
                StartMM5.Text = sv_text.thursday_start_mm;
                EndHH5.Text   = sv_text.thursday_end_hh;
                EndMM5.Text   = sv_text.thursday_end_mm;
                Kadou5.Text   = sv_text.thursday_kadou;
                work5.Text    = re_sv_text.kaigyo_thursday();

                StartHH6.Text = sv_text.friday_start_hh;
                StartMM6.Text = sv_text.friday_start_mm;
                EndHH6.Text   = sv_text.friday_end_hh;
                EndMM6.Text   = sv_text.friday_end_mm;
                Kadou6.Text   = sv_text.friday_kadou;
                work6.Text    = re_sv_text.kaigyo_friday();

                StartHH7.Text = sv_text.saturday_start_hh;
                StartMM7.Text = sv_text.saturday_start_mm;
                EndHH7.Text   = sv_text.saturday_end_hh;
                EndMM7.Text   = sv_text.saturday_end_mm;
                Kadou7.Text   = sv_text.saturday_kadou;
                work7.Text    = re_sv_text.kaigyo_saturday();
            }
        }
    }
}
