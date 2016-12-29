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

namespace Windows_App_Holdem
{
    public partial class Form1 : Form
    {
        List<Card> yourHand = new List<Card>();
        List<Card> table = new List<Card>();
        /// <summary>
        /// The number of dealer cards on the joint table
        /// </summary>
        public int tableState { get; set; }

        public Form1()
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
            API.StartNewGame();

            yourHand.Clear();
            yourHand.Add(API.DrawTopCard());
            yourHand.Add(API.DrawTopCard());

            table.Clear();
            table.Add(API.DrawTopCard());
            table.Add(API.DrawTopCard());
            table.Add(API.DrawTopCard());

            tableState = 3;

            DisplayCards();

            buttonNextCard.Enabled = true;
        }

        private void buttonNextCard_Click(object sender, EventArgs e)
        {
            if (tableState == 3)
            {
                table.Add(API.DrawTopCard());
                tableState++;
                DisplayCards();
            }
            else if (tableState == 4)
            {
                table.Add(API.DrawTopCard());
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
            handCardOneColour.Text = yourHand[0].Color;

            handCardTwoNumber.Text = yourHand[1].Number.ToString();
            handCardTwoColour.Text = yourHand[1].Color;


            //Table Cards

            TableCardOneNumber.Text = table[0].Number.ToString();
            TableCardOneColour.Text = table[0].Color;

            TableCardTwoNumber.Text = table[1].Number.ToString();
            TableCardTwoColour.Text = table[1].Color;

            TableCardThreeNumber.Text = table[2].Number.ToString();
            TableCardThreeColour.Text = table[2].Color;

            if (tableState == 4)
            {
                TableCardFourNumber.Text = table[3].Number.ToString();
                TableCardFourColour.Text = table[3].Color;
            }
            if (tableState == 5)
            {
                TableCardFourNumber.Text = table[3].Number.ToString();
                TableCardFourColour.Text = table[3].Color;

                TableCardFiveNumber.Text = table[4].Number.ToString();
                TableCardFiveColour.Text = table[4].Color;
            }
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
