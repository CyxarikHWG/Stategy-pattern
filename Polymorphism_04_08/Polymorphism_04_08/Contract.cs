using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_04_08
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Client { get; set; }
        public int Cost { get; set; }
        public string Comment { get; set; }

        public Contract() { }

        public Contract(int N_, DateTime D_, string client, int cost, string comment)
        {
            Number = N_;
            Date = D_;
            Client = client;
            Cost = cost;
            Comment = comment;
        }
    }
}
