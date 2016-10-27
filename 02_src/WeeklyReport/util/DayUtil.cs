using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyReport.model;
using WeeklyReport.common;

namespace WeeklyReport.util
{
    public static class DayUtil
    {
        /// <summary>
        /// 起動日より一週間の日付を計算
        /// </summary>
        /// <returns>一週間の日付が入ったモデルクラス</returns>
        public static DayModel getWeekDays()
        {
            //今日日付の取得
            DateTime dtToday = DateTime.Today;

            //今日日付を数値化（0~6）し、日曜日付【0】からマイナスする
            DateTime dtSunday = dtToday.AddDays(0 - (int)dtToday.DayOfWeek);

            DayModel dayModel = new DayModel();

            dayModel.dtSunday = dtSunday.AddDays(0).ToString().Substring(0, 10);
            dayModel.dtMonday = dtSunday.AddDays(1).ToString().Substring(0, 10);
            dayModel.dtTuesday = dtSunday.AddDays(2).ToString().Substring(0, 10);
            dayModel.dtWednesday = dtSunday.AddDays(3).ToString().Substring(0, 10);
            dayModel.dtThursday = dtSunday.AddDays(4).ToString().Substring(0, 10);
            dayModel.dtFriday = dtSunday.AddDays(5).ToString().Substring(0, 10);
            dayModel.dtSaturday = dtSunday.AddDays(6).ToString().Substring(0, 10);

            return dayModel;
        }
    }
}
