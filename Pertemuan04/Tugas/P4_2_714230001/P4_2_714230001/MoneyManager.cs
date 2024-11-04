using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230001
{
        public abstract class MoneyManager
        {
            public abstract void AddTransaction(string type, double amount);
            public abstract double GetBalance();
        }
}
