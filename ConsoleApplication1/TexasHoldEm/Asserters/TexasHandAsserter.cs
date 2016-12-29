using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    public class TexasHandAsserter
    {
        public string Name { get; set; }
        protected int NumberOfCardsNeeded { get; set; }
        protected Stack<Card> startStack { get; set; } = new Stack<Card>();
        protected Queue<Card> finalRestQueue { get; set; } = new Queue<Card>();
        public Queue<Card> tempRestQueue { get; set; } = new Queue<Card>();
        protected List<Card> OutputCards { get; set; }
        protected Queue<Card> SavedPairs { get; set; } = new Queue<Card>();

        public TexasHandAsserter(string name, int numberOfCardsNeeded)
        {
            this.Name = name;
            this.NumberOfCardsNeeded = numberOfCardsNeeded;
        }


        public virtual List<Card> ReturnBestHand(List<Card> incomingCards)
        {
            finalRestQueue.Clear();
            startStack.Clear();
            SavedPairs.Clear();
            incomingCards = incomingCards.OrderBy(card => card.Number).ToList();

            while (incomingCards.Count >= NumberOfCardsNeeded)

            {
                tempRestQueue.Clear();
                foreach (Card card in incomingCards)
                {
                    startStack.Push(card);
                }

                Stack<Card> comparingStack = new Stack<Card>(incomingCards.Count);
                //Initialize comparison Stack
                comparingStack.Push(startStack.Pop());
                while (startStack.Count > 0)
                {
                    Card previousCard = comparingStack.Peek();
                    comparingStack.Push(startStack.Pop());
                    ///----------------------------------------------------------------------
                    ///------------------------The Core Comparison---------------------------
                    CheckForMatch(comparingStack, previousCard, incomingCards);
                    ///----------------------------------------------------------------------
                    ///----------------------------------------------------------------------
                }

                if (comparingStack.Count == NumberOfCardsNeeded)
                {
                    OutputCards = comparingStack.Reverse().ToList();
                    FillOutHand(5);
                    return OutputCards;
                }


                Card removedCard = incomingCards.Last();
                incomingCards.RemoveAt(incomingCards.Count - 1); //Popping the largest number card

                if (removedCard.Number == 14)
                {
                    incomingCards.Insert(0, removedCard);
                    finalRestQueue.Enqueue(removedCard);
                }
                else
                {
                    finalRestQueue.Enqueue(removedCard);
                }

            }
            return new List<Card>();
        }
        /// <summary>
        /// Filling out the hand to a 5 card Hand. 
        /// First all cards in tempRestQueue are enQueued to the finalRestQueue. 
        /// The cards and added to OutputCards from finalRestQueue.
        /// </summary>
        protected virtual void FillOutHand(int numberOfCardsForFullHand)
        {

            while (tempRestQueue.Count > 0)
            {
                finalRestQueue.Enqueue(tempRestQueue.Dequeue());
            }

            int restCardsNeeded = numberOfCardsForFullHand - this.NumberOfCardsNeeded;
            for (int i = 0; i < restCardsNeeded; i++)
            {
                OutputCards.Add(finalRestQueue.Dequeue());
            }
        }
        /// <summary>
        /// Standard for pair, threes, fours, Overridden by straight, straight flush
        /// </summary>
        /// <param name="comparingStack"></param>
        /// <param name="previousCard"></param>
        protected virtual void CheckForMatch(Stack<Card> comparingStack, Card previousCard, List<Card> incomingCards)
        {
            if ((comparingStack.Peek().Number == previousCard.Number) && comparingStack.Count <= NumberOfCardsNeeded)
            {
                //AssertForTwoPairs(comparingStack, incomingCards);
            }
            else
            {
                tempRestQueue.Enqueue(comparingStack.Pop());
            }
        }

        private void AssertForTwoPairs(Stack<Card> comparingStack, List<Card> incomingCards)
        {
            if (this.Name == "Two Pairs" && comparingStack.Count == 2)
            {
                SavePairs(comparingStack);
            }
            //Remove saved pair from incoming cards. Otherwise Aces will be added again, and one pair of aces comes back again when Aces count as number=1.
            foreach (Card card in SavedPairs)
            {
                incomingCards.RemoveAll(x => x.Number == card.Number && x.Colour == card.Colour);
            }
        }

        private void SavePairs(Stack<Card> comparingStack)
        {
            while (comparingStack.Count > 0)
            {
                SavedPairs.Enqueue(comparingStack.Pop());
            }

            if (SavedPairs.Count == 4)
            {
                foreach (Card cardInTwoPairs in SavedPairs)
                {
                    comparingStack.Push(cardInTwoPairs);
                }
            }
            else
            {
                comparingStack.Push(startStack.Pop());
            }
        }
    }
}