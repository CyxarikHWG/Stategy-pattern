using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_04_08
{
    interface IPayment
    {
        double CountSalary();
    }

    class SalaryCount1 : IPayment
    {
        private Timeboard Timeboard { get; set; }

        public SalaryCount1(Timeboard timebd)
        {
            Timeboard = timebd;
        }

        public int ContractSum()
        {
            int sum = 0;
            for (int i = 0; i < Timeboard.Employer.Contracts.Count; i++)
            {
                sum += Timeboard.Employer.Contracts[i].Cost;
            }
            return sum;
        }

        private double TimeRangePayment()
        {
            double result = 0;
            double paymentPerHour = Timeboard.Employer.PaymentPerHour();
            int overWorkHours = 0;
            for (int i = 0; i < Timeboard.Timesheets.Count; i++)
            {
                // Если работал в субботу или воскресенье
                if (Timeboard.Timesheets[i].Date.DayOfWeek == DayOfWeek.Saturday || Timeboard.Timesheets[i].Date.DayOfWeek == DayOfWeek.Sunday)
                {
                    result += (paymentPerHour * Timeboard.Timesheets[i].Hours) * 2;
                }
                // Если работал в другие дни
                else
                {
                    if (Timeboard.Timesheets[i].Hours - 8 > 0)
                    {
                        overWorkHours = Timeboard.Timesheets[i].Hours - 8;
                        result += paymentPerHour * 8; // Обычные 8 часов
                        result += (paymentPerHour * overWorkHours) * 2; // Переработка
                        continue;
                    }
                    result += paymentPerHour * Timeboard.Timesheets[i].Hours;
                }
            }
            return result;
        }

        public double CountSalary()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("#1");
            Console.ForegroundColor = ConsoleColor.Gray;

            double payment = TimeRangePayment();
            Console.WriteLine(payment);

            double percent5 = ContractSum() * 0.05;
            payment += percent5;
            Console.WriteLine($"+{percent5}");

            double percent13 = payment * 0.13;
            payment -= percent13;
            Console.WriteLine($"-{percent13}");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"={payment}");
            Console.ForegroundColor = ConsoleColor.Gray;
            return payment;
        }
    }

    class SalaryCount2 : IPayment
    {
        private Timeboard Timeboard { get; set; }

        public SalaryCount2(Timeboard timebd)
        {
            Timeboard = timebd;
        }

        private double TimeRangePayment()
        {
            double result = 0;
            double paymentPerHour = Timeboard.Employer.PaymentPerHour();
            for (int i = 0; i < Timeboard.Timesheets.Count; i++)
            {
                result += paymentPerHour * Timeboard.Timesheets[i].Hours;
            }
            return result;
        }

        public double CountSalary()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("#2");
            Console.ForegroundColor = ConsoleColor.Gray;

            double payment = TimeRangePayment();
            Console.WriteLine(payment);

            double percent13 = payment * 0.13;
            Console.WriteLine($"-{percent13}");
            double percentUnion = payment * 0.015;
            Console.WriteLine($"-{percentUnion}");

            payment -= percent13;
            payment -= percentUnion;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"={payment}");
            Console.ForegroundColor = ConsoleColor.Gray;
            return payment;
        }
    }

    class SalaryCount3 : IPayment
    {
        private Timeboard Timeboard { get; set; }

        public SalaryCount3(Timeboard timebd)
        {
            Timeboard = timebd;
        }

        private double TimeRangePayment()
        {
            double result = 0;
            double paymentPerHour = Timeboard.Employer.PaymentPerHour();
            for (int i = 0; i < Timeboard.Timesheets.Count; i++)
            {
                result += paymentPerHour * Timeboard.Timesheets[i].Hours;
            }
            return result;
        }

        public double CountSalary()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("#3");
            Console.ForegroundColor = ConsoleColor.Gray;

            double payment = TimeRangePayment();
            Console.WriteLine(payment);

            double percent13 = payment * 0.13;
            Console.WriteLine($"-{percent13}");
            double percentUnion = payment * 0.005;
            Console.WriteLine($"-{percentUnion}");

            payment -= percent13;
            payment -= percentUnion;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"={payment}");
            Console.ForegroundColor = ConsoleColor.Gray;
            return payment;
        }
    }

    class SalaryCount4 : IPayment
    {
        private Timeboard Timeboard { get; set; }

        public SalaryCount4(Timeboard timebd)
        {
            Timeboard = timebd;
        }

        public int ContractSum()
        {
            int sum = 0;
            for (int i = 0; i < Timeboard.Employer.Contracts.Count; i++)
            {
                sum += Timeboard.Employer.Contracts[i].Cost;
            }
            return sum;
        }

        private double TimeRangePayment()
        {
            double result = 0;
            double paymentPerHour = Timeboard.Employer.PaymentPerHour();
            int overWorkHours = 0;
            for (int i = 0; i < Timeboard.Timesheets.Count; i++)
            {
                // Если работал в субботу или воскресенье
                if (Timeboard.Timesheets[i].Date.DayOfWeek == DayOfWeek.Saturday || Timeboard.Timesheets[i].Date.DayOfWeek == DayOfWeek.Sunday)
                {
                    result += (paymentPerHour * Timeboard.Timesheets[i].Hours) * 2;
                }
                // Если работал в другие дни
                else
                {
                    if (Timeboard.Timesheets[i].Hours - 8 > 0)
                    {
                        overWorkHours = Timeboard.Timesheets[i].Hours - 8;
                        result += paymentPerHour * 8; // Обычные 8 часов
                        result += (paymentPerHour * overWorkHours) * 2; // Переработка
                        continue;
                    }
                    result += paymentPerHour * Timeboard.Timesheets[i].Hours;
                }
            }
            return result;
        }

        public double CountSalary()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("#4");
            Console.ForegroundColor = ConsoleColor.Gray;

            double payment = TimeRangePayment();
            Console.WriteLine(payment);

            double percent7 = ContractSum() * 0.07;
            payment += percent7;
            Console.WriteLine($"+{percent7}");

            double percent13 = payment * 0.13;
            Console.WriteLine($"-{percent13}");
            double percentUnion = payment * 0.01;
            Console.WriteLine($"-{percentUnion}");

            payment -= percent13;
            payment -= percentUnion;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"={payment}");
            Console.ForegroundColor = ConsoleColor.Gray;
            return payment;
        }
    }

    class SalaryCount5 : IPayment
    {
        private Timeboard Timeboard { get; set; }

        public SalaryCount5(Timeboard timebd)
        {
            Timeboard = timebd;
        }

        public int ContractSum()
        {
            int sum = 0;
            for (int i = 0; i < Timeboard.Employer.Contracts.Count; i++)
            {
                sum += Timeboard.Employer.Contracts[i].Cost;
            }
            return sum;
        }

        private double TimeRangePayment()
        {
            double result = 0;
            double paymentPerHour = Timeboard.Employer.PaymentPerHour();
            int overWorkHours = 0;
            for (int i = 0; i < Timeboard.Timesheets.Count; i++)
            {
                // Если работал в субботу или воскресенье
                if (Timeboard.Timesheets[i].Date.DayOfWeek == DayOfWeek.Saturday || Timeboard.Timesheets[i].Date.DayOfWeek == DayOfWeek.Sunday)
                {
                    result += (paymentPerHour * Timeboard.Timesheets[i].Hours) * 2;
                }
                // Если работал в другие дни
                else
                {
                    if (Timeboard.Timesheets[i].Hours - 8 > 0)
                    {
                        overWorkHours = Timeboard.Timesheets[i].Hours - 8;
                        result += paymentPerHour * 8; // Обычные 8 часов
                        result += (paymentPerHour * overWorkHours) * 2; // Переработка
                        continue;
                    }
                    result += paymentPerHour * Timeboard.Timesheets[i].Hours;
                }
            }
            return result;
        }

        public double CountSalary()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("#5");
            Console.ForegroundColor = ConsoleColor.Gray;

            double payment = TimeRangePayment();
            Console.WriteLine(payment);

            double percent10 = ContractSum() * 0.10;
            payment += percent10;
            Console.WriteLine($"+{percent10}");

            double percent13 = payment * 0.13;
            Console.WriteLine($"-{percent13}");

            payment -= percent13;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"={payment}");
            Console.ForegroundColor = ConsoleColor.Gray;
            return payment;
        }
    }
}
