using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Web_API_Service.Models
{
    [DataContract]
    public class Card
    {
        [DataMember]
        public int Number { get; set; }
        [DataMember]
        public int AlternativeNumber { get; set; }
        [DataMember]
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

        /// <summary>
        /// Good for debugging
        /// </summary>
        /// <returns>Number and Color directly as one string</returns>
        public override string ToString()
        {
            return $"{this.Number} {this.Colour} ";
        }
    }
}