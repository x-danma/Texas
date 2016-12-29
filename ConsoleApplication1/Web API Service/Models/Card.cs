using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_API_Service.Models
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
        public Card(int number, string colour)
        {
            this.Number = number;
            if (number == 14)
                this.AlternativeNumber = 1;
            else
                this.AlternativeNumber = number;

            if (colour == "Hearts")
            {
                this.Colour = CardColour.Hearts;
            }
            else if (colour == "Spades")
            {
                this.Colour = CardColour.Spades;
            }
            else if (colour == "Diamonds")
            {
                this.Colour = CardColour.Diamonds;
            }
            else if (colour == "Clovers")
            {
                this.Colour = CardColour.Clovers;
            }
            else
            {
                throw new Exception("Not a valid Colour for a Card");
            }

        }
        public override string ToString()
        {
            return $"{this.Number} {this.Colour} ";
        }
    }
}