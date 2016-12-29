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
            List<Card> tempDeck = new List<Card>();
            FillDeck(tempDeck);

            Cards = shuffleDeck(tempDeck);

        }

        public void RefreshDeck()
        {
            Cards.Clear();
            FillDeck(Cards);
        }

        private static List<Card> shuffleDeck(List<Card> newDeck)
        {
            Random rand = new Random();
            List<Card> shuffledDeck = new List<Card>();
            
            while (newDeck.Count > 0)
            {
                int randomIndex = rand.Next() % newDeck.Count;
                shuffledDeck.Add(newDeck[randomIndex]);
                newDeck.RemoveAt(randomIndex);

            }
            return shuffledDeck;
        }
        private static void FillDeck(List<Card> tempDeck)
        {
            for (int i = 2; i <= 14; i++)
            {
                foreach (Card.CardColour color in Enum.GetValues(typeof(Card.CardColour)))
                {
                    tempDeck.Add(new Card(i, color));
                }
            }
        }

    }
}