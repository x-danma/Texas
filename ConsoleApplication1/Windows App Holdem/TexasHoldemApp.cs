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


namespace Windows_App_Holdem
{

    public partial class TexasHoldemApp : Form
    {
        static HttpClient proxy = new HttpClient();

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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStartNewGame_Click(object sender, EventArgs e)
        {
            //API.StartNewGame();

            yourHand.Clear();


            GetStartingHand();
            textBoxInfoBox.Text = "Waiting...";

            //RunAsync().Wait();
            //yourHand.Add(API.DrawTopCard());
            //yourHand.Add(API.DrawTopCard());

            //communityCards.Clear();
            //communityCards.Add(API.DrawTopCard());
            //communityCards.Add(API.DrawTopCard());
            //communityCards.Add(API.DrawTopCard());


            buttonNextCard.Enabled = true;
        }

        private async void GetStartingHand()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:14220/");
                HttpResponseMessage response = await client.GetAsync("api/Game/Player/Hand?PlayerId=1");
                if (response.IsSuccessStatusCode)
                {
                    string myCards = await response.Content.ReadAsStringAsync();

                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                    List<Card> myCardList = javaScriptSerializer.Deserialize<List<Card>>(myCards);

                    foreach (Card card in myCardList)
                    {
                        yourHand.Add(card);
                    }

                    communityCards.Add(myCardList[0]);
                    communityCards.Add(myCardList[0]);
                    communityCards.Add(myCardList[0]);

                }

            }
            tableState = 3;
            DisplayCards();
            textBoxInfoBox.Text = "";
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
                DisplayCards();
            }


        }

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

    }
}
