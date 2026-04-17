namespace Oop3BlackjackJaar2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCards;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblMove;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnShuffle = new Button();
            btnStart = new Button();
            btnReset = new Button();
            lblScore = new Label();
            lblCards = new Label();
            lblPlayer = new Label();
            lblMove = new Label();
            SuspendLayout();
            // 
            // btnShuffle
            // 
            btnShuffle.Location = new Point(50, 30);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(150, 40);
            btnShuffle.TabIndex = 0;
            btnShuffle.Text = "Shuffle";
            btnShuffle.Click += btnShuffle_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(220, 30);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 40);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Hand";
            btnStart.Click += btnStart_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(390, 30);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 40);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.Click += btnReset_Click;
            // 
            // lblScore
            // 
            lblScore.Location = new Point(220, 333);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(120, 43);
            lblScore.TabIndex = 4;
            lblScore.Text = "Score: 0";
            // 
            // lblCards
            // 
            lblCards.Location = new Point(37, 439);
            lblCards.Name = "lblCards";
            lblCards.Size = new Size(151, 39);
            lblCards.TabIndex = 5;
            lblCards.Text = "Kaarten: -";
            // 
            // lblPlayer
            // 
            lblPlayer.BackColor = Color.LightBlue;
            lblPlayer.Location = new Point(185, 176);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(200, 60);
            lblPlayer.TabIndex = 3;
            lblPlayer.Text = "Speler";
            lblPlayer.TextAlign = ContentAlignment.MiddleCenter;
            lblPlayer.Click += lblPlayer_Click;
            // 
            // lblMove
            // 
            lblMove.Location = new Point(440, 439);
            lblMove.Name = "lblMove";
            lblMove.Size = new Size(100, 39);
            lblMove.TabIndex = 6;
            lblMove.Text = "Speler wil: -";
            // 
            // Form1
            // 
            ClientSize = new Size(600, 500);
            Controls.Add(btnShuffle);
            Controls.Add(btnStart);
            Controls.Add(btnReset);
            Controls.Add(lblPlayer);
            Controls.Add(lblScore);
            Controls.Add(lblCards);
            Controls.Add(lblMove);
            Name = "Form1";
            Text = "Blackjack Trainer";
            ResumeLayout(false);
        }
    }
}