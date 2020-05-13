using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_04_08
{
    class Employee
    {
        public int Number { get; set; }
        public string FullName { get; set; }
        private int rating;
        public DateTime EmploymentDate { get; set; }
        public bool IsMemberOfLaborUnion { get; set; }
        public Position Pos;
        public List<Contract> Contracts { get; set; }
        

        public int Rating
        {
            get { return rating; }
            set
            {
                if (value >= 1 && value <= 5)
                    rating = value;
                else
                    throw new Exception("Ошибочка");
            }
        }

        public Employee()
        {
            Contracts = new List<Contract>() { };
        }

        public Employee(int number, int rating, string fullName, DateTime employmentDate, bool isMemberOfLaborUnion, Position pos, List<Contract> contr)
        {
            this.Number = number;
            this.Rating = rating;
            this.FullName = fullName;
            this.EmploymentDate = employmentDate;
            this.IsMemberOfLaborUnion = isMemberOfLaborUnion;
            this.Pos = pos;
            this.Contracts = contr;
        }

        public void StartCount(IPayment pay)
        {
            if (pay != null)
            {
                pay.CountSalary();
            }
        }

        public double PaymentPerHour()
        {
            double percent = (this.Rating - 1) * 0.1;
            double HourlyRate = this.Pos.BaseHourlyRate * percent;
            HourlyRate += this.Pos.BaseHourlyRate;
            return HourlyRate;
        }
    }
}
