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
using System.IO;

namespace WeeklyReport
{
    public partial class Form1 : Form
    {
        //インスタンス
        Xml read = new Xml();
        SettingTextModel st_text_model = new SettingTextModel();

        public Form1()
        {
            InitializeComponent();
        }

        //Form1をロード！
        public void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                // 日付の計算結果を取得
                DayModel day = DayUtil.getWeekDaysAddYoubi();

                // 設定ファイルのロード
                SettingTextModel st_text_model = read.setting_load();

                // 日付をセット
                SundayLabel.Text = day.dtSunday;
                MondayLabel.Text = day.dtMonday;
                TuesdayLabel.Text = day.dtTuesday;
                WednesdayLabel.Text = day.dtWednesday;
                ThursdayLabel.Text = day.dtThursday;
                FridayLabel.Text = day.dtFriday;
                SaturdayLabel.Text = day.dtSaturday;

                // 分コンボボックスの中身を入れる
                ConboUtil.setTime(this);

                // 稼動状況コンボボックスの中身を入れる
                ConboUtil.setKadou(this);

                // 一時保存の設定ファイルを読み込み
                SaveTextModel sv_text_model = read.text_load();

                // 有効範囲内の場合は、一時保存したテキストをセットする
                bool outputFlag = savetext_Yuko_Check(sv_text_model);

                if (outputFlag == true)
                {
                    lastWeekTextOutput(sv_text_model);
                }

                // 稼働時間を計算
                RunningTimeControl rtCtl = new RunningTimeControl(this);
                rtCtl.setRunnigTime();

                // 前週の週報ファイルの読み込み
                KaigyoControl re_st_text = new KaigyoControl(st_text_model);

                MondaiKaizen_Gyomu.Text = re_st_text.kaigyo_lastweek_mondai_gyomu();
                MondaiKaizen_Jiko.Text = re_st_text.kaigyo_lastweek_mondai_jiko();
                Result_Gyomu.Text = re_st_text.kaigyo_lastweek_result_gyomu();
                Result_Jiko.Text = re_st_text.kaigyo_lastweek_result_jiko();
            }
            catch(IOException iex)
            {
                MessageBox.Show("設定ファイルが開かれています。\r\n閉じてから起動してください。");
                Application.Exit();
            }
            catch(Exception ex)
            {
                MessageBox.Show("えまーじぇんしー(｢・ω・)｢ｶﾞｵｰ\r\n 新保さんまで連絡を。。。");
                Application.Exit();
            }
        }

        //テキスト出力ボタン押下
        private void textbotton_Click(object sender, EventArgs e)
        {
            try
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
            catch(IOException iex)
            {
                MessageBox.Show("週報ファイルが開かれています。\r\n閉じてください。");
            }
            catch(Exception ex)
            {
                MessageBox.Show("えまーじぇんしー(｢・ω・)｢ｶﾞｵｰ\r\n 新保さんまで連絡を。。。");
            }
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

        private void selectItemChange(object sender, EventArgs e)
        {
            // 稼働時間を計算
            RunningTimeControl rtCtl = new RunningTimeControl(this);
            rtCtl.setRunnigTime();
        }

        private void shortcutSave(object sender, KeyEventArgs e)
        {

        }

        //一時保存ファイルの日付有効チェック
        private bool savetext_Yuko_Check(SaveTextModel sv_text_model)
        {
            // 返却値
            bool outputFlag = false;

            // 土曜日を取得
            DayModel model = DayUtil.getWeekDays();

            // 有効範囲チェック
            // 前回保存日時が起動日の週の土曜より前の場合
            if (DateTime.Parse(sv_text_model.write) <= DateTime.Parse(model.dtSaturday))
            {
                // 一時保存分を表示するフラグを立てる
                outputFlag = true;
            }
            return outputFlag;
        }

        /// <summary>
        /// 一時保存分をオブジェクトにセットする
        /// </summary>
        /// <param name="sv_text_model"></param>
        private void lastWeekTextOutput(SaveTextModel sv_text_model)
        {
            KaigyoControl re_sv_text = new KaigyoControl(sv_text_model);

            StartHH1.Text = XmlLoadUtil.defaultValueCheck(StartHH1.Text, sv_text_model.sunday_start_hh);
            StartMM1.Text = XmlLoadUtil.defaultValueCheck(StartMM1.Text, sv_text_model.sunday_start_mm);
            EndHH1.Text = XmlLoadUtil.defaultValueCheck(EndHH1.Text, sv_text_model.sunday_end_hh);
            EndMM1.Text = XmlLoadUtil.defaultValueCheck(EndMM1.Text, sv_text_model.sunday_end_mm);
            Kadou1.Text = XmlLoadUtil.defaultValueCheck(Kadou1.Text, sv_text_model.sunday_kadou);
            work1.Text = XmlLoadUtil.defaultValueCheck(work1.Text, re_sv_text.kaigyo_sunday());

            StartHH2.Text = XmlLoadUtil.defaultValueCheck(StartHH2.Text, sv_text_model.monday_start_hh);
            StartMM2.Text = XmlLoadUtil.defaultValueCheck(StartMM2.Text, sv_text_model.monday_start_mm);
            EndHH2.Text = XmlLoadUtil.defaultValueCheck(EndHH2.Text, sv_text_model.monday_end_hh);
            EndMM2.Text = XmlLoadUtil.defaultValueCheck(EndMM2.Text, sv_text_model.monday_end_mm);
            Kadou2.Text = XmlLoadUtil.defaultValueCheck(Kadou2.Text, sv_text_model.monday_kadou);
            work2.Text = XmlLoadUtil.defaultValueCheck(work2.Text, re_sv_text.kaigyo_monday());

            StartHH3.Text = XmlLoadUtil.defaultValueCheck(StartHH3.Text, sv_text_model.tuesday_start_hh);
            StartMM3.Text = XmlLoadUtil.defaultValueCheck(StartMM3.Text, sv_text_model.tuesday_start_mm);
            EndHH3.Text = XmlLoadUtil.defaultValueCheck(EndHH3.Text, sv_text_model.tuesday_end_hh);
            EndMM3.Text = XmlLoadUtil.defaultValueCheck(EndMM3.Text, sv_text_model.tuesday_end_mm);
            Kadou3.Text = XmlLoadUtil.defaultValueCheck(Kadou3.Text, sv_text_model.tuesday_kadou);
            work3.Text = XmlLoadUtil.defaultValueCheck(work3.Text, re_sv_text.kaigyo_tuesday());

            StartHH4.Text = XmlLoadUtil.defaultValueCheck(StartHH4.Text, sv_text_model.wednesday_start_hh);
            StartMM4.Text = XmlLoadUtil.defaultValueCheck(StartMM4.Text, sv_text_model.wednesday_start_mm);
            EndHH4.Text = XmlLoadUtil.defaultValueCheck(EndHH4.Text, sv_text_model.wednesday_end_hh);
            EndMM4.Text = XmlLoadUtil.defaultValueCheck(EndMM4.Text, sv_text_model.wednesday_end_mm);
            Kadou4.Text = XmlLoadUtil.defaultValueCheck(Kadou4.Text, sv_text_model.wednesday_kadou);
            work4.Text = XmlLoadUtil.defaultValueCheck(work4.Text, re_sv_text.kaigyo_wednesday());

            StartHH5.Text = XmlLoadUtil.defaultValueCheck(StartHH5.Text, sv_text_model.thursday_start_hh);
            StartMM5.Text = XmlLoadUtil.defaultValueCheck(StartMM5.Text, sv_text_model.thursday_start_mm);
            EndHH5.Text = XmlLoadUtil.defaultValueCheck(EndHH5.Text, sv_text_model.thursday_end_hh);
            EndMM5.Text = XmlLoadUtil.defaultValueCheck(EndMM5.Text, sv_text_model.thursday_end_mm);
            Kadou5.Text = XmlLoadUtil.defaultValueCheck(Kadou5.Text, sv_text_model.thursday_kadou);
            work5.Text = XmlLoadUtil.defaultValueCheck(work5.Text, re_sv_text.kaigyo_thursday());

            StartHH6.Text = XmlLoadUtil.defaultValueCheck(StartHH6.Text, sv_text_model.friday_start_hh);
            StartMM6.Text = XmlLoadUtil.defaultValueCheck(StartMM6.Text, sv_text_model.friday_start_mm);
            EndHH6.Text = XmlLoadUtil.defaultValueCheck(EndHH6.Text, sv_text_model.friday_end_hh);
            EndMM6.Text = XmlLoadUtil.defaultValueCheck(EndMM6.Text, sv_text_model.friday_end_mm);
            Kadou6.Text = XmlLoadUtil.defaultValueCheck(Kadou6.Text, sv_text_model.friday_kadou);
            work6.Text = XmlLoadUtil.defaultValueCheck(work6.Text, re_sv_text.kaigyo_friday());

            StartHH7.Text = XmlLoadUtil.defaultValueCheck(StartHH7.Text, sv_text_model.saturday_start_hh);
            StartMM7.Text = XmlLoadUtil.defaultValueCheck(StartMM7.Text, sv_text_model.saturday_start_mm);
            EndHH7.Text = XmlLoadUtil.defaultValueCheck(EndHH7.Text, sv_text_model.saturday_end_hh);
            EndMM7.Text = XmlLoadUtil.defaultValueCheck(EndMM7.Text, sv_text_model.saturday_end_mm);
            Kadou7.Text = XmlLoadUtil.defaultValueCheck(Kadou7.Text, sv_text_model.saturday_kadou);
            work7.Text = XmlLoadUtil.defaultValueCheck(work7.Text, re_sv_text.kaigyo_saturday());

            MondaiKaizen_Gyomu.Text = XmlLoadUtil.defaultValueCheck(MondaiKaizen_Gyomu.Text, sv_text_model.mondaikaizen_gyomu);
            MondaiKaizen_Jiko.Text  = XmlLoadUtil.defaultValueCheck(MondaiKaizen_Jiko.Text, sv_text_model.mondaikaizen_jiko);

            Result_Gyomu.Text = XmlLoadUtil.defaultValueCheck(Result_Gyomu.Text, sv_text_model.result_gyomu);
            Result_Jiko.Text  = XmlLoadUtil.defaultValueCheck(Result_Jiko.Text, sv_text_model.result_jiko);

            Play.Text = XmlLoadUtil.defaultValueCheck(Play.Text, sv_text_model.saying_gyoumugai);
            business.Text = XmlLoadUtil.defaultValueCheck(business.Text, sv_text_model.saying_gyoumunai);
        }
    }
}
