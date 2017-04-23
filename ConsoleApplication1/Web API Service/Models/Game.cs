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

        public Guid GameID { get; set; }

        public Game()
        {
            Players = new List<Models.Player>();
            Deck = new Deck();
            CommunityCards = new List<Models.Card>();
            GameID = Guid.NewGuid();
            for (int i = 0; i < 5; i++)
                CommunityCards.Add(Deck.DrawTopCard());

        }

        internal void drawPlayerCards()
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (var player in Players)
                {
                    player.Cards.Add(Deck.DrawTopCard());
                }
            }
        }


    }
}