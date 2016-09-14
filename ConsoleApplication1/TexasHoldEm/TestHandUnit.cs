using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    class TestHandUnit
    {
        public List<Card> TestHand { get; set; }
        public List<Card> CorrectBestHand { get; set; }
        public string CorrectName { get; set; }
        public int TestNumber { get; set; }

        public TestHandUnit(List<Card> testHand, string correctName, int testNumber, List<Card> correctBestHand)
        {
            this.TestHand = testHand;
            this.CorrectName = correctName;
            this.TestNumber = testNumber;
            this.CorrectBestHand = correctBestHand;

        }

        public void PrintTestHand()
        {
            foreach (Card  card in TestHand)
            {
                
                Console.Write($"\t{card.Color}:{card.Number}");
                Console.Write("\n");
            }
        }
        public void PrintCorrectBestHand()
        {
            foreach (Card card in CorrectBestHand)
            {

                Console.Write($"\t{card.Color}:{card.Number}");
                Console.Write("\n");
            }
        }
    }

}
