using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
  static  class TestHands
    {
        static List<TestHandUnit> HandsToTest = new List<TestHandUnit>();

        public static List<TestHandUnit> GetTestHands()

        {
            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(14, "Clovers"), //Yes
                                                              new Card(11, "Clovers"),
                                                              new Card(13, "Hearts"),
                                                              new Card(13, "Clovers"),
                                                              new Card(8, "Spades"),
                                                              new Card(12, "Clovers"),
                                                              new Card(10, "Clovers")}, "Straight Flush", 1, new List<Card> {new Card(14, "Clovers"),
                                                                                                                             new Card(13, "Clovers"),
                                                                                                                             new Card(12, "Clovers"),
                                                                                                                             new Card(11, "Clovers"),
                                                                                                                             new Card(10, "Clovers") }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(12, "Hearts"), //No
                                                              new Card(11, "Clovers"),
                                                              new Card(13, "Hearts"),
                                                              new Card(13, "Clovers"),
                                                              new Card(8, "Spades"),
                                                              new Card(12, "Clovers"),
                                                              new Card(10, "Clovers")}, "Two Pairs", 2, new List<Card> {new Card(13, "Hearts"),
                                                                                                                        new Card(13, "Clovers"),
                                                                                                                        new Card(12, "Clovers"),
                                                                                                                        new Card(12, "Hearts"),
                                                                                                                        new Card(11, "Clovers") }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(12, "Clovers"), //Yes
                                                              new Card(5, "Clovers"),
                                                              new Card(4, "Clovers"),
                                                              new Card(2, "Clovers"),
                                                              new Card(14, "Clovers"),
                                                              new Card(8, "Clovers"),
                                                              new Card(3, "Clovers")}, "Straight Flush", 3, new List<Card> {new Card(5, "Hearts"),
                                                                                                                        new Card(4, "Clovers"),
                                                                                                                        new Card(3, "Clovers"),
                                                                                                                        new Card(2, "Hearts"),
                                                                                                                        new Card(14, "Clovers") }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(12, "Hearts"), //Yes
                                                              new Card(5, "Clovers"),
                                                              new Card(4, "Clovers"),
                                                              new Card(2, "Clovers"),
                                                              new Card(14, "Clovers"),
                                                              new Card(6, "Clovers"),
                                                              new Card(3, "Clovers")}, "Straight Flush", 4, new List<Card> {new Card(6, "Hearts"),
                                                                                                                        new Card(5, "Clovers"),
                                                                                                                        new Card(4, "Clovers"),
                                                                                                                        new Card(3, "Hearts"),
                                                                                                                        new Card(2, "Clovers") }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(12, "Diamonds"), //Yes
                                                              new Card(12, "Clubs"),
                                                              new Card(14, "Clovers"),
                                                              new Card(13, "Clovers"),
                                                              new Card(12, "Spades"),
                                                              new Card(12, "Hearts"),
                                                              new Card(3, "Clovers")}, "Four Of A Kind", 5, new List<Card> {new Card(12, "Hearts"),
                                                                                                                        new Card(12, "Clovers"),
                                                                                                                        new Card(12, "Clovers"),
                                                                                                                        new Card(12, "Hearts"),
                                                                                                                        new Card(14, "Clovers") }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(14, "Diamonds"), //Yes
                                                              new Card(14, "Clubs"),
                                                              new Card(14, "Clovers"),
                                                              new Card(2, "Clovers"),
                                                              new Card(2, "Spades"),
                                                              new Card(2, "Hearts"),
                                                              new Card(2, "Clovers")}, "Four Of A Kind", 6, new List<Card> {new Card(2, "Hearts"),
                                                                                                                        new Card(2, "Clovers"),
                                                                                                                        new Card(2, "Clovers"),
                                                                                                                        new Card(2, "Hearts"),
                                                                                                                        new Card(14, "Clovers") }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(14, "Diamonds"), //Yes
                                                              new Card(14, "Clubs"),
                                                              new Card(14, "Clovers"),
                                                              new Card(2, "Clovers"),
                                                              new Card(8, "Spades"),
                                                              new Card(7, "Hearts"),
                                                              new Card(6, "Clovers")}, "Three Of A Kind", 7, new List<Card> {new Card(14, "Hearts"),
                                                                                                                        new Card(14, "Clovers"),
                                                                                                                        new Card(14, "Clovers"),
                                                                                                                        new Card(8, "Hearts"),
                                                                                                                        new Card(7, "Clovers") }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(5, "Diamonds"), //Yes
                                                              new Card(7, "Clubs"),
                                                              new Card(10, "Clovers"),
                                                              new Card(10, "Hearts"),
                                                              new Card(10, "Spades"),
                                                              new Card(2, "Hearts"),
                                                              new Card(14, "Clovers")}, "Three Of A Kind", 8, new List<Card> {new Card(10, "Hearts"),
                                                                                                                        new Card(10, "Clovers"),
                                                                                                                        new Card(10, "Clovers"),
                                                                                                                        new Card(14, "Hearts"),
                                                                                                                        new Card(7, "Clovers") }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(5, "Diamonds"), //Yes
                                                              new Card(7, "Clubs"),
                                                              new Card(7, "Clovers"),
                                                              new Card(11, "Hearts"),
                                                              new Card(10, "Spades"),
                                                              new Card(2, "Hearts"),
                                                              new Card(14, "Clovers")}, "Pair", 9, new List<Card> {new Card(7, "Hearts"),
                                                                                                                        new Card(7, "Clovers"),
                                                                                                                        new Card(14, "Clovers"),
                                                                                                                        new Card(11, "Hearts"),
                                                                                                                        new Card(10, "Clovers") }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(5, "Diamonds"), //Yes
                                                              new Card(7, "Clubs"),
                                                              new Card(13, "Clovers"),
                                                              new Card(10, "Hearts"),
                                                              new Card(10, "Spades"),
                                                              new Card(2, "Hearts"),
                                                              new Card(14, "Clovers")}, "Pair", 10, new List<Card> {new Card(10, "Hearts"),
                                                                                                                        new Card(10, "Clovers"),
                                                                                                                        new Card(14, "Clovers"),
                                                                                                                        new Card(13, "Hearts"),
                                                                                                                        new Card(7, "Clovers") }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(4, "Diamonds"), //Yes
                                                              new Card(14, "Clubs"),
                                                              new Card(13, "Clovers"),
                                                              new Card(11, "Hearts"),
                                                              new Card(12, "Spades"),
                                                              new Card(4, "Hearts"),
                                                              new Card(14, "Clovers")}, "Two Pairs", 11, new List<Card> {new Card(14, "Hearts"),
                                                                                                                        new Card(14, "Clovers"),
                                                                                                                        new Card(4, "Clovers"),
                                                                                                                        new Card(4, "Hearts"),
                                                                                                                        new Card(13, "Clovers") }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(5, "Diamonds"), //Yes
                                                              new Card(7, "Clubs"),
                                                              new Card(13, "Clovers"),
                                                              new Card(10, "Hearts"),
                                                              new Card(10, "Spades"),
                                                              new Card(2, "Hearts"),
                                                              new Card(14, "Clovers")}, "Pair", 12, new List<Card> {new Card(10, "Hearts"),
                                                                                                                        new Card(10, "Clovers"),
                                                                                                                        new Card(14, "Clovers"),
                                                                                                                        new Card(13, "Hearts"),
                                                                                                                        new Card(7, "Clovers") }));
            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(5, "Diamonds"), //Yes
                                                              new Card(5, "Clubs"),
                                                              new Card(13, "Clovers"),
                                                              new Card(10, "Hearts"),
                                                              new Card(10, "Spades"),
                                                              new Card(5, "Hearts"),
                                                              new Card(14, "Clovers")}, "FullHouse", 13, new List<Card> {new Card(5, "Hearts"),
                                                                                                                        new Card(5, "Clovers"),
                                                                                                                        new Card(5, "Hearts"),
                                                                                                                        new Card(10, "Clovers"),
                                                                                                                        new Card(10, "Clovers") }));
            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(14, "Diamonds"), //Yes
                                                              new Card(11, "Clubs"),
                                                              new Card(2, "Clovers"),
                                                              new Card(2, "Hearts"),
                                                              new Card(14, "Spades"),
                                                              new Card(2, "Hearts"),
                                                              new Card(14, "Clovers")}, "FullHouse", 14, new List<Card> {new Card(14, "Hearts"),
                                                                                                                        new Card(14, "Clovers"),
                                                                                                                        new Card(14, "Clovers"),
                                                                                                                        new Card(2, "Hearts"),
                                                                                                                        new Card(2, "Clovers") }));
            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(5, "Diamonds"), //Yes
                                                              new Card(14, "Clubs"),
                                                              new Card(4, "Clovers"),
                                                              new Card(10, "Hearts"),
                                                              new Card(10, "Spades"),
                                                              new Card(4, "Hearts"),
                                                              new Card(4, "Clovers")}, "FullHouse", 15, new List<Card> {new Card(4, "Hearts"),
                                                                                                                        new Card(4, "Clovers"),
                                                                                                                        new Card(4, "Clovers"),
                                                                                                                        new Card(10, "Hearts"),
                                                                                                                        new Card(10, "Clovers") }));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(5, "Diamonds"), //Yes
                                                              new Card(14, "Clubs"),
                                                              new Card(9, "Clovers"),
                                                              new Card(10, "Hearts"),
                                                              new Card(12, "Spades"),
                                                              new Card(2, "Hearts"),
                                                              new Card(4, "Clovers")}, "Nothing", 16, new List<Card> ()));

            HandsToTest.Add(new TestHandUnit(new List<Card> { new Card(2, "Diamonds"), //Yes
                                                              new Card(14, "Clubs"),
                                                              new Card(4, "Clovers"),
                                                              new Card(10, "Hearts"),
                                                              new Card(13, "Spades"),
                                                              new Card(6, "Hearts"),
                                                              new Card(8, "Clovers")}, "Nothing", 17, new List<Card>()));

            return HandsToTest;
        }
        
    }
}
