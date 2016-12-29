using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexasHoldEm;

namespace TexasHoldEm
{
    public class Program
    {

        static List<Card> Deck = new List<Card>();
        static List<TestHandUnit> HandsToTest = new List<TestHandUnit>();
        public static void Main(string[] args)
        {
            CreateDeck();
            CreatePossibleWinningHands();
            List<TexasHandAsserter> TexasHoldEmHandAsserters = API.GetPossibleWinningHands();


            //ShuffleDeck();
            //List<Card> sevenCardHand = GetHand();
            //List<Card> sevenCardHand = new List<Card> { }

            HandsToTest = TestHands.GetTestHands();

            foreach (TestHandUnit testHandUnit in HandsToTest)
            {
                bool texasHandFound = false;
                foreach (TexasHandAsserter texasAsserter in TexasHoldEmHandAsserters)
                {
                    List<Card> best5CardHand = texasAsserter.ReturnBestHand(testHandUnit.TestHand.ToList());
                    if (best5CardHand.Count == 5)
                    {
                        if (testHandUnit.CorrectName == texasAsserter.Name && TestCorrectHandOutput(best5CardHand, testHandUnit))
                        {
                            Console.WriteLine($"Test number {testHandUnit.TestNumber} OK");
                            texasHandFound = true;
                            break;
                        }
                        else
                        {
                            Console.Write($"\nWrong with Test Hand no {testHandUnit.TestNumber}, \nTesthand start:\n");
                            testHandUnit.PrintTestHand();
                            Console.Write($"\nTesthand Expected: \n");
                            testHandUnit.PrintCorrectBestHand();
                            Console.Write($"\nReceived : \n");
                            foreach (Card card in best5CardHand) Console.Write($"\n\t{card.Colour}:{card.Number}");
                        }
                    }
                }

                if (!texasHandFound)
                {
                    if (testHandUnit.CorrectName == "Nothing")
                    {
                        Console.WriteLine($"Test number {testHandUnit.TestNumber} OK");
                    }
                    else
                    {
                        Console.WriteLine($"Wrong with Test Hand no {testHandUnit.TestNumber}");
                    }
                }
            }
        }

        private static bool TestCorrectHandOutput(List<Card> best5CardHandFromAsserter, TestHandUnit testHandUnit)
        {
            for (int i = 0; i < best5CardHandFromAsserter.Count; i++)
            {
                if (best5CardHandFromAsserter[i].Number != testHandUnit.CorrectBestHand[i].Number)
                {
                    return false;
                }
            }
            return true;
        }

        private static void CreatePossibleWinningHands()
        {
            
        }



        private static void CreateDeck()
        {
            for (int i = 2; i < 14; i++)
            {
                foreach (string Colour in new List<string> { "Spades", "Hearts", "Diamonds", "Clovers" })
                {
                    Deck.Add(new Card(i, Colour));
                }
            }
        }
    }
}







