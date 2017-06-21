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
using System.Xml;
using System.Diagnostics;
using System.Media;
using System.IO;

namespace soccerGame.Screens
{
    public partial class GameScreen : UserControl
    {
        #region global variables
        //keypress bools
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, jDown, lDown, spaceDown, escapeDown, aDown, sDown, dDown, wDown, qDown, eDown, enterDown, musicStarted;

        int playerWidth, playerLength, ballSize, ticksSinceShot, ticks, timeLeft, startX, endX, startY, endY, netWidth, netHeight, creaseStartY, creaseEndY, creaseWidth, redScore, blueScore;

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            this.Location = new Point((f.Width - this.Width) / 2, (f.Height - this.Height) / 2);
            Countdown(5);
        }

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


        Stopwatch musicWatch;
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

            //sets numeric variables
            playerLength = 15;
            playerWidth = 30;
            ballSize = 12;
            ticksSinceShot = 0;
            ticks = 0;
            timeLeft = 30;

            //net and boundary variables-- adjust as necessary
            startX = 125;
            startY = 14;
            endX = 1175;
            endY = 687;
            netWidth = 36;
            netHeight = 90;

            creaseStartY = 239;
            creaseEndY = 461;
            creaseWidth = 68;


            redScore = 0;

            blueScore = 0;

            isSuddenDeath = false;
            musicStarted = false;

            //player construtions
            p1 = new Player(this.Width / 4, this.Height / 2 - 2, 0, 0, 0.3, 0.85, 90, 5, playerWidth, playerLength, 30, 0, false, Color.Red, false, true);
            p2 = new Player(this.Width * 3 / 4 - 28, this.Height / 2, 0, 0, 0.3, 0.85, 270, 5, playerWidth, playerLength, 30, 0, false, Color.Blue, false, true);
            players.Add(p1);
            players.Add(p2);

            //goalie constructions
            g1 = new Goalkeeper(startX + 20, this.Height / 2, 1, 90, playerWidth, playerLength, 30, 0, false, Color.GreenYellow);
            g2 = new Goalkeeper(endX - netWidth - 20, this.Height / 2, 1, 270, playerWidth, playerLength, 30, 0, false, Color.GreenYellow);
            goalkeepers.Add(g1);
            goalkeepers.Add(g2);

            //constructs ball
            b = new Ball(this.Width / 2, this.Height / 2, ballSize, -1, -1, 0.2, 0, new Point(this.Width / 2, this.Height / 2), true);

            musicWatch = new Stopwatch();
            musicWatch.Start();

            //loads sounds into appropriate mediaplayers
            Form1.airHorn = new System.Windows.Media.MediaPlayer();
            Form1.airHorn.Open(new Uri(Application.StartupPath + "/Resources/Air Horn.wav"));

            Form1.applause = new System.Windows.Media.MediaPlayer();
            Form1.applause.Open(new Uri(Application.StartupPath + "/Resources/Applause.wav"));

            Form1.boo = new System.Windows.Media.MediaPlayer();
            Form1.boo.Open(new Uri(Application.StartupPath + "/Resources/BooCrowd.wav"));

            Form1.buzzer = new System.Windows.Media.MediaPlayer();
            Form1.buzzer.Open(new Uri(Application.StartupPath + "/Resources/Buzzer.wav"));

            Form1.cheer = new System.Windows.Media.MediaPlayer();
            Form1.cheer.Open(new Uri(Application.StartupPath + "/Resources/HappyCrowd.wav"));

            Form1.kick = new System.Windows.Media.MediaPlayer();
            Form1.kick.Open(new Uri(Application.StartupPath + "/Resources/Kick.wav"));

            Form1.ambient = new System.Windows.Media.MediaPlayer();
            //Form1.ambient.Open(new Uri(Application.StartupPath + "/Resources/CrowdAmbient.wav"));
            Form1.ambient.Open(new System.Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "crowdMp3.mp3")));
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
                    HandlePause();
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
            //first tick music start
            if (musicStarted == false)
            {
                Form1.ambient.Play();
                musicStarted = true;
            }

            //action key logic
            if (spaceDown)
            {
                p1.actionKeyDown = true;
            }
            else
            {
                p1.actionKeyDown = false;
                p1.hasReset = true;
            }

            if (enterDown)
            {
                p2.actionKeyDown = true;
            }
            else
            {
                p2.actionKeyDown = false;
               p2.hasReset = true;
            }

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

            if (p1.hasBall || p2.hasBall || g1.hasBall || g2.hasBall)
                b.isFree = false;

            //goalie code
            foreach (Goalkeeper g in goalkeepers)
            {   
                //goalies only move if the ball is in their half
                if (Math.Abs(b.x - g.x) < (endX - startX) / 2)
                    g.Move(b, (endY - startY) / 2 + netHeight / 2, (endY - startY) / 2 - netHeight / 2);

                //collision with ball
                if (g.CheckCollision(b) && g.ticksSinceLost >= 5)
                {   
                    //goalie deflects or acquires ball depending on its speed
                    if (Math.Sqrt(b.xSpeed * b.xSpeed + b.ySpeed * b.ySpeed) > 7)
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
                    int a = rand.Next(30, 50);
                    int d = rand.Next(0, 21);
                    int c = rand.Next(0, 2);

                    if (c == 1)
                        d *= -1;

                    b.OnShot(a, g.angle + d);

                    Form1.kick.Stop();
                    Form1.kick.Play();

                    g.hasBall = false;
                    b.isFree = true;
                    g.ticksSinceGot = 0;
                    g.ticksSinceLost = 0;
                }
            }
            //assorted code for each player
            foreach (Player p in players)
            {
                p.Move(startX, endX, startY, endY, creaseStartY, creaseEndY, creaseWidth);

                //places ball in front of posessive player
                if (p.hasBall)
                {
                    int a = p.width / 2 - b.size / 2;
                    b.x = p.x + a;
                    b.y = p.y;

                    //alters ball x and y to always remain same distance from a rotating player
                    b.x += Convert.ToInt16(15 * Math.Sin(p.angle * Math.PI / 180));
                    b.y -= Convert.ToInt16(15 * Math.Cos(p.angle * Math.PI / 180));
                }

                //player cannot reclaim ball until 30 frames (half a second) after loss.
                if (p.ticksSinceLost < 10)
                    p.ticksSinceLost++;

                //increases shot strength when appropriate
                if (p.actionKeyDown && p.hasBall && p.hasReset)
                    ticksSinceShot++;


                //releases a shot ball when space is released or when 60 frames of charge are built up.
                if ((p.actionKeyDown  == false && p.hasBall && ticksSinceShot > 0) || (p.hasBall && ticksSinceShot >= 30))
                {
                    p.hasBall = false;
                    b.isFree = true;

                    //calls shot method
                    b.OnShot(ticksSinceShot, p.angle);

                    //the shot effect volume is  linerarly related to charge time
                    Form1.kick.Stop();
                    Form1.kick.Volume = 0.5 + Convert.ToDouble(ticksSinceShot) / 60;
                    Form1.kick.Play();

                    ticksSinceShot = 0;
                    p.ticksSinceLost = 0;
                    p.hasReset = false;
                }

                //tackle code
                if (p.actionKeyDown && p.hasBall == false && p.tackleTicks == 0 && p.hasReset)
                {
                    p.StartTackle();
                    p.hasReset = false;
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
            

            //player collisions// prevents overlap and puts in some interesting collision dynamics

            if (p1.PlayerCollision(p2))
            {
                int changeBy = 3;

                if (p1.x > p2.x)
                {
                    p1.x += changeBy;
                    p2.x -= changeBy;
                }
                else
                {
                    p1.x -= changeBy;
                    p2.x += changeBy;
                }
                if (p1.y > p2.y)
                {
                    p1.y += changeBy;
                    p2.y -= changeBy;
                }
                else
                {
                    p1.y -= changeBy;
                    p2.y += changeBy;
                }
            }

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
                lastTouch = "RED";
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
                lastTouch = "BLUE";
            }

            b.CheckRotation();

            //prevents stuck ball glitch
            if (b.x + ballSize < startX + creaseWidth && b.y > creaseStartY && b.y + ballSize < creaseEndY && Convert.ToInt16(b.xSpeed) == 0 && Convert.ToInt16(b.ySpeed) == 0)
            {
                g1.hasBall = true;
                b.isFree = false;
            }
            if (b.x > endX - creaseWidth && b.y > creaseStartY && b.y + ballSize < creaseEndY && b.xSpeed == 0 && b.ySpeed == 0)
            {
                g2.hasBall = true;
                b.isFree = false;
            }
            //randomly determines whether to play the airhorn sound on a given frame
            PlayAirhorn();

            //offscreen ball detection (ball given to opponent of last toucher)
            if (b.CheckOOB(startX, endX , startY, endY)  && b.CheckGoal(startX, endX, startY, endY, netWidth, netHeight) == "no goal")
            {
                Output("OUT OF BOUNDS " + lastTouch + " !");

                //plays booing sound
                Form1.boo.Stop();
                Form1.boo.Play();

                if (lastTouch == "RED")
                {
                    p2.hasBall = true;
                    p1.hasBall = false;
                    lastTouch = "BLUE";
                }
                else if (lastTouch == "BLUE")
                {
                    p1.hasBall = true;
                    p2.hasBall = false;
                    lastTouch = "RED";
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

                Countdown(3);
            }

            //checks for  goal
            if (b.CheckGoal(startX, endX, startY, endY, netWidth, netHeight) != "no goal")
            {   
                //non sudden death scoring
                if (isSuddenDeath == false)
                {
                    //red goal
                    if (b.CheckGoal(startX, endX, startY, endY, netWidth, netHeight) == "red goal")
                    {
                        redScore++;
                        redScoreLabel.Text = redScore.ToString();
                        Output("RED GOAL!");
                    }

                    //blue goal
                    else if (b.CheckGoal(startX, endX, startY, endY, netWidth, netHeight) == "blue goal")
                    {
                        blueScore++;
                        blueScoreLabel.Text = blueScore.ToString();
                        Output("BLUE GOAL!");
                    }

                    //plays cheering
                    Form1.cheer.Stop();
                    Form1.cheer.Play();

                    Refresh();
                    Thread.Sleep(2000);
                    Output("");

                    Reset();
                }
                //sudden death scoring
                else
                {
                    if (b.CheckGoal(startX, endX, startY, endY, netWidth, netHeight) == "red goal")
                    {
                        redScore++;
                        EndGame("RED");
                    }

                    else if (b.CheckGoal(startX, endX, startY, endY, netWidth, netHeight) == "blue goal")
                    {
                        blueScore++;
                        EndGame("BLUE");
                    }
                }             
            }          
             
            //ambient game sound looping
            if (musicWatch.ElapsedMilliseconds / 1000 > 38)
            {
                musicWatch.Stop();
                Form1.ambient.Stop();
                Form1.ambient.Play();
                musicWatch.Reset();
                musicWatch.Start();
            }
                       
            //updates game timer
            ticks++;
            if (ticks % 16 == 0 && isSuddenDeath == false)
            {   
                //inserts start zeros for fewer digits to maintain space use
                timeLeft--;
                if (timeLeft < 10)
                    timeLabel.Text = "00" + timeLeft.ToString();
                else if (timeLeft < 100)
                    timeLabel.Text = "0" + timeLeft.ToString();
                else
                    timeLabel.Text = timeLeft.ToString();
            }

            if (timeLeft == 0 && isSuddenDeath == false)
            {
                GameOver();
            }

                Refresh();
        }

        //paint method
        private void GameScreen_Paint(object sender, PaintEventArgs e) {

            foreach (Player p in players)
            {
                float a = Convert.ToSingle(p.angle);

                drawBrush.Color = p.color;

                //find the centre of the player to set the origin point where rotation will happen
                e.Graphics.TranslateTransform(playerWidth / 2 + p.x, playerLength / 2 + p.y);

                //rotate by the given angle for the player
                e.Graphics.RotateTransform(a);
                
                if (p.color == Color.Red)
                {
                    e.Graphics.DrawImage(Properties.Resources.Player_1, 0 - playerWidth / 2, 0 - playerLength / 2, playerWidth, playerLength);
                }
                else if (p.color == Color.Blue)
                {
                    e.Graphics.DrawImage(Properties.Resources.Player_2, 0 - playerWidth / 2, 0 - playerLength / 2, playerWidth, playerLength);
                }
                //reset to original origin point
                e.Graphics.ResetTransform();

                //shot meter drawing
                if (p.actionKeyDown  && p.hasBall && p.hasReset)
                {
                    drawBrush.Color = Color.Orange;
                    e.Graphics.FillRectangle(drawBrush, p.x, p.y + playerLength + 10, Convert.ToInt16(playerWidth * ticksSinceShot / 30), 8);
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

                
                e.Graphics.DrawImage(Properties.Resources.Goalie, 0 - playerWidth / 2, 0 - playerLength / 2, playerWidth, playerLength);
                //reset to original origin point
                e.Graphics.ResetTransform();               
                
            }

            //ball drawing
            drawBrush.Color = Color.White;
            drawPen.Color = Color.Black;

            float ang = Convert.ToSingle(b.angle);

            //rotates and draws ball image
            e.Graphics.TranslateTransform(ballSize / 2 + b.x, ballSize / 2 + b.y);           
            e.Graphics.RotateTransform(ang);
            e.Graphics.DrawImage(Properties.Resources.soccer_ball, 0 - ballSize / 2, 0 - ballSize / 2, ballSize, ballSize);
            
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
        public void HandlePause()
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
                    ms.Focus();
                    break;
            }
        }

        //what to do when game timer runs out
        public void GameOver()
        {
            if (redScore > blueScore)
            {
                EndGame("RED");
            }
            else if (redScore < blueScore)
            {
                EndGame("BLUE");
            }
            else
            {
                isSuddenDeath = true;
                timeLabel.Text = "000";
                Output("SUDDEN DEATH!");
                Refresh();
                Thread.Sleep(2000);
                Reset();
            }
        }

        //ends game given a specific winner
        public void EndGame(string winner)
        {

            //plays applause
            Form1.applause.Stop();
            Form1.applause.Play();

            Output(winner + " WINS!");
            Refresh();
            Thread.Sleep(3000);

            //sends scores to strings and saves them to xml for running record
            saveGame(redScore.ToString(), blueScore.ToString());

            timer.Enabled = false;
            Form form = this.FindForm();
            MenuScreen ms = new MenuScreen();
            form.Controls.Remove(this);

            form.Controls.Add(ms);
            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
            ms.Focus();
        }

        //resets player and ball positions
        public void Reset()
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

            g1.y = g2.y = this.Height / 2;
            p1.hasBall = p2.hasBall = g1.hasBall = g2.hasBall = false;
            b.isFree = true;
            b.xSpeed = b.ySpeed = -1;

            Countdown(3);
        }
        
        //pushes a message to the screen
        public void Output(string msg)
        {
            outputLabel.Text = msg;
            outputLabel.Location = new Point(this.Width / 2 - outputLabel.Width / 2, this.Height / 2 - outputLabel.Height / 2);
        }

        //plays a  countdown for the desired number of seconds before resuming game
        public void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Output(i.ToString());
                Refresh();
                Thread.Sleep(1000);
            }
            Output("");
            Form1.buzzer.Play();
        }

        //saves game to xml file with red and blue scores
        public void saveGame(string redScore, string blueScore)
        {
            //will store all former red and blue scores for easy addition
            List<string> redScores = new List<string>();
            List<string> blueScores = new List<string>();

            XmlTextReader reader = new XmlTextReader("Games.xml");

            //copies every extant score to lists
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    if (redScores.Count() == blueScores.Count())
                    {
                        redScores.Add(reader.Value);
                    }
                    else { blueScores.Add(reader.Value); }
                }
            }

            reader.Close();          

            XmlTextWriter writer = new XmlTextWriter("Games.xml", null);

            writer.WriteStartElement("History");

            //rewrites all prior games
            for (int i = 0; i < redScores.Count(); i++)
            {
                writer.WriteStartElement("game");
                writer.WriteElementString("redScore", redScores[i]);
                writer.WriteElementString("blueScore", blueScores[i]);
                writer.WriteEndElement();
            }

            //writes latest game
            writer.WriteStartElement("game");
            writer.WriteElementString("redScore", redScore);
            writer.WriteElementString("blueScore", blueScore);
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.Close();

        }

        //random airhown logic
        public void PlayAirhorn()
        {   
            //1 in 5000 chance of an airhorn blast
            Random rnd = new Random();
            int i = rnd.Next(0, 5001);

            if (i == 5000)
            {
                Form1.airHorn.Stop();
                Form1.airHorn.Volume = 1;
                Form1.airHorn.Play();
            }
        }
        #endregion
    }
}