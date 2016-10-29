using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyReport.util
{
    public static class RunningTimeUtil
    {

        public static string runningTimeCal(DateTime startTime, DateTime endTime)
        {
            // 返却値
            string result = "";

            TimeSpan runnintTime = endTime - startTime;

            result = runnintTime.ToString();

            if (runnintTime.TotalMinutes < 0)
            {
                result = "時刻入力値が不正(｀･ω･´)ゞ";
            }

            return result;
        }

        /// <summary>
        /// 時刻と分を受取、：と00をつけてDatetimeにパースしたものを返却
        /// 「09」と「00」→「起動日の年月 + 09:00:00」
        /// </summary>
        /// <param name="st_HH"></param>
        /// <param name="st_MM"></param>
        /// <returns></returns>
        public static DateTime parseDatetime(string st_HH, string st_MM)
        {
            return DateTime.Parse(st_HH + ":" + st_MM + ":" + "00");
        }

        /// <summary>
        /// hhを受取、：と00をつけてDatetimeにパースしたものを返却
        /// 「9」→「起動日の年月 + 09:00:00」
        /// 稼働状況のオート判定用
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime parseDatetimeOfKadou(string value)
        {
            return DateTime.Parse(value + ":00:00");
        }
    }
}
