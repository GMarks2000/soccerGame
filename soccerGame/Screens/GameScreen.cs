using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace soccerGame.Screens
{
    public partial class GameScreen : UserControl
    {
        #region global variables
        //keypress bools
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, jDown, lDown, spaceDown, escapeDown, aDown, sDown, dDown, wDown, qDown, eDown, enterDown;

        int playerWidth, playerLength, ballSize, ticksSinceShot, ticks, timeLeft, startX, endX, startY, endY, netWidth, netHeight, redScore, blueScore;

        string lastTouch = "";

        bool isSuddenDeath;

        SolidBrush drawBrush = new SolidBrush(Color.White);

        Pen drawPen = new Pen(Color.Black);

        //player declarations
        Player p1, p2;
        List<Player> players = new List<Player>();

        //ball declaration
        Ball b;

        //goalie declarations
        Goalkeeper g1, g2;
        List<Goalkeeper> goalkeepers = new List<Goalkeeper>();
        #endregion
        
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        //start method
        private void OnStart()
        {
            this.Focus();

            playerLength = 12;
            playerWidth = 24;
            ballSize = 10;
            ticksSinceShot = 0;
            ticks = 0;
            timeLeft = 300;

            startX = 125;
            startY = 14;
            endX = 1175;
            endY = 687;

            netWidth = 36;
            netHeight = 90;

            redScore = blueScore = 0;

            isSuddenDeath = false;

            //player construtions
            p1 = new Player(this.Width / 4, this.Height / 2, 0, 0, 0.3, 0.85, 90, 5, playerWidth, playerLength, 30, 0, false, Color.Red, false);
            p2 = new Player(this.Width * 3 / 4, this.Height / 2, 0, 0, 0.3, 0.85, 270, 5, playerWidth, playerLength, 30, 0, false, Color.Blue, false);
            players.Add(p1);
            players.Add(p2);

            //goalie constructions
            g1 = new Goalkeeper(startX + 20, this.Height / 2, 1, 90, playerWidth, playerLength, 30, 0, false, Color.LightGreen);
            g2 = new Goalkeeper(endX - netWidth - 20, this.Height / 2, 1, 270, playerWidth, playerLength, 30, 0, false, Color.LightGreen);
            goalkeepers.Add(g1);
            goalkeepers.Add(g2);


            b = new Ball(this.Width / 2, this.Height / 2, ballSize, -1, -1, 0.2, true);
        }

        #region key methods
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.Escape :
                    escapeDown = false;
                    break;
                case Keys.K:
                    enterDown = false;
                    break;
                case Keys.J:
                    jDown = false;
                    break;
                case Keys.L:
                    lDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.Q:
                    qDown = false;
                    break;
                case Keys.E:
                    eDown = false;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.Escape:
                    escapeDown = true;
                    handlePause();
                    break;
                case Keys.K:
                    enterDown = true;
                    break;
                case Keys.J:
                    jDown = true;
                    break;
                case Keys.L:
                    lDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.Q:
                    qDown = true;
                    break;
                case Keys.E:
                    eDown = true;
                    break;
                default:
                    break;
            }
        }
        #endregion

        //tick method
        private void timer_Tick(object sender, EventArgs e)
        {

            if (spaceDown)
                p1.actionKeyDown = true;
            else p1.actionKeyDown = false;

            if (enterDown)
                p2.actionKeyDown = true;
            else p2.actionKeyDown = false;

            //player can only move if they are not in a tackle
            if (p1.tackleTicks == 0)
            {
                AccelerateP1();
            }
            else
            {
                p1.Accelerate("none", "none");
            }
            if (p2.tackleTicks == 0)
            {
                AccelerateP2();
            }
            else
            {
                p2.Accelerate("none", "none");
            }

            //goalie code
            foreach (Goalkeeper g in goalkeepers)
            {   
                //goalies only move if the ball is in their half
                if (Math.Abs(b.x - g.x) < (endX - startX) / 2)
                    g.Move(b, (endY - startY) / 2 + netHeight / 2, (endY - startY) / 2 - netHeight / 2);

                //collision with ball
                if (g.checkCollision(b) && g.ticksSinceLost >= 5)
                {   
                    //goalie deflects or acquires ball depending on its speed
                    if (Math.Sqrt(b.xSpeed * b.xSpeed + b.ySpeed * b.ySpeed) > 8)
                    {
                        b.xSpeed *= -1;
                        g.ticksSinceLost = 0;
                    }
                    else
                    {
                        g.hasBall = true;
                        b.isFree = false;
                        p1.hasBall = p2.hasBall = false;
                    }
                }

                //increments goalie loss ticks
                if (g.ticksSinceLost <= 5)
                    g.ticksSinceLost++;

                //places ball in front of posessive goalie
                if (g.hasBall)
                {
                    int a = g.width / 2 - b.size / 2;
                    b.x = g.x + a;
                    b.y = g.y;

                    //alters ball x and y to always remain same distance from a rotating player
                    b.x += Convert.ToInt16(12 * Math.Sin(g.angle * Math.PI / 180));
                    b.y -= Convert.ToInt16(12 * Math.Cos(g.angle * Math.PI / 180));
                    g.ticksSinceGot++;
                }

                //goalie shoots after 50 frames, with somewhat randomized strength
                if (g.ticksSinceGot >= 50 && g.hasBall)
                {
                    Random rand = new Random();
                    int a = rand.Next(80, 111);
                    int d = rand.Next(0, 21);
                    int c = rand.Next(0, 2);

                    if (c == 1)
                        d *= -1;

                    b.OnShot(a, g.angle + d);

                    g.hasBall = false;
                    b.isFree = true;
                    g.ticksSinceGot = 0;
                    g.ticksSinceLost = 0;
                }
            }
            //assorted code for each player
            foreach (Player p in players)
            {
                p.Move();

                //places ball in front of posessive player
                if (p.hasBall)
                {
                    int a = p.width / 2 - b.size / 2;
                    b.x = p.x + a;
                    b.y = p.y;

                    //alters ball x and y to always remain same distance from a rotating player
                    b.x += Convert.ToInt16(12 * Math.Sin(p.angle * Math.PI / 180));
                    b.y -= Convert.ToInt16(12 * Math.Cos(p.angle * Math.PI / 180));
                }

                //player cannot reclaim ball until 30 frames (half a second) after loss.
                if (p.ticksSinceLost < 10)
                    p.ticksSinceLost++;

                //increases shot strength when appropriate
                if (p.actionKeyDown && p.hasBall)
                    ticksSinceShot++;


                //releases a shot ball when space is released or when 180 frames of charge are built up.
                if ((p.actionKeyDown  == false && p.hasBall && ticksSinceShot > 0) || (p.hasBall && ticksSinceShot >= 60))
                {
                    p.hasBall = false;
                    b.isFree = true;

                    //calls shot method
                    b.OnShot(ticksSinceShot, p.angle);

                    ticksSinceShot = 0;
                    p.ticksSinceLost = 0;
                }

                //tackle code
                if (p.actionKeyDown && p.hasBall == false && p.tackleTicks == 0)
                {
                    p.startTackle();
                }

                //tackle resetting code
                if (p.tackleTicks > 0)
                {
                    p.tackleTicks++;
                    if (p.tackleTicks >= 25)
                    {
                        p.tackleTicks = 0;
                    }
                }
            }
            //checkpoint

            //ball movement
            if (b.isFree)
            {
                b.Move();
                b.Decelerate();
            }

            //ball collision checking
            if (b.CheckPlayer(p1) && p1.ticksSinceLost >= 10 && p1.hasBall == false)
            {
                b.isFree = false;

                if (p2.hasBall)
                {
                    p2.hasBall = false;
                    p2.ticksSinceLost = 0;
                }

                p1.hasBall = true;
                lastTouch = "red";
            }

            if (b.CheckPlayer(p2) && p2.ticksSinceLost >= 10 && p2.hasBall == false)
            {
                b.isFree = false;

                if (p1.hasBall)
                {
                    p1.hasBall = false;
                    p1.ticksSinceLost = 0;
                }
                p2.hasBall = true;
                lastTouch = "blue";
            }

            //offscreen ball detection (ball given to opponent of last toucher)
            if (b.CheckOOB(startX, endX , startY, endY)  && b.CheckGoal(startX, endX, startY, endY, netWidth, netHeight) == "no goal")
            {
                if (lastTouch == "red")
                {
                    p2.hasBall = true;
                    p1.hasBall = false;
                    lastTouch = "blue";
                }
                else if (lastTouch == "blue")
                {
                    p1.hasBall = true;
                    p2.hasBall = false;
                    lastTouch = "red";
                }
                p1.x = this.Width / 4;
                p1.y = this.Height / 2;
                p1.angle = 90;
                

                p2.x = this.Width * 3 / 4;
                p2.y = this.Height / 2;
                p2.angle = 270;

                p1.xSpeed = p1.ySpeed = p2.xSpeed = p2.ySpeed = 1;

                Refresh();
                Thread.Sleep(2000);
            }

            //checks for  goal
            if (b.CheckGoal(startX, endX, startY, endY, netWidth, netHeight) != "no goal")
            {   
                //red goal
                if (b.CheckGoal(startX, endX, startY, endY, netWidth, netHeight) == "red goal")
                {
                    redScore++;
                    redScoreLabel.Text = redScore.ToString();                  
                }

                //blue goal
                else if (b.CheckGoal(startX, endX, startY, endY, netWidth, netHeight) == "blue goal")
                {
                    blueScore++;
                    blueScoreLabel.Text = blueScore.ToString();
                }

                reset();
            }
            
            
            //updates game timer
            ticks++;
            if (ticks % 16 == 0)
            {
                timeLeft--;
                timeLabel.Text = timeLeft.ToString();
            }

            if (timeLeft == 0)
            {
                gameOver();
            }

                Refresh();
        }

        //paint method
        private void GameScreen_Paint(object sender, PaintEventArgs e) {

            foreach (Player p in players)
            {

                float a = Convert.ToSingle(p.angle );

                drawBrush.Color = p.color;

                //find the centre of the player to set the origin point where rotation will happen
                e.Graphics.TranslateTransform(playerWidth / 2 + p.x, playerLength / 2 + p.y);

                //rotate by the given angle for the player
                e.Graphics.RotateTransform(a);

                // draw the player in the middle of the rotated origin point
                e.Graphics.FillEllipse(drawBrush, 0 - playerWidth / 2, 0 - playerLength / 2, playerWidth, playerLength);

                drawBrush.Color = Color.Beige;
                e.Graphics.FillEllipse(drawBrush, 0 - (playerLength - 1) / 2, 0 - (playerLength - 1) / 2, playerLength - 1, playerLength - 1);

                drawBrush.Color = Color.Yellow;
                e.Graphics.FillPie(drawBrush, 0 - (playerLength - 1) / 2, 0 - (playerLength - 1) / 2, playerLength - 1, playerLength - 1, 0, 180);

                //reset to original origin point
                e.Graphics.ResetTransform();

                //shot meter drawing
                if (p.actionKeyDown  && p.hasBall)
                {
                    drawBrush.Color = Color.Orange;
                    e.Graphics.FillRectangle(drawBrush, p.x, p.y + playerLength + 10, Convert.ToInt16(playerWidth * ticksSinceShot / 60), 8);
                    e.Graphics.DrawRectangle(drawPen, p.x, p.y + playerLength + 10, playerWidth, 8);
                }

            }

            //goalie drawing
            foreach (Goalkeeper g in goalkeepers)
            {                
                    float a = Convert.ToSingle(g.angle);

                    drawBrush.Color = g.color;

                    //find the centre of the player to set the origin point where rotation will happen
                    e.Graphics.TranslateTransform(playerWidth / 2 + g.x, playerLength / 2 + g.y);

                    //rotate by the given angle for the player
                    e.Graphics.RotateTransform(a);

                    // draw the player in the middle of the rotated origin point
                    e.Graphics.FillEllipse(drawBrush, 0 - playerWidth / 2, 0 - playerLength / 2, playerWidth, playerLength);

                    drawBrush.Color = Color.Beige;
                    e.Graphics.FillEllipse(drawBrush, 0 - (playerLength - 1) / 2, 0 - (playerLength - 1) / 2, playerLength - 1, playerLength - 1);

                    drawBrush.Color = Color.Yellow;
                    e.Graphics.FillPie(drawBrush, 0 - (playerLength - 1) / 2, 0 - (playerLength - 1) / 2, playerLength - 1, playerLength - 1, 0, 180);

                    //reset to original origin point
                    e.Graphics.ResetTransform();
                
                
            }

            //ball drawing
            drawBrush.Color = Color.White;
            e.Graphics.FillEllipse(drawBrush, b.x, b.y, ballSize, ballSize);
            e.Graphics.DrawEllipse(drawPen, b.x, b.y, ballSize, ballSize);

            
        }
        #region accel methods
        public void AccelerateP1()
        {
            //player 1 movement
            string directionX = "none";
            string directionY = "none";
            if (aDown) { directionX = "left"; }
            if (dDown) { directionX = "right"; }
            if (wDown) { directionY = "up"; }
            if (sDown) { directionY = "down"; }

            p1.Accelerate(directionX, directionY);
            
            if (qDown)
                p1.Turn("left");
            if (eDown)
                p1.Turn("right");
        }

        public void AccelerateP2()
        {
            //player 2 movement
            string directionX = "none";
            string directionY = "none";
            if (downArrowDown) { directionY = "down"; }
            if (leftArrowDown) { directionX = "left"; }
            if (rightArrowDown) { directionX = "right"; }
            if (upArrowDown) { directionY = "up"; }
            
            p2.Accelerate(directionX, directionY);

            if (jDown)
                p2.Turn("left");
            if (lDown)
                p2.Turn("right");
        }
        #endregion
        #region assorted methods
        //opens the pause screen on a button click
        public void handlePause()
        {
            timer.Enabled = false;

            DialogResult result = PauseScreen.Show("Quit The Game?", "Yes", "No", this.FindForm());

            switch (result)
            {
                case DialogResult.No:
                    timer.Enabled = true;
                    escapeDown = false;
                    leftArrowDown = false;
                    rightArrowDown = false;
                    break;

                case DialogResult.Yes:
                    MenuScreen ms = new MenuScreen();
                    Form form = this.FindForm();

                    form.Controls.Add(ms);
                    form.Controls.Remove(this);

                    ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
                    break;
            }
        }

        //what to do when game timer runs out
        public void gameOver()
        {
            if (redScore > blueScore)
            {

            }
            else if (redScore < blueScore)
            {

            }
            else
            {
                isSuddenDeath = true;
                timeLabel.Text = "000";
                reset();
            }
        }

        //resets player and ball positions
        public void reset()
        {
            //resets player positions, ball positions, and speeds
            p1.x = this.Width / 4;
            p1.y = this.Height / 2;
            p1.angle = 90;


            p2.x = this.Width * 3 / 4;
            p2.y = this.Height / 2;
            p2.angle = 270;

            p1.xSpeed = p1.ySpeed = p2.xSpeed = p2.ySpeed = 0;

            b.x = this.Width / 2;
            b.y = this.Height / 2;

            b.xSpeed = b.ySpeed = -1;

            Refresh();
            timer.Start();
            Thread.Sleep(2000);
        }
        
        #endregion
    }
}