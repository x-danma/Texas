using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm.Core
{
    class GameDealer
    {
        public static List<Card> Deck { get; set; } = new List<Card>();

        private static List<Card> UsedCards { get; set; } = new List<Card>();

        public static void StartNewGame()
        {
            Deck = CreateDeck();
        }


        public static Card DrawTopCard()
        {
            Card returnCard = Deck[0];
            UsedCards.Add(Deck[0]);
            Deck.RemoveAt(0);
            return returnCard;
        }

        private static List<Card> CreateDeck()
        {
            List<Card> newDeck = new List<Card>();
            for (int i = 2; i < 14; i++)
            {
                foreach (Card.CardColour colour in Enum.GetValues(typeof(Card.CardColour)))
                {
                    newDeck.Add(new Card(i, colour));
                }
            }


            List<Card> shuffledDeck = shuffleDeck(newDeck);


            return shuffledDeck;
        }

        internal static List<Card> GetBestPossibleHand(List<Card> incomingCards)
        {
            foreach (TexasHandAsserter texasHandAsserter in API.GetPossibleWinningHands())
            {
                List<Card> best5CardHand = texasHandAsserter.ReturnBestHand(incomingCards.ToList());
                if (best5CardHand.Count == 5)
                {
                    return best5CardHand;
                }
            }
            return incomingCards.OrderByDescending(x => x.Number).ToList();

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
    }
}
