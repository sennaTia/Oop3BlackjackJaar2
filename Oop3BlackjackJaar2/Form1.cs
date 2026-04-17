using System;
using System.Windows.Forms;

namespace Oop3BlackjackJaar2
{
    public partial class Form1 : Form
    {
        Shoe shoe = new Shoe();
        Hand hand = new Hand();
        Hand dealerHand = new Hand();

        bool playerDone = false;

        public Form1()
        {
            InitializeComponent();
        }

        // START
        private void btnStart_Click(object sender, EventArgs e)
        {
            hand = new Hand();
            dealerHand = new Hand();
            playerDone = false;

            hand.AddCard(shoe.DrawCard());
            hand.AddCard(shoe.DrawCard());

            UpdateUI();

            lblMove.Text = "Klik op speler";
            lblDealer.Text = "Dealer: -";
        }

        // SHUFFLE
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            shoe = new Shoe();
            MessageBox.Show("Deck geschud!");
        }

        // RESET
        private void btnReset_Click(object sender, EventArgs e)
        {
            hand = new Hand();
            dealerHand = new Hand();
            shoe = new Shoe();

            lblScore.Text = "Score: 0";
            lblCards.Text = "Kaarten: -";
            lblMove.Text = "Speler wil: -";
            lblDealer.Text = "Dealer: -";
        }

        // KLIK OP SPELER
        private void lblPlayer_Click(object sender, EventArgs e)
        {
            if (playerDone) return;

            int score = hand.GetScore();

            // bust
            if (score > 21)
            {
                lblMove.Text = "Speler busted!";
                playerDone = true;
                return;
            }

            // speler AI
            if (score <= 15)
            {
                lblMove.Text = "Speler wil: HIT";

                hand.AddCard(shoe.DrawCard());
                UpdateUI();
            }
            else
            {
                lblMove.Text = "Speler wil: STAND";
                playerDone = true;

                StartDealer();
            }
        }

        // DEALER START
        void StartDealer()
        {
            dealerHand.AddCard(shoe.DrawCard());
            dealerHand.AddCard(shoe.DrawCard());

            // 1 kaart zichtbaar
            lblDealer.Text = "Dealer: " + dealerHand.Cards[0].Value + " ?";
        }

        // UI UPDATE
        void UpdateUI()
        {
            lblScore.Text = "Score: " + hand.GetScore();

            lblCards.Text = "Kaarten: ";
            foreach (var c in hand.Cards)
            {
                lblCards.Text += c.Value + " ";
            }
        }
    }
}