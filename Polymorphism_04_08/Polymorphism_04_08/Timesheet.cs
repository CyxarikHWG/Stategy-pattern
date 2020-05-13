using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_04_08
{
    class Timesheet
    {
        public DateTime Date { get; set; }
        public int Hours { get; set; }

        public Timesheet(DateTime date, int hours)
        {
            this.Date = date;
            this.Hours = hours;
        }
    }
}
