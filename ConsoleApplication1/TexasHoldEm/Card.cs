using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    public class Card
    {
        public int Number { get; set; }
        public int AlternativeNumber { get; set; }
        public CardColour Colour { get; set; }

        public enum CardColour
        {
            Hearts, Spades, Diamonds, Clovers
        }
        public Card(int number, CardColour colour)
        {
            this.Number = number;
            if (number == 14)           
                this.AlternativeNumber = 1;
            else
                this.AlternativeNumber = number;
            this.Colour = colour;
        }
        
        public override string ToString()
        {
            return $"{this.Number} {this.Colour.ToString()} ";
        }
    }
}