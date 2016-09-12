using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyReport.model;

namespace WeeklyReport.common
{
    public class DayCal
    {

        public  DayCal()
        {

        }

        /// <summary>
        /// 日付取得
        /// </summary>
        /// <returns></returns>
        
        public DateTime getSysDateNow()
        {
            //現在の日付を取得する
            DateTime dtToday = DateTime.Today;
            return dtToday;
        }

        /// <summary>
        /// 現在の日付から週報の日付を計算する
        /// 週報は月曜始まり
        /// </summary>
        /// <returns></returns>
        /// s
        public DayModel getWeekSelect()
        {
            //1週間が日曜日から始まり、土曜日で終わる時
            //今週の最初の日
            DateTime dtSunday = getSysDateNow().AddDays(0 - (int)getSysDateNow().DayOfWeek);

            DateTime dtMonday = dtSunday.AddDays(1);
            DateTime dtTuesday = dtSunday.AddDays(2);
            DateTime dtWednesday = dtSunday.AddDays(3);
            DateTime dtThursday = dtSunday.AddDays(4);
            DateTime dtFriday = dtSunday.AddDays(5);
            DateTime dtSaturday = dtSunday.AddDays(6);

            DayModel model = new DayModel();

            model.setSunday(dtSunday);
            model.setMonday(dtMonday);
            model.setTuesday(dtTuesday);
            model.setWednesday(dtWednesday);
            model.setThursday(dtThursday);
            model.setFriday(dtFriday);
            model.setSaturday(dtSaturday);
            
            return model;




        }

       


    }


}

