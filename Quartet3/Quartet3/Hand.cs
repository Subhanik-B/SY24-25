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
        List<CarCard> carCards = new List<CarCard>();
        public CarCard topCard()
        {
            return carCards[0];
        }
        public void Add(CarCard carCard)
        {
            carCards.Add(carCard);
        }

        public void cycle()
        {
            carCards.Add(carCards[0]);
            carCards.Remove(carCards[0]);
        }
    }
}
