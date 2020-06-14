using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace termproject
{

    public partial class PlayForm : Form
    {
        Profile goalieProfile;
        Profile playerProfile;
        Game game;
        bool goalieIsHuman;
        bool playerIsHuman;

        Random rand = new Random((int)DateTime.Now.Ticks);

        int goalieScore;
        int playerScore;

        bool playerHasBall = true;
        int time = 0;
        int ballspeed = 10;
        int ballspeedboost = 0;
        int goalieSpeed = 4;
        bool goalieHasShield;


        public PlayForm(bool goalieIsHuman, bool playerIsHuman, Profile goalie, Profile player)
        {
            InitializeComponent();
            this.goalieIsHuman = goalieIsHuman;
            this.playerIsHuman = playerIsHuman;
            this.goalieProfile = goalie;
            this.playerProfile = player;

            game = new Game();
            game.Date = DateTime.Now;
            game.Goalie = goalie;
            game.Player = player;

            if (goalieProfile.Name.ToLower() != "computer")
                this.goalie.Image = goalie.Avatar;
            if (playerProfile.Name.ToLower() != "computer")
                playerPB.Image = playerProfile.Avatar;
            
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            timeL.Text = time++.ToString();
        }

        bool pbinc = true;
        private void PlayForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (playerIsHuman)
            {
                // player kick
                if (e.KeyCode == Keys.Space && kickForceTimer.Enabled == false && playerHasBall)
                {
                    kickForceTimer.Start();
                }
                // player movement
                if (e.KeyCode == Keys.Up && playerHasBall)
                {
                    playerUp = true;
                }
                if (e.KeyCode == Keys.Down && playerHasBall)
                {
                    playerDown = true;
                }
                if (e.KeyCode == Keys.Left)
                {
                    playerLeft = true;
                }
                if (e.KeyCode == Keys.Right)
                {
                    playerRight = true;
                }
            }
            
            if (goalieIsHuman)
            {
                // goalie movement
                if (e.KeyCode == Keys.W)
                {
                    goalieUp = true;
                }
                if (e.KeyCode == Keys.S)
                {
                    goalieDown = true;
                }
                if (e.KeyCode == Keys.A)
                {
                    goalieLeft = true;
                }
                if (e.KeyCode == Keys.D)
                {
                    goalieRight = true;
                }
            }
            
        }

        private void PlayForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (playerIsHuman)
            {
                // player kick
                if (e.KeyCode == Keys.Space && playerHasBall)
                {
                    ballspeed = progressBar1.Value / 10;
                    if (ballspeed == 0)
                        ballspeed = 1;
                    kickForceTimer.Stop();
                    kick();
                    progressBar1.Value = 0;
                    pbinc = true;
                }
                // player movement
                if (e.KeyCode == Keys.Up)
                {
                    playerUp = false;
                }
                if (e.KeyCode == Keys.Down)
                {
                    playerDown = false;
                }
                if (e.KeyCode == Keys.Left)
                {
                    playerLeft = false;
                }
                if (e.KeyCode == Keys.Right)
                {
                    playerRight = false;
                }
            }
            
            if (goalieIsHuman)
            {
                // goalie movement
                if (e.KeyCode == Keys.W)
                {
                    goalieUp = false;
                }
                if (e.KeyCode == Keys.S)
                {
                    goalieDown = false;
                }
                if (e.KeyCode == Keys.A)
                {
                    goalieLeft = false;
                }
                if (e.KeyCode == Keys.D)
                {
                    goalieRight = false;
                }
            }
        }

        private void kickForceTimer_Tick(object sender, EventArgs e)
        {
            if (pbinc)
            {
                progressBar1.Value += 4;
                if (progressBar1.Value == 100)
                {
                    pbinc = false;
                }
            }
            else
            {
                progressBar1.Value -= 4;
                if (progressBar1.Value == 0)
                {
                    pbinc = true;
                }
            }
        }


        int timeout = 20;
        private void timeoutTimer_Tick(object sender, EventArgs e)
        {
            timeout--;
            timeoutL.Text = timeout.ToString();
            if (timeout == 0)
            {
                kick();
            }
        }

        private void kick()
        {
            moveBall.Start();
            timeoutTimer.Stop();
            timeout = 20;
            playerHasBall = false;
            progressBar1.Value = 0;
        }

        bool goalieLeft, goalieRight, goalieUp, goalieDown;
        bool playerLeft, playerRight, playerUp, playerDown;

        private void moveBall_Tick(object sender, EventArgs e)
        {
            soccerball.Location = new Point(soccerball.Location.X - (ballspeed + ballspeedboost), soccerball.Location.Y);


            if (basketballPB.Visible)
            {
                if (soccerball.Bounds.IntersectsWith(basketballPB.Bounds))
                {
                    updatePlayerScore(-1);
                    resetBallPos();
                    basketballPB.Location = new Point(489, 109);
                }
            }
            if (hole.Visible)
            {
                if (soccerball.Bounds.IntersectsWith(hole.Bounds))
                {
                    resetBallPos();
                }
            }
            if (spiral.Visible)
            {
                if (soccerball.Bounds.IntersectsWith(spiral.Bounds))
                {
                    soccerball.Top += 50;
                }
            }


            if (soccerball.Bounds.IntersectsWith(goalie.Bounds))
            {
                updateGoalieScore(1);
                resetBallPos();
            }
            else if (soccerball.Left < goal.Right && soccerball.Top > goal.Top && soccerball.Bottom < goal.Bottom)
            {
                if (goalieHasShield)
                {
                    goalieHasShield = false;
                    resetBallPos();
                }
                else
                {
                    updatePlayerScore(1);
                    resetBallPos();
                }
            }
            else if (soccerball.Left <= 0)
            {
                resetBallPos();
            }
        }

        private void resetBallPos()
        {
            soccerball.Location = new Point(626, 312);
            moveBall.Stop();
            timeoutL.Text = "20";
            timeoutTimer.Start();
            playerHasBall = true;
        }
        bool rewardsSpawned;
        private void rewardSpawner_Tick(object sender, EventArgs e)
        {
            if (!rewardsSpawned)
            {
                if (rand.Next(10) < 3)
                {
                    speedboostPB.Visible = true;
                    shieldPB.Visible = true;
                    speedboostPB.Top = -36;
                    shieldPB.Top = -36;
                    rewardMove.Start();
                    rewardsSpawned = true;
                }
            }
        }
        private void rewardMove_Tick(object sender, EventArgs e)
        {
            speedboostPB.Top += 5;
            shieldPB.Top += 5;

            if (speedboostPB.Bounds.IntersectsWith(player.Bounds))
            {
                ballspeedboost = 10;
                speedboostPB.Visible = false;
            }
            if (shieldPB.Bounds.IntersectsWith(goalie.Bounds))
            {
                goalieHasShield = true;
                shieldPB.Visible = false;
            }

            if (speedboostPB.Top > 657)
            {
                speedboostPB.Visible = false;
            }
            if (shieldPB.Top > 657)
            {
                shieldPB.Visible = false;
            }

            if (!speedboostPB.Visible && !shieldPB.Visible)
            {
                rewardsSpawned = false;
            }
        }

        private void goalieVertical_Tick(object sender, EventArgs e)
        {
            if (goalieUp && goalie.Location.Y > 0)
            {
                goalie.Location = new Point(goalie.Location.X, goalie.Location.Y - goalieSpeed);
            }
            else if (goalieDown && goalie.Location.Y < 557)
            {
                goalie.Location = new Point(goalie.Location.X, goalie.Location.Y + goalieSpeed);
            }
        }
        private void goalieHorizontal_Tick(object sender, EventArgs e)
        {
            if (goalieLeft && goalie.Location.X > 124)
            {
                goalie.Location = new Point(goalie.Location.X - goalieSpeed, goalie.Location.Y);
            }
            else if (goalieRight && goalie.Location.X < 333)
            {
                goalie.Location = new Point(goalie.Location.X + goalieSpeed, goalie.Location.Y);
            }
        }

        private void distBallMove_Tick(object sender, EventArgs e)
        {
            basketballPB.Top += 5;
            if (basketballPB.Top > 657)
            {
                basketballPB.Top = 109;
            }
        }

        private void playerVertical_Tick(object sender, EventArgs e)
        {
            if (playerUp && soccerball.Location.Y > 100)
            {
                soccerball.Location = new Point(soccerball.Location.X, soccerball.Location.Y - 5);
            }
            else if (playerDown && soccerball.Location.Y < 507)
            {
                soccerball.Location = new Point(soccerball.Location.X, soccerball.Location.Y + 5);
            }
        }

        private void PlayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            finalize(null);
        }

        bool computerGoalieDir = true;
        private void computerGoalie_Tick(object sender, EventArgs e)
        {
            if (goalieIsHuman)
                return;

            if (computerGoalieDir)
            {
                goalie.Top += goalieSpeed;
                goalie.Left++;
            }
            else
            {
                goalie.Top -= goalieSpeed;
                goalie.Left--;
            }

            if (goalie.Top < 100 || goalie.Bottom > 507)
                computerGoalieDir = !computerGoalieDir;
        }
        bool computerPlayerDir = true;

        private void computerPlayer_Tick(object sender, EventArgs e)
        {
            if (playerIsHuman)
                return;

            if (playerHasBall)
            {
                if (rand.Next(100) < 5)
                {
                    ballspeed = rand.Next(9) + 2;
                    kick();
                }


                if (computerPlayerDir)
                {
                    soccerball.Top += 5;
                }
                else
                {
                    soccerball.Top -= 5;
                }
            }

            if (soccerball.Top < 120 || soccerball.Bottom > 487)
                computerPlayerDir = !computerPlayerDir;
        }

        private void playerHorizontal_Tick(object sender, EventArgs e)
        {
            if (playerLeft && player.Location.X > 700)
            {
                player.Location = new Point(player.Location.X - 5, player.Location.Y);
            }
            else if (playerRight && player.Location.X < 908)
            {
                player.Location = new Point(player.Location.X + 5, player.Location.Y);
            }
        }

        private void setupLevel2()
        {
            distractorPB.Visible = true;
            basketballPB.Visible = true;
            goal.Height = 300;
            goal.Top -= 30;
            goalieSpeed += 2;
            distBallMove.Start();
            label4.Text = "Level: 2";
        }
        private void setupLevel3()
        {
            hole.Visible = true;
            spiral.Visible = true;
            goalieSpeed += 2;
            label4.Text = "Level: 3";

            rewardSpawner.Start();
        }
        private void finalize(Profile winner)
        {
            game.Duration = time;
            game.GoalieScore = goalieScore;
            game.PlayerScore = playerScore;
            if (winner != null)
                MessageBox.Show("Game finished and the winner is " + winner.Name + ".");
            Program.games.Add(game);
            this.Dispose();
        }

        private void updatePlayerScore(int amount)
        {
            playerScore += amount;
            pScoreL.Text = playerScore.ToString();
            if (playerScore == 5)
            {
                setupLevel2();
            }
            else if (playerScore == 10)
            {
                setupLevel3();
            }
            else if (playerScore == 15)
            {
                finalize(playerProfile);
            }

            if (playerScore < 0)
            {
                playerScore = 0;
                pScoreL.Text = playerScore.ToString();
            }
        }
        private void updateGoalieScore(int amount)
        {
            goalieScore += amount;
            gScoreL.Text = goalieScore.ToString();
            if (goalieScore == 5)
            {
                setupLevel2();
            }
            else if (goalieScore == 10)
            {
                setupLevel3();
            }
            else if (goalieScore == 15)
            {
                finalize(goalieProfile);
            }
        }
    }
}
