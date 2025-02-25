using Quartet3;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartet3
{
    internal class Deck
    {
        List<CarCard> carCards;
        List<Hand> Hands;
        Random random = new Random();
        public Deck(List<CarCard> cards)
        {
            this.carCards = cards;
        }
        public CarCard GetCard(int index)
        {
            CarCard C = carCards[index];
            carCards.RemoveAt(index);
            return C;
        }
        public override string ToString()
        {
            string retVal = "Deck:\n";
            foreach (CarCard card in carCards)
            {
                retVal += card.ToString();
            }
            return retVal;
        }
        public void updateDeck(List<CarCard> cards)
        {
            this.carCards = cards;
        }

        public void shuffle()
        {
            int n = 0;
            int n2 = 0;
            n = random.Next(carCards.Count);
            CarCard temp;
            for (int i = 0; i < carCards.Count; i++)
            {
                n2 = random.Next(carCards.Count);
                temp = carCards[n];
                carCards[n] = carCards[n2];
                carCards[n2] = temp;
            }
        }

        public void hands(Hand h1, Hand h2, Hand h3, Hand h4)
        {

        }
    }
}
