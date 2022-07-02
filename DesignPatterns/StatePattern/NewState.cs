using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public class NewState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            Console.WriteLine($"Se le añade la cantidad de {amount} a su saldo");
            customerContext.Residue = amount;
            customerContext.SetState(new NotDebtorState());

        }
    }
}
