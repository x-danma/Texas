using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    class TwoPairs : Pair
    {
        private List<Card> FirstPair { get; set; } = new List<Card>();

        public TwoPairs() : base()
        {
            Name = "Two Pairs";
        }
        public override List<Card> ReturnBestHand(List<Card> incomingCards)
        {

            FirstPair.Clear();
            List<Card> firstPairHand = base.ReturnBestHand(incomingCards);

            if (firstPairHand.Count == 5)
            {
                FirstPair.Add(firstPairHand[0]); firstPairHand.RemoveAt(0);
                FirstPair.Add(firstPairHand[0]); firstPairHand.RemoveAt(0);

                RemoveFirstPairFromIncomingCards(incomingCards, firstPairHand);

                List<Card> secondPairHand = base.ReturnBestHand(incomingCards).ToList<Card>();

                if (secondPairHand.Count == 5)
                {
                    OutputCards.Clear();
                    OutputCards.Add(FirstPair[0]);
                    OutputCards.Add(FirstPair[1]);
                    OutputCards.Add(secondPairHand[0]);
                    OutputCards.Add(secondPairHand[1]);
                    OutputCards.Add(secondPairHand[2]);
                    return OutputCards;
                }
            }

            return new List<Card>();
        }

        private void RemoveFirstPairFromIncomingCards(List<Card> incomingCards, List<Card> firstPairHand)
        {
            incomingCards.RemoveAll(x => x.Number == FirstPair[0].Number && x.Colour == FirstPair[0].Colour);
            incomingCards.RemoveAll(x => x.Number == FirstPair[1].Number && x.Colour == FirstPair[1].Colour);

        }
    }
}
