using System;
using System.Windows.Forms;

namespace Oop3BlackjackJaar2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int playerScore = 0;
        int dealerScore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            dealerScore = 0;

            lblPlayer.Text = "Speler: 0";
            lblDealer.Text = "Dealer: 0";

            playerScore += TrekKaart();
            playerScore += TrekKaart();

            lblPlayer.Text = "Speler: " + playerScore;
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            playerScore += TrekKaart();
            lblPlayer.Text = "Speler: " + playerScore;

            if (playerScore > 21)
            {
                MessageBox.Show("Je bent over 21. Je hebt verloren.");
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            while (dealerScore < 17)
            {
                dealerScore += TrekKaart();
            }

            lblDealer.Text = "Dealer: " + dealerScore;

            if (dealerScore > 21)
            {
                MessageBox.Show("Dealer is over 21. Jij wint.");
            }
            else if (playerScore > dealerScore)
            {
                MessageBox.Show("Jij wint.");
            }
            else if (playerScore < dealerScore)
            {
                MessageBox.Show("Dealer wint.");
            }
            else
            {
                MessageBox.Show("Gelijkspel.");
            }
        }

        private int TrekKaart()
        {
            string[] kaarten = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string kaart = kaarten[rnd.Next(kaarten.Length)];

            int waarde;

            if (kaart == "A")
            {
                waarde = 11;
            }
            else if (kaart == "J" || kaart == "Q" || kaart == "K")
            {
                waarde = 10;
            }
            else
            {
                waarde = int.Parse(kaart);
            }

            MessageBox.Show("Je trok: " + kaart);
            return waarde;
        }

        private void lblDealer_Click(object sender, EventArgs e)
        {

        }
    }
}