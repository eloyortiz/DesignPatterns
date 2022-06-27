using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    class CarStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy un coche y tengo 4 ruedas");
        }
    }
}
