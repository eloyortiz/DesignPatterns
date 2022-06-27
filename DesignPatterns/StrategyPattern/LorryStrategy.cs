using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    class LorryStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy un camión y tengo 8 ruedas");
        }
    }
}
