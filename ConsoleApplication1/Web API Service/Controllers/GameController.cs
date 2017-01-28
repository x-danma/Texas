using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_API_Service.Models;

namespace Web_API_Service.Controllers
{
    [RoutePrefix("api/Game")]
    public class GameController : ApiController
    {
        // GET api/Game
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "There" };
        }

        // GET api/Game/Player/Hand
        [Route("Player/Hand")]
        public IEnumerable<Card> GetMyCurrentHand(int PlayerId)
        {
            return new List<Card> { new Card(2, Card.CardColour.Clovers), new Card(4, Card.CardColour.Diamonds) };
        }

        [Route("CommunityCards")]
        //GET api/Game/CommunityCards
        public IEnumerable<Card> GetCommunityCards(int GameId)
        {
            return new List<Card> { new Card(8, Card.CardColour.Clovers), new Card(6, Card.CardColour.Diamonds), new Card(11, Card.CardColour.Spades)};
        }
    }
}
