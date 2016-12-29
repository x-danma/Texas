using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_API_Service.Models
{
    public class Deck
    {
        public List<Card> Cards { get; set; }
        public List<Card> UsedCards { get; set; }
        /// <summary>
        /// Initializing a new Deck returns a fresh shuffled Deck with 52 Cards
        /// </summary>
        public Deck()
        {
            List<Card> newDeck = new List<Card>();
            for (int i = 2; i <= 14; i++)
            {
                foreach (string color in new List<string> { "Spades", "Hearts", "Diamonds", "Clovers" })
                {
                    newDeck.Add(new Card(i, color));
                }
            }
        }
    }
}