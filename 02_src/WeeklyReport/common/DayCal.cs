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
        /// 今日日付の取得
        /// </summary>
        // TODO このメソッドいるかな？

        public DateTime getSysDateNow()
        {
            //今日日付を取得する
            DateTime dtToday = DateTime.Today;
            return dtToday;
        }

        /// <summary>
        /// 取得した日付から週報の日付を計算する（※週報は日曜はじまり）
        /// </summary>
        /// <returns></returns>
        // TODO メソッド名「getWeekDays」のほうが一週間の日付を取るってわかりやすくないかな？

        public DayModel getWeekSelect()
        {
            //今日日付を数値化（0~6）し、日曜日付【0】からマイナスする
            DateTime dtSunday = getSysDateNow().AddDays(0 - (int)getSysDateNow().DayOfWeek);



            DateTime dtMonday = dtSunday.AddDays(1);
            DateTime dtTuesday = dtSunday.AddDays(2);
            DateTime dtWednesday = dtSunday.AddDays(3);
            DateTime dtThursday = dtSunday.AddDays(4);
            DateTime dtFriday = dtSunday.AddDays(5);
            DateTime dtSaturday = dtSunday.AddDays(6);

            DayModel model = new DayModel();

            model.dtSunday = dtSunday.ToString();
            model.dtMonday = dtMonday.ToString(); 
            model.dtTuesday = dtTuesday.ToString(); 
            model.dtWednesday = dtWednesday.ToString();
            model.dtThursday = dtThursday.ToString();
            model.dtFriday = dtFriday.ToString();
            model.dtSaturday = dtSaturday.ToString();

            // TODO このメソッド下記のように簡略化できないだろうか
            // ここでついでにsubstringして、このモデルを使用するところではsubstringなどを意識せずに使えるようにしたほうがいいのかもしれない。

            //DayModel dayModel = new DayModel();

            //dayModel.dtSunday = dtSunday.AddDays(1).ToString().Substring(0, 10);

            return model;
        }

    }

}

