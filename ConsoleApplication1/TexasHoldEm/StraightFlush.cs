using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexasHoldEm;

namespace TexasHoldEm
{
    class StraightFlush : TexasHandAsserter
    {
        public StraightFlush() : base("Straight Flush", 5)
        {

        }

        protected override void CheckForMatch(Stack<Card> comparingStack, Card previousCard, List<Card> incomingCards)
        {
            if ((comparingStack.Peek().Number == previousCard.Number - 1 || comparingStack.Peek().AlternativeNumber == previousCard.Number - 1) && comparingStack.Peek().Color == previousCard.Color && comparingStack.Count <= NumberOfCardsNeeded)
            {

            }
            else
            {
                comparingStack.Pop();
            }
        }
    }
}