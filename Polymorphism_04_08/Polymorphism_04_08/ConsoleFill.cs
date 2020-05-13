using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_04_08
{
    class ConsoleFilling
    {
        private static Position FillPosition()
        {
            Position position = new Position();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tPosition");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Code:");
            position.Code = Console.ReadLine();
            Console.WriteLine("Name:");
            position.Name = Console.ReadLine();
            Console.WriteLine("Base Hourly Rate:");
            position.BaseHourlyRate = Convert.ToDouble(Console.ReadLine());
            return position;
        }

        private static List<Contract> FillContacts()
        {
            List<Contract> Contracts = new List<Contract>() { };
            Console.WriteLine("How many contracts?");

            int contractsCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < contractsCount; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"\tContract #{i + 1}");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(new string('-', 20));

                Console.WriteLine("Number:");
                int Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("DateOfContract:");
                DateTime Date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Client:");
                string Client = Console.ReadLine();
                Console.WriteLine("Contract price:");
                int Cost = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Comment:");
                string Comment = Console.ReadLine();
                Contracts.Add(new Contract(Number, Date, Client, Cost, Comment));
            }
            return Contracts;
        }

        private static Employee FillEmployee()
        {
            Employee worker = new Employee();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tEmployee");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Number:");
            worker.Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Full name:");
            worker.FullName = Console.ReadLine();
            Console.WriteLine("Rating:");
            worker.Rating = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employment Date:");
            worker.EmploymentDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Is Member Of Labor Union:");
            worker.IsMemberOfLaborUnion = Convert.ToBoolean(Console.ReadLine());
            
            worker.Pos = FillPosition();    // Position

            worker.Contracts = FillContacts();    // Contracts

            return worker;
        }

        private static List<Timesheet> FillTimesheet(Timeboard timeboard)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\tTimesheets");
            Console.ForegroundColor = ConsoleColor.Gray;

            DateTime daySkipper = timeboard.StartDate;
            Console.WriteLine(new string('-', 20));
            for (int i = 0; i <= timeboard.DaysBetween(); i++)
            {
                Console.WriteLine($"Date: \n{daySkipper.ToShortDateString()} ({daySkipper.DayOfWeek})");
                Console.WriteLine("Worked hours:");
                int hour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(new string('-', 10));
                timeboard.Timesheets.Add(new Timesheet(daySkipper, hour));
                daySkipper = daySkipper.AddDays(1);
            }
            return timeboard.Timesheets;
        }

        public static Timeboard FillTimeboard()
        {
            Timeboard timeboard = new Timeboard();
            
            timeboard.Employer = FillEmployee();    // Employee

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tTimeboard");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Start Date:");
            timeboard.StartDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("End Date:");
            timeboard.EndDate = Convert.ToDateTime(Console.ReadLine());

            timeboard.Timesheets = FillTimesheet(timeboard);    // Timesheets

            return timeboard;
        }
    }
}