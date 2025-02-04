using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    internal class CoinSlot
    {
        double total = 0;

        public void insertCoin(double amount)
        {
            total += amount;
        }

        public double returnMoney()
        {
            return total;
        }

        public void coinReturn()
        {
            total = 0;
        }
    }
}
