using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexasHoldEm.Core;

namespace TexasHoldEm
{
  static  class TestHands
    {
        static List<TestHandUnit> HandsToTest = new List<TestHandUnit>();

        public static List<TestHandUnit> GetTestHands()

        {
            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(14, Card.CardColour.Clovers), //Yes
                                                              new Card(11, Card.CardColour.Clovers),
                                                              new Card(13, Card.CardColour.Hearts),
                                                              new Card(13, Card.CardColour.Clovers),
                                                              new Card(8, Card.CardColour.Spades),
                                                              new Card(12, Card.CardColour.Clovers),
                                                              new Card(10, Card.CardColour.Clovers)}, "Straight Flush", 1, new List<Card> {new Card(14, Card.CardColour.Clovers),
                                                                                                                             new Card(13, Card.CardColour.Clovers),
                                                                                                                             new Card(12, Card.CardColour.Clovers),
                                                                                                                             new Card(11, Card.CardColour.Clovers),
                                                                                                                             new Card(10, Card.CardColour.Clovers) }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(12, Card.CardColour.Hearts), //No
                                                              new Card(11, Card.CardColour.Clovers),
                                                              new Card(13, Card.CardColour.Hearts),
                                                              new Card(13, Card.CardColour.Clovers),
                                                              new Card(8, Card.CardColour.Spades),
                                                              new Card(12, Card.CardColour.Clovers),
                                                              new Card(10, Card.CardColour.Clovers)}, "Two Pairs", 2, new List<Card> {new Card(13, Card.CardColour.Hearts),
                                                                                                                        new Card(13, Card.CardColour.Clovers),
                                                                                                                        new Card(12, Card.CardColour.Clovers),
                                                                                                                        new Card(12, Card.CardColour.Hearts),
                                                                                                                        new Card(11, Card.CardColour.Clovers) }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(12, Card.CardColour.Clovers), //Yes
                                                              new Card(5, Card.CardColour.Clovers),
                                                              new Card(4, Card.CardColour.Clovers),
                                                              new Card(2, Card.CardColour.Clovers),
                                                              new Card(14, Card.CardColour.Clovers),
                                                              new Card(8, Card.CardColour.Clovers),
                                                              new Card(3, Card.CardColour.Clovers)}, "Straight Flush", 3, new List<Card> {new Card(5, Card.CardColour.Hearts),
                                                                                                                        new Card(4, Card.CardColour.Clovers),
                                                                                                                        new Card(3, Card.CardColour.Clovers),
                                                                                                                        new Card(2, Card.CardColour.Hearts),
                                                                                                                        new Card(14, Card.CardColour.Clovers) }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(12, Card.CardColour.Hearts), //Yes
                                                              new Card(5, Card.CardColour.Clovers),
                                                              new Card(4, Card.CardColour.Clovers),
                                                              new Card(2, Card.CardColour.Clovers),
                                                              new Card(14, Card.CardColour.Clovers),
                                                              new Card(6, Card.CardColour.Clovers),
                                                              new Card(3, Card.CardColour.Clovers)}, "Straight Flush", 4, new List<Card> {new Card(6, Card.CardColour.Hearts),
                                                                                                                        new Card(5, Card.CardColour.Clovers),
                                                                                                                        new Card(4, Card.CardColour.Clovers),
                                                                                                                        new Card(3, Card.CardColour.Hearts),
                                                                                                                        new Card(2, Card.CardColour.Clovers) }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(12, Card.CardColour.Diamonds), //Yes
                                                              new Card(12, Card.CardColour.Clovers),
                                                              new Card(14, Card.CardColour.Clovers),
                                                              new Card(13, Card.CardColour.Clovers),
                                                              new Card(12, Card.CardColour.Spades),
                                                              new Card(12, Card.CardColour.Hearts),
                                                              new Card(3, Card.CardColour.Clovers)}, "Four Of A Kind", 5, new List<Card> {new Card(12, Card.CardColour.Hearts),
                                                                                                                        new Card(12, Card.CardColour.Clovers),
                                                                                                                        new Card(12, Card.CardColour.Clovers),
                                                                                                                        new Card(12, Card.CardColour.Hearts),
                                                                                                                        new Card(14, Card.CardColour.Clovers) }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(14, Card.CardColour.Diamonds), //Yes
                                                              new Card(14, Card.CardColour.Clovers),
                                                              new Card(14, Card.CardColour.Clovers),
                                                              new Card(2, Card.CardColour.Clovers),
                                                              new Card(2, Card.CardColour.Spades),
                                                              new Card(2, Card.CardColour.Hearts),
                                                              new Card(2, Card.CardColour.Clovers)}, "Four Of A Kind", 6, new List<Card> {new Card(2, Card.CardColour.Hearts),
                                                                                                                        new Card(2, Card.CardColour.Clovers),
                                                                                                                        new Card(2, Card.CardColour.Clovers),
                                                                                                                        new Card(2, Card.CardColour.Hearts),
                                                                                                                        new Card(14, Card.CardColour.Clovers) }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(14, Card.CardColour.Diamonds), //Yes
                                                              new Card(14, Card.CardColour.Clovers),
                                                              new Card(14, Card.CardColour.Clovers),
                                                              new Card(2, Card.CardColour.Clovers),
                                                              new Card(8, Card.CardColour.Spades),
                                                              new Card(7, Card.CardColour.Hearts),
                                                              new Card(6, Card.CardColour.Clovers)}, "Three Of A Kind", 7, new List<Card> {new Card(14, Card.CardColour.Hearts),
                                                                                                                        new Card(14, Card.CardColour.Clovers),
                                                                                                                        new Card(14, Card.CardColour.Clovers),
                                                                                                                        new Card(8, Card.CardColour.Hearts),
                                                                                                                        new Card(7, Card.CardColour.Clovers) }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(5, Card.CardColour.Diamonds), //Yes
                                                              new Card(7, Card.CardColour.Clovers),
                                                              new Card(10, Card.CardColour.Clovers),
                                                              new Card(10, Card.CardColour.Hearts),
                                                              new Card(10, Card.CardColour.Spades),
                                                              new Card(2, Card.CardColour.Hearts),
                                                              new Card(14, Card.CardColour.Clovers)}, "Three Of A Kind", 8, new List<Card> {new Card(10, Card.CardColour.Hearts),
                                                                                                                        new Card(10, Card.CardColour.Clovers),
                                                                                                                        new Card(10, Card.CardColour.Clovers),
                                                                                                                        new Card(14, Card.CardColour.Hearts),
                                                                                                                        new Card(7, Card.CardColour.Clovers) }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(5, Card.CardColour.Diamonds), //Yes
                                                              new Card(7, Card.CardColour.Clovers),
                                                              new Card(7, Card.CardColour.Clovers),
                                                              new Card(11, Card.CardColour.Hearts),
                                                              new Card(10, Card.CardColour.Spades),
                                                              new Card(2, Card.CardColour.Hearts),
                                                              new Card(14, Card.CardColour.Clovers)}, "Pair", 9, new List<Card> {new Card(7, Card.CardColour.Hearts),
                                                                                                                        new Card(7, Card.CardColour.Clovers),
                                                                                                                        new Card(14, Card.CardColour.Clovers),
                                                                                                                        new Card(11, Card.CardColour.Hearts),
                                                                                                                        new Card(10, Card.CardColour.Clovers) }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(5, Card.CardColour.Diamonds), //Yes
                                                              new Card(7, Card.CardColour.Clovers),
                                                              new Card(13, Card.CardColour.Clovers),
                                                              new Card(10, Card.CardColour.Hearts),
                                                              new Card(10, Card.CardColour.Spades),
                                                              new Card(2, Card.CardColour.Hearts),
                                                              new Card(14, Card.CardColour.Clovers)}, "Pair", 10, new List<Card> {new Card(10, Card.CardColour.Hearts),
                                                                                                                        new Card(10, Card.CardColour.Clovers),
                                                                                                                        new Card(14, Card.CardColour.Clovers),
                                                                                                                        new Card(13, Card.CardColour.Hearts),
                                                                                                                        new Card(7, Card.CardColour.Clovers) }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(4, Card.CardColour.Diamonds), //Yes
                                                              new Card(14, Card.CardColour.Clovers),
                                                              new Card(13, Card.CardColour.Clovers),
                                                              new Card(11, Card.CardColour.Hearts),
                                                              new Card(12, Card.CardColour.Spades),
                                                              new Card(4, Card.CardColour.Hearts),
                                                              new Card(14, Card.CardColour.Clovers)}, "Two Pairs", 11, new List<Card> {new Card(14, Card.CardColour.Hearts),
                                                                                                                        new Card(14, Card.CardColour.Clovers),
                                                                                                                        new Card(4, Card.CardColour.Clovers),
                                                                                                                        new Card(4, Card.CardColour.Hearts),
                                                                                                                        new Card(13, Card.CardColour.Clovers) }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(5, Card.CardColour.Diamonds), //Yes
                                                              new Card(7, Card.CardColour.Clovers),
                                                              new Card(13, Card.CardColour.Clovers),
                                                              new Card(10, Card.CardColour.Hearts),
                                                              new Card(10, Card.CardColour.Spades),
                                                              new Card(2, Card.CardColour.Hearts),
                                                              new Card(14, Card.CardColour.Clovers)}, "Pair", 12, new List<Card> {new Card(10, Card.CardColour.Hearts),
                                                                                                                        new Card(10, Card.CardColour.Clovers),
                                                                                                                        new Card(14, Card.CardColour.Clovers),
                                                                                                                        new Card(13, Card.CardColour.Hearts),
                                                                                                                        new Card(7, Card.CardColour.Clovers) }));
            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(5, Card.CardColour.Diamonds), //Yes
                                                              new Card(5, Card.CardColour.Clovers),
                                                              new Card(13, Card.CardColour.Clovers),
                                                              new Card(10, Card.CardColour.Hearts),
                                                              new Card(10, Card.CardColour.Spades),
                                                              new Card(5, Card.CardColour.Hearts),
                                                              new Card(14, Card.CardColour.Clovers)}, "FullHouse", 13, new List<Card> {new Card(5, Card.CardColour.Hearts),
                                                                                                                        new Card(5, Card.CardColour.Clovers),
                                                                                                                        new Card(5, Card.CardColour.Hearts),
                                                                                                                        new Card(10, Card.CardColour.Clovers),
                                                                                                                        new Card(10, Card.CardColour.Clovers) }));
            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(14, Card.CardColour.Diamonds), //Yes
                                                              new Card(11, Card.CardColour.Clovers),
                                                              new Card(2, Card.CardColour.Clovers),
                                                              new Card(2, Card.CardColour.Hearts),
                                                              new Card(14, Card.CardColour.Spades),
                                                              new Card(2, Card.CardColour.Hearts),
                                                              new Card(14, Card.CardColour.Clovers)}, "FullHouse", 14, new List<Card> {new Card(14, Card.CardColour.Hearts),
                                                                                                                        new Card(14, Card.CardColour.Clovers),
                                                                                                                        new Card(14, Card.CardColour.Clovers),
                                                                                                                        new Card(2, Card.CardColour.Hearts),
                                                                                                                        new Card(2, Card.CardColour.Clovers) }));
            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(5, Card.CardColour.Diamonds), //Yes
                                                              new Card(14, Card.CardColour.Clovers),
                                                              new Card(4, Card.CardColour.Clovers),
                                                              new Card(10, Card.CardColour.Hearts),
                                                              new Card(10, Card.CardColour.Spades),
                                                              new Card(4, Card.CardColour.Hearts),
                                                              new Card(4, Card.CardColour.Clovers)}, "FullHouse", 15, new List<Card> {new Card(4, Card.CardColour.Hearts),
                                                                                                                        new Card(4, Card.CardColour.Clovers),
                                                                                                                        new Card(4, Card.CardColour.Clovers),
                                                                                                                        new Card(10, Card.CardColour.Hearts),
                                                                                                                        new Card(10, Card.CardColour.Clovers) }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(5, Card.CardColour.Diamonds), //Yes
                                                              new Card(14, Card.CardColour.Clovers),
                                                              new Card(9, Card.CardColour.Clovers),
                                                              new Card(10, Card.CardColour.Hearts),
                                                              new Card(12, Card.CardColour.Spades),
                                                              new Card(2, Card.CardColour.Hearts),
                                                              new Card(4, Card.CardColour.Clovers)}, "Nothing", 16, new List<Card> ()));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(2, Card.CardColour.Diamonds), //Yes
                                                              new Card(14, Card.CardColour.Clovers),
                                                              new Card(4, Card.CardColour.Clovers),
                                                              new Card(10, Card.CardColour.Hearts),
                                                              new Card(13, Card.CardColour.Spades),
                                                              new Card(6, Card.CardColour.Hearts),
                                                              new Card(8, Card.CardColour.Clovers)}, "Nothing", 17, new List<Card>()));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(8, Card.CardColour.Spades), //Yes
                                                              new Card(2, Card.CardColour.Clovers),
                                                              new Card(12, Card.CardColour.Diamonds),
                                                              new Card(6, Card.CardColour.Clovers),
                                                              new Card(5, Card.CardColour.Hearts),
                                                              new Card(11, Card.CardColour.Hearts),
                                                              new Card(8, Card.CardColour.Clovers)}, "Pair", 18, new List<Card> {new Card(8, Card.CardColour.Spades),
                                                                                                                        new Card(8, Card.CardColour.Clovers),
                                                                                                                        new Card(12, Card.CardColour.Diamonds),
                                                                                                                        new Card(11, Card.CardColour.Hearts),
                                                                                                                        new Card(6, Card.CardColour.Clovers) }));

            return HandsToTest;
        }
        
    }
}
