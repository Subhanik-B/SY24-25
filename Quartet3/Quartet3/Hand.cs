using Quartet3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartet3
{
    internal class Hand
    {
        List<CarCard> carCards;

        public CarCard getTop()
        {
            return carCards[0];
        }
    }
}
