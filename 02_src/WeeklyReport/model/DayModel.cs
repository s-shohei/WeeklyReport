using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyReport.model
{
    class DayModel
    {
        private DateTime dtSunday;
        private DateTime dtMonday;
        private DateTime dtTuesday;
        private DateTime dtWednesday;
        private DateTime dtThursday;
        private DateTime dtFriday;
        private DateTime dtSaturday;

        public void setSunday(DateTime d)
        {
            dtSunday = d;
        }

        public DateTime getSunday()
        {
            return dtSunday;
        }

        public void setMonday(DateTime d)
        {
            dtMonday = d;
        }

        public DateTime getMonday()
        {
            return dtMonday;
        }

        public void setTuesday(DateTime d)
        {
            dtTuesday = d;
        }

        public DateTime getTuesday()
        {
            return dtTuesday;
        }

        public void setWednesday(DateTime d)
        {
            dtWednesday = d;
        }

        public DateTime getWednesday()
        {
            return dtWednesday;
        }

        public void setThursday(DateTime d)
        {
            dtThursday = d;
        }

        public DateTime getThursday()
        {
            return dtThursday;
        }

        public void setFriday(DateTime d)
        {
            dtFriday = d;
        }

        public DateTime getFriday()
        {
            return dtFriday;
        }

        public void setSaturday(DateTime d)
        {
            dtSaturday = d;
        }

        public DateTime getSaturday()
        {
            return dtSaturday;
        }

    }
}
