namespace termproject
{
    partial class PlayForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.timeL = new System.Windows.Forms.Label();
            this.gScoreL = new System.Windows.Forms.Label();
            this.pScoreL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timeoutL = new System.Windows.Forms.Label();
            this.soccerball = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.Panel();
            this.playerPB = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.speedboostPB = new System.Windows.Forms.PictureBox();
            this.shieldPB = new System.Windows.Forms.PictureBox();
            this.spiral = new System.Windows.Forms.PictureBox();
            this.hole = new System.Windows.Forms.PictureBox();
            this.basketballPB = new System.Windows.Forms.PictureBox();
            this.distractorPB = new System.Windows.Forms.PictureBox();
            this.goal = new System.Windows.Forms.PictureBox();
            this.goalie = new System.Windows.Forms.PictureBox();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.kickForceTimer = new System.Windows.Forms.Timer(this.components);
            this.timeoutTimer = new System.Windows.Forms.Timer(this.components);
            this.goalieHorizontal = new System.Windows.Forms.Timer(this.components);
            this.goalieVertical = new System.Windows.Forms.Timer(this.components);
            this.playerVertical = new System.Windows.Forms.Timer(this.components);
            this.playerHorizontal = new System.Windows.Forms.Timer(this.components);
            this.moveBall = new System.Windows.Forms.Timer(this.components);
            this.distBallMove = new System.Windows.Forms.Timer(this.components);
            this.rewardSpawner = new System.Windows.Forms.Timer(this.components);
            this.rewardMove = new System.Windows.Forms.Timer(this.components);
            this.computerGoalie = new System.Windows.Forms.Timer(this.components);
            this.computerPlayer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soccerball)).BeginInit();
            this.player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedboostPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketballPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distractorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::termproject.Properties.Resources.panel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.timeL);
            this.panel1.Controls.Add(this.gScoreL);
            this.panel1.Controls.Add(this.pScoreL);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1029, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 184);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Level: 1";
            // 
            // timeL
            // 
            this.timeL.AutoSize = true;
            this.timeL.BackColor = System.Drawing.Color.Transparent;
            this.timeL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeL.Location = new System.Drawing.Point(92, 137);
            this.timeL.Name = "timeL";
            this.timeL.Size = new System.Drawing.Size(18, 19);
            this.timeL.TabIndex = 0;
            this.timeL.Text = "0";
            // 
            // gScoreL
            // 
            this.gScoreL.AutoSize = true;
            this.gScoreL.BackColor = System.Drawing.Color.Transparent;
            this.gScoreL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gScoreL.Location = new System.Drawing.Point(135, 98);
            this.gScoreL.Name = "gScoreL";
            this.gScoreL.Size = new System.Drawing.Size(18, 19);
            this.gScoreL.TabIndex = 0;
            this.gScoreL.Text = "0";
            // 
            // pScoreL
            // 
            this.pScoreL.AutoSize = true;
            this.pScoreL.BackColor = System.Drawing.Color.Transparent;
            this.pScoreL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pScoreL.Location = new System.Drawing.Point(135, 57);
            this.pScoreL.Name = "pScoreL";
            this.pScoreL.Size = new System.Drawing.Size(18, 19);
            this.pScoreL.TabIndex = 0;
            this.pScoreL.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Goalie Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Score:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.soccerball);
            this.panel2.Controls.Add(this.player);
            this.panel2.Controls.Add(this.speedboostPB);
            this.panel2.Controls.Add(this.shieldPB);
            this.panel2.Controls.Add(this.spiral);
            this.panel2.Controls.Add(this.hole);
            this.panel2.Controls.Add(this.basketballPB);
            this.panel2.Controls.Add(this.distractorPB);
            this.panel2.Controls.Add(this.goal);
            this.panel2.Controls.Add(this.goalie);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 657);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::termproject.Properties.Resources.hourglass;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.timeoutL);
            this.panel3.Location = new System.Drawing.Point(953, 323);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(55, 61);
            this.panel3.TabIndex = 2;
            // 
            // timeoutL
            // 
            this.timeoutL.BackColor = System.Drawing.Color.Transparent;
            this.timeoutL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeoutL.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeoutL.ForeColor = System.Drawing.Color.Red;
            this.timeoutL.Location = new System.Drawing.Point(0, 0);
            this.timeoutL.Name = "timeoutL";
            this.timeoutL.Size = new System.Drawing.Size(55, 61);
            this.timeoutL.TabIndex = 0;
            this.timeoutL.Text = "20";
            this.timeoutL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soccerball
            // 
            this.soccerball.BackColor = System.Drawing.Color.Transparent;
            this.soccerball.Image = global::termproject.Properties.Resources.ball;
            this.soccerball.Location = new System.Drawing.Point(626, 312);
            this.soccerball.Name = "soccerball";
            this.soccerball.Size = new System.Drawing.Size(50, 50);
            this.soccerball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.soccerball.TabIndex = 0;
            this.soccerball.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Controls.Add(this.playerPB);
            this.player.Controls.Add(this.progressBar1);
            this.player.Location = new System.Drawing.Point(836, 284);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 120);
            this.player.TabIndex = 2;
            // 
            // playerPB
            // 
            this.playerPB.BackColor = System.Drawing.Color.Transparent;
            this.playerPB.Image = global::termproject.Properties.Resources.p1;
            this.playerPB.Location = new System.Drawing.Point(0, 0);
            this.playerPB.Margin = new System.Windows.Forms.Padding(0);
            this.playerPB.Name = "playerPB";
            this.playerPB.Size = new System.Drawing.Size(100, 100);
            this.playerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPB.TabIndex = 0;
            this.playerPB.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Snow;
            this.progressBar1.Location = new System.Drawing.Point(0, 100);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 20);
            this.progressBar1.TabIndex = 1;
            // 
            // speedboostPB
            // 
            this.speedboostPB.BackColor = System.Drawing.Color.Transparent;
            this.speedboostPB.Image = global::termproject.Properties.Resources.speedboost;
            this.speedboostPB.Location = new System.Drawing.Point(749, -36);
            this.speedboostPB.Name = "speedboostPB";
            this.speedboostPB.Size = new System.Drawing.Size(50, 50);
            this.speedboostPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.speedboostPB.TabIndex = 0;
            this.speedboostPB.TabStop = false;
            this.speedboostPB.Visible = false;
            // 
            // shieldPB
            // 
            this.shieldPB.BackColor = System.Drawing.Color.Transparent;
            this.shieldPB.Image = global::termproject.Properties.Resources.shield;
            this.shieldPB.Location = new System.Drawing.Point(160, -44);
            this.shieldPB.Name = "shieldPB";
            this.shieldPB.Size = new System.Drawing.Size(50, 50);
            this.shieldPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shieldPB.TabIndex = 0;
            this.shieldPB.TabStop = false;
            this.shieldPB.Visible = false;
            // 
            // spiral
            // 
            this.spiral.BackColor = System.Drawing.Color.Transparent;
            this.spiral.Image = global::termproject.Properties.Resources.spiral;
            this.spiral.Location = new System.Drawing.Point(388, 218);
            this.spiral.Name = "spiral";
            this.spiral.Size = new System.Drawing.Size(50, 50);
            this.spiral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spiral.TabIndex = 0;
            this.spiral.TabStop = false;
            this.spiral.Visible = false;
            // 
            // hole
            // 
            this.hole.BackColor = System.Drawing.Color.Transparent;
            this.hole.Image = global::termproject.Properties.Resources.hole;
            this.hole.Location = new System.Drawing.Point(365, 397);
            this.hole.Name = "hole";
            this.hole.Size = new System.Drawing.Size(100, 50);
            this.hole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hole.TabIndex = 0;
            this.hole.TabStop = false;
            this.hole.Visible = false;
            // 
            // basketballPB
            // 
            this.basketballPB.BackColor = System.Drawing.Color.Transparent;
            this.basketballPB.Image = global::termproject.Properties.Resources.distball;
            this.basketballPB.Location = new System.Drawing.Point(489, 109);
            this.basketballPB.Name = "basketballPB";
            this.basketballPB.Size = new System.Drawing.Size(50, 50);
            this.basketballPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.basketballPB.TabIndex = 0;
            this.basketballPB.TabStop = false;
            this.basketballPB.Visible = false;
            // 
            // distractorPB
            // 
            this.distractorPB.BackColor = System.Drawing.Color.Transparent;
            this.distractorPB.Image = global::termproject.Properties.Resources.dist;
            this.distractorPB.Location = new System.Drawing.Point(470, 3);
            this.distractorPB.Name = "distractorPB";
            this.distractorPB.Size = new System.Drawing.Size(100, 100);
            this.distractorPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.distractorPB.TabIndex = 0;
            this.distractorPB.TabStop = false;
            this.distractorPB.Visible = false;
            // 
            // goal
            // 
            this.goal.BackColor = System.Drawing.Color.Transparent;
            this.goal.Image = global::termproject.Properties.Resources.goal;
            this.goal.Location = new System.Drawing.Point(18, 207);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(100, 240);
            this.goal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goal.TabIndex = 0;
            this.goal.TabStop = false;
            // 
            // goalie
            // 
            this.goalie.BackColor = System.Drawing.Color.Transparent;
            this.goalie.Image = global::termproject.Properties.Resources.p2g;
            this.goalie.Location = new System.Drawing.Point(159, 284);
            this.goalie.Name = "goalie";
            this.goalie.Size = new System.Drawing.Size(100, 100);
            this.goalie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goalie.TabIndex = 0;
            this.goalie.TabStop = false;
            // 
            // timeTimer
            // 
            this.timeTimer.Enabled = true;
            this.timeTimer.Interval = 1000;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // kickForceTimer
            // 
            this.kickForceTimer.Tick += new System.EventHandler(this.kickForceTimer_Tick);
            // 
            // timeoutTimer
            // 
            this.timeoutTimer.Enabled = true;
            this.timeoutTimer.Interval = 1000;
            this.timeoutTimer.Tick += new System.EventHandler(this.timeoutTimer_Tick);
            // 
            // goalieHorizontal
            // 
            this.goalieHorizontal.Enabled = true;
            this.goalieHorizontal.Interval = 50;
            this.goalieHorizontal.Tick += new System.EventHandler(this.goalieHorizontal_Tick);
            // 
            // goalieVertical
            // 
            this.goalieVertical.Enabled = true;
            this.goalieVertical.Interval = 50;
            this.goalieVertical.Tick += new System.EventHandler(this.goalieVertical_Tick);
            // 
            // playerVertical
            // 
            this.playerVertical.Enabled = true;
            this.playerVertical.Interval = 50;
            this.playerVertical.Tick += new System.EventHandler(this.playerVertical_Tick);
            // 
            // playerHorizontal
            // 
            this.playerHorizontal.Enabled = true;
            this.playerHorizontal.Interval = 50;
            this.playerHorizontal.Tick += new System.EventHandler(this.playerHorizontal_Tick);
            // 
            // moveBall
            // 
            this.moveBall.Interval = 50;
            this.moveBall.Tick += new System.EventHandler(this.moveBall_Tick);
            // 
            // distBallMove
            // 
            this.distBallMove.Interval = 50;
            this.distBallMove.Tick += new System.EventHandler(this.distBallMove_Tick);
            // 
            // rewardSpawner
            // 
            this.rewardSpawner.Interval = 1000;
            this.rewardSpawner.Tick += new System.EventHandler(this.rewardSpawner_Tick);
            // 
            // rewardMove
            // 
            this.rewardMove.Interval = 50;
            this.rewardMove.Tick += new System.EventHandler(this.rewardMove_Tick);
            // 
            // computerGoalie
            // 
            this.computerGoalie.Enabled = true;
            this.computerGoalie.Interval = 50;
            this.computerGoalie.Tick += new System.EventHandler(this.computerGoalie_Tick);
            // 
            // computerPlayer
            // 
            this.computerPlayer.Enabled = true;
            this.computerPlayer.Interval = 50;
            this.computerPlayer.Tick += new System.EventHandler(this.computerPlayer_Tick);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::termproject.Properties.Resources.wp2;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PlayForm_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soccerball)).EndInit();
            this.player.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedboostPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketballPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distractorPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timeL;
        private System.Windows.Forms.Label gScoreL;
        private System.Windows.Forms.Label pScoreL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox distractorPB;
        private System.Windows.Forms.PictureBox playerPB;
        private System.Windows.Forms.PictureBox basketballPB;
        private System.Windows.Forms.Panel player;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox soccerball;
        private System.Windows.Forms.PictureBox goal;
        private System.Windows.Forms.PictureBox goalie;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Timer kickForceTimer;
        private System.Windows.Forms.Timer timeoutTimer;
        private System.Windows.Forms.Timer goalieHorizontal;
        private System.Windows.Forms.Timer goalieVertical;
        private System.Windows.Forms.Timer playerVertical;
        private System.Windows.Forms.Timer playerHorizontal;
        private System.Windows.Forms.PictureBox speedboostPB;
        private System.Windows.Forms.PictureBox shieldPB;
        private System.Windows.Forms.Timer moveBall;
        private System.Windows.Forms.Label timeoutL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox hole;
        private System.Windows.Forms.PictureBox spiral;
        private System.Windows.Forms.Timer distBallMove;
        private System.Windows.Forms.Timer rewardSpawner;
        private System.Windows.Forms.Timer rewardMove;
        private System.Windows.Forms.Timer computerGoalie;
        private System.Windows.Forms.Timer computerPlayer;
    }
}