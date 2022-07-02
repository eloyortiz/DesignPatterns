using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    internal class NotDebtorState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            if(amount <= customerContext.Residue)
            {
                customerContext.Discount(amount);
                Console.WriteLine($"Solicitud permitida, gasta {amount} y le queda de saldo {customerContext.Residue}");
                if (customerContext.Residue <= 0)
                    customerContext.SetState(new DebtorState());
            }
            else
            {
                Console.WriteLine($"Su saldo {customerContext.Residue} es inferior a la cantidad ({amount}) que quieres gastar.");
            }
        }
    }
}
