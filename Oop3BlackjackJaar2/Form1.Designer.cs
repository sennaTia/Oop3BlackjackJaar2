namespace Oop3BlackjackJaar2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPoints;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnStart = new Button();
            btnHit = new Button();
            btnStand = new Button();
            lblPlayer = new Label();
            lblAdvice = new Label();
            lblResult = new Label();
            lblPoints = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(339, 421);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 40);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.Click += btnStart_Click;
            // 
            // btnHit
            // 
            btnHit.Location = new Point(461, 300);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(100, 40);
            btnHit.TabIndex = 1;
            btnHit.Text = "Hit";
            btnHit.Click += btnHit_Click;
            // 
            // btnStand
            // 
            btnStand.Location = new Point(583, 240);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(100, 40);
            btnStand.TabIndex = 2;
            btnStand.Text = "Stand";
            btnStand.Click += btnStand_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.Location = new Point(150, 150);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(200, 30);
            lblPlayer.TabIndex = 3;
            lblPlayer.Text = "Speler: 0";
            // 
            // lblAdvice
            // 
            lblAdvice.Location = new Point(150, 200);
            lblAdvice.Name = "lblAdvice";
            lblAdvice.Size = new Size(200, 30);
            lblAdvice.TabIndex = 4;
            lblAdvice.Text = "-";
            // 
            // lblResult
            // 
            lblResult.Location = new Point(150, 250);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(200, 30);
            lblResult.TabIndex = 5;
            lblResult.Text = "-";
            // 
            // lblPoints
            // 
            lblPoints.Location = new Point(150, 300);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(200, 30);
            lblPoints.TabIndex = 6;
            lblPoints.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(85, 44);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(284, 44);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(487, 44);
            button3.Name = "button3";
            button3.Size = new Size(131, 40);
            button3.TabIndex = 9;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(1082, 582);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnStart);
            Controls.Add(btnHit);
            Controls.Add(btnStand);
            Controls.Add(lblPlayer);
            Controls.Add(lblAdvice);
            Controls.Add(lblResult);
            Controls.Add(lblPoints);
            Name = "Form1";
            Text = "Blackjack Dealer Trainer";
            ResumeLayout(false);
        }

        private Button button1;
        private Button button2;
        private Button button3;
    }
}