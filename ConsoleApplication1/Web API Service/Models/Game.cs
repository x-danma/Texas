using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_API_Service.Models
{
    public class Game
    {
        public List<Player> Players { get; set; }

        public Deck Deck { get; set; }

        public List<Card> CommunityCards { get; set; }


    }
}