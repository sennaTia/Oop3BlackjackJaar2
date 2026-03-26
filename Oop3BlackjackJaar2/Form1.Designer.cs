namespace Oop3BlackjackJaar2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            btnStand = new Button();
            btnHit = new Button();
            btnStart = new Button();
            lblPlayer = new Label();
            lblDealer = new Label();
            SuspendLayout();
            // 
            // btnStand
            // 
            btnStand.Location = new Point(756, 260);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(131, 40);
            btnStand.TabIndex = 0;
            btnStand.Text = "Stand";
            btnStand.UseVisualStyleBackColor = true;
            btnStand.Click += btnStand_Click;
            // 
            // btnHit
            // 
            btnHit.Location = new Point(430, 260);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(131, 40);
            btnHit.TabIndex = 1;
            btnHit.Text = "Hit";
            btnHit.UseVisualStyleBackColor = true;
            btnHit.Click += btnHit_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(106, 260);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(131, 40);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Location = new Point(212, 453);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(92, 30);
            lblPlayer.TabIndex = 3;
            lblPlayer.Text = "Speler: 0";
            // 
            // lblDealer
            // 
            lblDealer.AutoSize = true;
            lblDealer.Location = new Point(631, 453);
            lblDealer.Name = "lblDealer";
            lblDealer.Size = new Size(95, 30);
            lblDealer.TabIndex = 4;
            lblDealer.Text = "Dealer: 0";
            lblDealer.Click += lblDealer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 760);
            Controls.Add(lblDealer);
            Controls.Add(lblPlayer);
            Controls.Add(btnStart);
            Controls.Add(btnHit);
            Controls.Add(btnStand);
            Name = "Form1";
            Text = "Blackjack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStand;
        private Button btnHit;
        private Button btnStart;
        private Label lblPlayer;
        private Label lblDealer;
    }
}