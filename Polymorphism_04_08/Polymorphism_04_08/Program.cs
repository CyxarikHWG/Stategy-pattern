using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_04_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Timeboard table1 = new Timeboard(
            //    new DateTime(2020, 02, 01),
            //    new DateTime(2020, 02, 06),
            //    new List<Timesheet>()
            //    {
            //        new Timesheet(new DateTime(2019, 02, 01), 10),
            //        new Timesheet(new DateTime(2019, 02, 02), 6),
            //        new Timesheet(new DateTime(2019, 02, 03), 0),
            //        new Timesheet(new DateTime(2019, 02, 04), 8),
            //        new Timesheet(new DateTime(2019, 02, 05), 8),
            //        new Timesheet(new DateTime(2019, 02, 06), 6),
            //    },
            //    new Employee(
            //        1, 5, "Зубенко Михаил Петрович",
            //        new DateTime(2015, 04, 01), true,
            //        new Position("dc31x", "Охранник пятерочки", 300),
            //        new List<Contract>()
            //        {
            //            new Contract(1, new DateTime(2019, 02, 20), "Пупкин", 2500, "Отличная работа!"),
            //            new Contract(2, new DateTime(2019, 02, 21), "Пупкин", 1500, "Отличная работа!"),
            //            new Contract(3, new DateTime(2019, 02, 22), "Пупкин", 5000, "Отличная работа!"),
            //            new Contract(4, new DateTime(2019, 02, 23), "Пупкин", 1000, "Отличная работа!"),
            //        })
            //    );

            // Between SalaryCount1 and SalaryCount5
            //table1.Employer.StartCount(new SalaryCount4(table1));

            Timeboard table1 = ConsoleFilling.FillTimeboard();
            table1.Employer.StartCount(new SalaryCount1(table1));

            Console.ReadKey();
        }
    }
}
