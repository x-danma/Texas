using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    public class API
    {
        public static List<TexasHandAsserter> GetPossibleWinningHands()
        {
            List<TexasHandAsserter> returnList = new List<TexasHandAsserter>();
            returnList.Add(new StraightFlush());
            returnList.Add(new FourOfAKind());
            returnList.Add(new FullHouse());
            returnList.Add(new ThreeOfAKind());
            returnList.Add(new TwoPairs());
            returnList.Add(new Pair());

            return returnList;
        }

        public static List<Card> GetStarterCards()
        {
           return GameDealer.GetStarterHand();
        }
    }
}
