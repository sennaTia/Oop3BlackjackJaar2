using System;
using System.Windows.Forms;

namespace Oop3BlackjackJaar2
{
    public partial class Form1 : Form
    {
        GameManager game;
        DecisionChecker checker = new DecisionChecker();
        int dealerPoints = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            game = new GameManager();

            game.AddPlayer("Speler 1");
            game.AddPlayer("Speler 2");

            game.DealCards();
            game.NextPlayer();

            ShowPlayer();
        }

        void ShowPlayer()
        {
            var p = game.CurrentPlayer;

            int score = p.Hand.GetScore();

            lblPlayer.Text = "Speler: " + score;

            string advies = checker.GetCorrectMove(p.Hand);
            lblAdvice.Text = advies.ToUpper();
        }

        void Check(string keuze)
        {
            var p = game.CurrentPlayer;

            bool correct = checker.Check(p.Hand, keuze);

            if (correct)
            {
                lblResult.Text = "Goed!";
                dealerPoints++;
            }
            else
            {
                lblResult.Text = "Fout!";
                dealerPoints--;
            }

            lblPoints.Text = dealerPoints.ToString();

            if (keuze == "hit")
            {
                p.Hand.AddCard(game.Shoe.DrawCard());
            }

            game.NextPlayer();

            if (game.CurrentPlayer != null)
                ShowPlayer();
            else
                MessageBox.Show("Klaar!");
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            Check("hit");
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            Check("stand");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}