using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    class GameDealer
    {
        public static void StartNewGame()
        {
            List<Card> newDeck = CreateDeck();
        }
        public static List<Card> GetStarterHand()
        {
            return new List<Card>();
        }
        private static List<Card> CreateDeck()
        {
            List<Card> newDeck = new List<Card>();
            for (int i = 2; i < 14; i++)
            {
                foreach (string color in new List<string> { "Spades", "Hearts", "Diamonds", "Clovers" })
                {
                    newDeck.Add(new Card(i, color));
                }
            }
            return newDeck;
        }
    }
}
