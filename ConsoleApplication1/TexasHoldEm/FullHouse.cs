using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    class FullHouse : Pair
    {
        public bool FirstThreeOK { get; set; }
        public FullHouse() : base("FullHouse")
        {

        }
        internal override List<Card> ReturnBestHand(List<Card> incomingCards)
        {
            FirstThreeOK = false;
            List<Card> firstThree = (new ThreeOfAKind()).ReturnBestHand(incomingCards);

            if (firstThree.Count == 5)
            {
                FirstThreeOK = true;
                List<Card> tempOutput = firstThree.Take(3).ToList();
                RemoveFirstThreeFromIncomingCards(incomingCards, firstThree);
                List<Card> secondPair = base.ReturnBestHand(incomingCards);

                if (secondPair.Count == 4)
                {
                    OutputCards = new List<Card>();
                    OutputCards.Add(firstThree[0]);
                    OutputCards.Add(firstThree[1]);
                    OutputCards.Add(firstThree[2]);
                    OutputCards.Add(secondPair[0]);
                    OutputCards.Add(secondPair[1]);
                    return OutputCards;
                }
            }
            return new List<Card>();

        }

        private void RemoveFirstThreeFromIncomingCards(List<Card> incomingCards, List<Card> firstThree)
        {
            incomingCards.RemoveAll(x => x.Number == firstThree[0].Number && x.Color == firstThree[0].Color);
            incomingCards.RemoveAll(x => x.Number == firstThree[1].Number && x.Color == firstThree[1].Color);
            incomingCards.RemoveAll(x => x.Number == firstThree[2].Number && x.Color == firstThree[2].Color);

        }
        protected override void FillOutHand(int numberOfCardsForFullHand)
        {
            if (FirstThreeOK)
            {
                numberOfCardsForFullHand = 4;
            }
            base.FillOutHand(numberOfCardsForFullHand);
        }
    }
}
