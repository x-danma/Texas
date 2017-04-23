using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_API_Service.Models
{
    public class Player
    {
        public Guid PlayerID { get; set; }
        public List<Card> Cards { get; set; }

        public Player(Guid playerID)
        {
            PlayerID = playerID;
        }

    }
}