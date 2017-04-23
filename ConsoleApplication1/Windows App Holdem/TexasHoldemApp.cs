using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TexasHoldEm;
using System.Net.Http;
using System.Web.Script.Serialization;
using TexasHoldEm.Core;

namespace Windows_App_Holdem
{

    public partial class TexasHoldemApp : Form
    {
        static HttpClient proxy = new HttpClient();

        Guid myPlayerID = Guid.NewGuid();
        Guid myGameID;
        JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
        Uri serverUri = new Uri("http://localhost:14220/");
        List<Card> yourHand = new List<Card>();
        List<Card> communityCards = new List<Card>();
        List<Card> bestPossibleHand = new List<Card>();
        /// <summary>
        /// The number of dealer cards on the joint table
        /// </summary>
        public int tableState { get; set; }
        public TexasHoldemApp()
        {
            InitializeComponent();
        }

        #region Events

        private void buttonStartNewGame_Click(object sender, EventArgs e)
        {
            yourHand.Clear();
            StartNewGame();
            labelInfoText.Text = "Starting new game, please wait...";
            buttonNextCard.Enabled = true;

        }
        private void buttonJoinGame_Click(object sender, EventArgs e)
        {
            yourHand.Clear();
            JoinGame();
            labelInfoText.Text = "Joining game, please wait...";
            buttonNextCard.Enabled = true;
        }
        private void buttonPlayerReady_Click(object sender, EventArgs e)
        {
            GetStartingHand();
            labelInfoText.Text = "Waiting...";
        }
        private void buttonNextCard_Click(object sender, EventArgs e)
        {
            if (tableState == 3)
            {
                //communityCards.Add(API.DrawTopCard());
                tableState++;
                DisplayCards();
            }
            else if (tableState == 4)
            {
                //communityCards.Add(API.DrawTopCard());
                tableState++;
                buttonNextCard.Enabled = false;
                buttonStartNewGame.Enabled = true;
                DisplayCards();
            }
        }

        #endregion

        #region Async Methods

        private async void StartNewGame()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = serverUri;
                HttpResponseMessage response = await client.PostAsync($"api/Game/StartNewGame?playerID={myPlayerID}", new StringContent(myPlayerID.ToString()));

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    string contentString = javaScriptSerializer.Deserialize<string>(content);
                    if (Guid.TryParse(contentString, out myGameID))
                    {
                        labelInfoText.Text = "Created new Game!";
                        textBoxGameID.Text = $"{myGameID}";
                        listBoxPlayers.Items.Add("You");
                        buttonStartNewGame.Enabled = false;
                        buttonPlayerReady.Enabled = true;
                    }
                }
                else
                    labelInfoText.Text = "Error while connecting to the server. Please try again Later";
            }
        }
        private async void GetStartingHand()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = serverUri;
                HttpResponseMessage response = await client.GetAsync($"api/Game/Player/Hand?PlayerId={myPlayerID}&GameID={myGameID}");
                if (response.IsSuccessStatusCode)
                {
                    string myCards = await response.Content.ReadAsStringAsync();


                    List<Card> myCardList = javaScriptSerializer.Deserialize<List<Card>>(myCards);

                    foreach (Card card in myCardList)
                    {
                        yourHand.Add(card);
                    }

                    communityCards.Add(myCardList[0]);
                    communityCards.Add(myCardList[0]);
                    communityCards.Add(myCardList[0]);

                    tableState = 3;
                    DisplayCards();
                    labelInfoText.Text = "keep playing :)";
                }
                else
                    labelInfoText.Text = "Error while connecting to the server.Please try again Later";
            }
        }

        private void JoinGame()
        {
            //TODO new await call to get players in the current game
        }

        #endregion

        #region GUI methods

        private void DisplayCards()
        {
            DisplayBlankCards();

            //Your Hand Cards
            handCardOneNumber.Text = yourHand[0].Number.ToString();
            handCardOneColour.Text = yourHand[0].Colour.ToString();

            handCardTwoNumber.Text = yourHand[1].Number.ToString();
            handCardTwoColour.Text = yourHand[1].Colour.ToString();


            //Table Cards

            TableCardOneNumber.Text = communityCards[0].Number.ToString();
            TableCardOneColour.Text = communityCards[0].Colour.ToString();

            TableCardTwoNumber.Text = communityCards[1].Number.ToString();
            TableCardTwoColour.Text = communityCards[1].Colour.ToString();

            TableCardThreeNumber.Text = communityCards[2].Number.ToString();
            TableCardThreeColour.Text = communityCards[2].Colour.ToString();

            if (tableState == 4)
            {
                TableCardFourNumber.Text = communityCards[3].Number.ToString();
                TableCardFourColour.Text = communityCards[3].Colour.ToString();
            }
            if (tableState == 5)
            {
                TableCardFourNumber.Text = communityCards[3].Number.ToString();
                TableCardFourColour.Text = communityCards[3].Colour.ToString();

                TableCardFiveNumber.Text = communityCards[4].Number.ToString();
                TableCardFiveColour.Text = communityCards[4].Colour.ToString();
            }

            //Create Best Possible Hand
            bestPossibleHand.Clear();
            List<Card> cardsToTest = yourHand.Concat(communityCards).ToList();

            foreach (Card card in API.GetBestPossibleHand(cardsToTest))
            {
                bestPossibleHand.Add(card);
            }


            //Display Best Possible Hand
            BestHandCardOneNumber.Text = bestPossibleHand[0].Number.ToString();
            BestHandCardOneColour.Text = bestPossibleHand[0].Colour.ToString();

            BestHandCardTwoNumber.Text = bestPossibleHand[1].Number.ToString();
            BestHandCardTwoColour.Text = bestPossibleHand[1].Colour.ToString();

            BestHandCardThreeNumber.Text = bestPossibleHand[2].Number.ToString();
            BestHandCardThreeColour.Text = bestPossibleHand[2].Colour.ToString();

            BestHandCardFourNumber.Text = bestPossibleHand[3].Number.ToString();
            BestHandCardFourColour.Text = bestPossibleHand[3].Colour.ToString();

            BestHandCardFiveNumber.Text = bestPossibleHand[4].Number.ToString();
            BestHandCardFiveColour.Text = bestPossibleHand[4].Colour.ToString();
        }
        private void DisplayBlankCards()
        {
            //Your Hand Cards

            handCardOneNumber.Text = "";
            handCardOneColour.Text = "";

            handCardTwoNumber.Text = "";
            handCardTwoColour.Text = "";


            //Table Cards

            TableCardOneNumber.Text = "";
            TableCardOneColour.Text = "";

            TableCardTwoNumber.Text = "";
            TableCardTwoColour.Text = "";

            TableCardThreeNumber.Text = "";
            TableCardThreeColour.Text = "";

            TableCardFourNumber.Text = "";
            TableCardFourColour.Text = "";

            TableCardFiveNumber.Text = "";
            TableCardFiveColour.Text = "";
        }

        #endregion

    }
}
