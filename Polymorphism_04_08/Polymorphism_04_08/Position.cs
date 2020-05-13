using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_04_08
{
    class Position
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double BaseHourlyRate { get; set; }

        public Position() { }

        public Position(string code, string name, double baseHourlyRate)
        {
            this.Code = code;
            this.Name = name;
            this.BaseHourlyRate = baseHourlyRate;
        }
    }
}
