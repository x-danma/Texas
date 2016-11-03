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
        public String Color { get; set; }


        public Card(int number, string color)
        {
            this.Number = number;
            if (number == 14)
                this.AlternativeNumber = 1;
            else
                this.AlternativeNumber = number;


            this.Color = color;
        }
        public override string ToString()
        {
            return $"{this.Number} {this.Color} ";
        }
    }
}