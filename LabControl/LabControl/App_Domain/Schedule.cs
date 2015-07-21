using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attempt1.App_Domain
{
    public class Schedule
    {
        private DateTime bookedSchedule;

        public Schedule()
        {

        }

        public Schedule(DateTime bookedSchedule)
        {
            this.bookedSchedule = bookedSchedule;
        }
    }
}