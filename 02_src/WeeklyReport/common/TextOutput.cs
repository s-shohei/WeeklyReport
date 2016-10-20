using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyReport.control;
using WeeklyReport.model;
using System.Windows.Forms;
using WeeklyReport.consts;
using WeeklyReport.common;
using WeeklyReport.util;

namespace WeeklyReport.common
{
    /// <summary>
    /// 体裁を整えて出力まで行うクラス
    /// </summary>
    public class TextOutput
    {
        // インスタンス変数
        StringBuilder sb = new StringBuilder();
        FormTextModel ft_model;
        SettingTextModel st_model;
        DayModel day;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TextOutput(FormTextModel model)
        {
            // モデルクラスを受け取る
            ft_model = model;
            day = DayUtil.getWeekDays();
        }

        /// <summary>
        /// 体裁を整える
        /// </summary>
        public void weeklyReportFormat()
        {
            this.createHeader();
            this.createBody();

        }

        /// <summary>
        /// ヘッダ部分を作成
        /// </summary>
        private void createHeader()
        {
            Xml read = new Xml();
            st_model = read.setting_load();

            sb.Append("=====================================================\r\n");
            sb.Append("【" + st_model.division + "】\r\n");
            sb.Append("プロジェクト名：" + st_model.project + "\r\n");
            sb.Append("所属ユニット  ：" + st_model.unit + "\r\n");
            sb.Append("報告者        ：" + st_model.name + "\r\n");
            sb.Append("報告期間      ：" + day.dtSunday.ToString().Substring(0, 10) + " ～ " + day.dtSaturday.ToString().Substring(0, 10) + "\r\n");
            sb.Append("=====================================================\r\n");
        }
        /// <summary>
        /// ボディ部分を作成
        /// </summary>
        private void createBody()
        {

            // TODO とてもカオスですね(ToT)/~~~なんとかしましょう。
            sb.Append("■作業内容\r\n");
            if (ft_model.kadou1 != KadouConst.dayoff)
            {
                sb.Append(day.dtSunday.ToString().Substring(0, 10) + "（日）" + "  " + ft_model.startHH1 + ":" + ft_model.startMM1 + "-" + ft_model.endHH1 + ":" + ft_model.endMM1 + "  " + ft_model.kadou1 + "\r\n");
                sb.Append(ft_model.work1 + "\r\n\r\n");
            }
            else
            {
                sb.Append(day.dtSunday.ToString().Substring(0, 10) + "（日）" + "  " + ft_model.kadou1 + "\r\n\r\n");
            }

            if (ft_model.kadou2 != KadouConst.dayoff)
            {
                sb.Append(day.dtMonday.ToString().Substring(0, 10) + "（月）" + "  " + ft_model.startHH2 + ":" + ft_model.startMM2 + "-" + ft_model.endHH2 + ":" + ft_model.endMM2 + "  " + ft_model.kadou2 + "\r\n");
                sb.Append(ft_model.work2 + "\r\n\r\n");
            }
            else
            {
                sb.Append(day.dtMonday.ToString().Substring(0, 10) + "（月）" + "  " + ft_model.kadou2 + "\r\n\r\n");
            }

            if (ft_model.kadou3 != KadouConst.dayoff)
            {
                sb.Append(day.dtTuesday.ToString().Substring(0, 10) + "（火）" + "  " + ft_model.startHH3 + ":" + ft_model.startMM3 + "-" + ft_model.endHH3 + ":" + ft_model.endMM3 + "  " + ft_model.kadou3 + "\r\n");
                sb.Append(ft_model.work3 + "\r\n\r\n");
            }
            else
            {
                sb.Append(day.dtTuesday.ToString().Substring(0, 10) + "（火）" + "  " + ft_model.kadou3 + "\r\n\r\n");
            }

            if (ft_model.kadou4 != KadouConst.dayoff)
            {
                sb.Append(day.dtWednesday.ToString().Substring(0, 10) + "（水）" + "  " + ft_model.startHH4 + ":" + ft_model.startMM4 + "-" + ft_model.endHH4 + ":" + ft_model.endMM4 + "  " + ft_model.kadou4 + "\r\n");
                sb.Append(ft_model.work4 + "\r\n\r\n");
            }
            else
            {
                sb.Append(day.dtWednesday.ToString().Substring(0, 10) + "（水）" + "  " + ft_model.kadou4 + "\r\n\r\n");
            }

            if (ft_model.kadou5 != KadouConst.dayoff)
            {
                sb.Append(day.dtThursday.ToString().Substring(0, 10) + "（木）" + "  " + ft_model.startHH5 + ":" + ft_model.startMM5 + "-" + ft_model.endHH5 + ":" + ft_model.endMM5 + "  " + ft_model.kadou5 + "\r\n");
                sb.Append(ft_model.work5 + "\r\n\r\n");
            }
            else
            {
                sb.Append(day.dtThursday.ToString().Substring(0, 10) + "（木）" + "  " + ft_model.kadou5 + "\r\n\r\n");
            }

            if (ft_model.kadou6 != KadouConst.dayoff)
            {
                sb.Append(day.dtFriday.ToString().Substring(0, 10) + "（金）" + "  " + ft_model.startHH6 + ":" + ft_model.startMM6 + "-" + ft_model.endHH6 + ":" + ft_model.endMM6 + "  " + ft_model.kadou6 + "\r\n");
                sb.Append(ft_model.work6 + "\r\n\r\n");
            }
            else
            {
                sb.Append(day.dtFriday.ToString().Substring(0, 10) + "（金）" + "  " + ft_model.kadou6 + "\r\n\r\n");
            }

            if (ft_model.kadou7 != KadouConst.dayoff)
            {
                sb.Append(day.dtSaturday.ToString().Substring(0, 10) + "（土）" + "  " + ft_model.startHH7 + ":" + ft_model.startMM7 + "-" + ft_model.endHH7 + ":" + ft_model.endMM7 + "  " + ft_model.kadou7 + "\r\n");
                sb.Append(ft_model.work7 + "\r\n\r\n");
            }
            else
            {
                sb.Append(day.dtSaturday.ToString().Substring(0, 10) + "（土）" + "  " + ft_model.kadou7 + "\r\n\r\n");
            }

            sb.Append("----------------------------------------------------\r\n");
            sb.Append("■問題点・改善案：\r\n");
            sb.Append(ft_model.mondaiKaizen_gyomu + "\r\n\r\n");
            sb.Append(ft_model.mondaiKaizen_jiko + "\r\n\r\n");
            sb.Append("----------------------------------------------------\r\n");
            sb.Append("■前週掲げた改善案の実施結果：\r\n");
            sb.Append(ft_model.result + "\r\n\r\n");
            sb.Append("----------------------------------------------------\r\n");
            sb.Append("■今週の言いたいこと：\r\n");
            sb.Append("<業務内>\r\n");
            sb.Append(ft_model.business + "\r\n\r\n");
            sb.Append("<業務外>\r\n");
            sb.Append(ft_model.play + "\r\n\r\n");

        }

        /// <summary>
        /// 内容をテキスト出力する
        /// </summary>
        public void textPrintOut()
        {
            //Shift JISで書き込む
            //書き込むファイルが既に存在している場合は、上書きする;
            System.IO.StreamWriter sw = new System.IO.StreamWriter(PathUtil.setting_folder_location() + createWeeklyReportFileName(), false, System.Text.Encoding.GetEncoding("shift_jis"));

            //Formに入力された内容をテキストに書き込む
            sw.Write(sb);

            //閉じる
            sw.Close();
        }

        /// <summary>
        /// 週報のファイル名を生成
        /// </summary>
        /// <returns>週報のファイル名</returns>
        private string createWeeklyReportFileName()
        {
            // 名前部分を生成
            // Ex.) 週報_新保華_
            string namePart = "週報_" + st_model.name.Replace("　", "") + "_";

            // 日付部分を生成
            // Ex.) 20160911～20160917
            string daysPart = day.dtSunday.ToString().Replace("/", "") + "～" + day.dtSaturday.ToString().Replace("/", "");

            // ファイルの拡張子
            string extentionPart = ".txt";

            // 結合
            string fileName = namePart + daysPart + extentionPart;

            return fileName;
        }
    }
}
