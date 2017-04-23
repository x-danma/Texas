using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm.Core
{
    class Pair : TexasHandAsserter
    {
        public Pair() : base("Pair", 2)
        {

        }

        public Pair(string name) : base(name, 2)
        {

        }
        
    }
}

