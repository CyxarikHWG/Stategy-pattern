using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_04_08
{
    class Timeboard
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Timesheet> Timesheets { get; set; }
        public Employee Employer { get; set; }

        public Timeboard()
        {
            Timesheets = new List<Timesheet>() { };
        }

        public Timeboard(DateTime startDate, DateTime endDate, List<Timesheet> timesheets, Employee employee)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Timesheets = timesheets;
            this.Employer = employee;
        }

        public int DaysBetween()
        {
            TimeSpan between = EndDate.Subtract(StartDate);
            return (int)between.TotalDays;
        }

    }
}
