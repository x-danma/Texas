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
        List<Game> AllGames = new List<Game>();
        List<Player> AllPlayers = new List<Player>();

        // GET api/Game
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "There" };
        }

        // GET api/Game/Player/Hand
        [Route("Player/Hand")]
        public IEnumerable<Card> GetMyCurrentHand(Guid playerId, Guid gameID)
        {
            Game currentGame = AllGames.Find(x => x.GameID == gameID);
            if (currentGame.Players.Exists(x => x.PlayerID == playerId))          
                currentGame.drawPlayerCards();           
            return currentGame.Players[currentGame.Players.FindIndex(x => x.PlayerID == playerId)].Cards;
        }

        [Route("CommunityCards")]
        //GET api/Game/CommunityCards
        public IEnumerable<Card> GetCommunityCards(int GameId)
        {
            return new List<Card> { new Card(8, Card.CardColour.Clovers), new Card(6, Card.CardColour.Diamonds), new Card(11, Card.CardColour.Spades) };
        }

        [Route("StartNewGame")]
        //POST api/Game/StartNewGame
        public Guid GameID(Guid playerID)
        {

            Game newGame = new Game();
            Player newPlayer = new Models.Player(playerID);

            AllPlayers.Add(newPlayer);
            AllGames.Add(newGame);

            AddPlayerToGame(playerID, newGame.GameID);
            Console.WriteLine($"Starting new game with \n PlayerID \t {playerID}. \n Returning \n GameID \t {newGame.GameID}");
            return newGame.GameID;
        }

        private void AddPlayerToGame(Guid playerID, Guid gameID)
        {
            Game gameToAdd = AllGames.Find(x => x.GameID == gameID);
            Player playerToAdd = AllPlayers.Find(x => x.PlayerID == playerID);

            gameToAdd.Players.Add(playerToAdd);

        }
    }
}
