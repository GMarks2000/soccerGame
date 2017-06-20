using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace soccerGame.Screens
{
    public partial class RecordScreen : UserControl
    {
        //will store all former red and blue scores for easy addition
        List<string> redScores = new List<string>();
        List<string> blueScores = new List<string>();

        //will store how far up or down through the records has been scrolled
        int index, redWins, blueWins;

        public RecordScreen()
        {
            InitializeComponent();

           redLabel.Parent = redBox;
           redLabel.Location = new Point(redBox.Width / 2 - redLabel.Width / 2, redBox.Height / 2 - redLabel.Height / 2);

           blueLabel.Parent = blueBox;
           blueLabel.Location = new Point(blueBox.Width / 2 - blueLabel.Width / 2, blueBox.Height / 2 - blueLabel.Height / 2);

           OnStart();
        }

        //fills the lists with the appropriate game records and initialises screen
        public void OnStart()
        {
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

            //sorts scores by latest
            redScores.Reverse();
            blueScores.Reverse();

            FillToThree();

            index = redWins = blueWins = 0;

            DrawRecords();

            //finds the number of red and blue wins based on scores
            for (int i = 0; i < redScores.Count; i++)
            {
                if (Convert.ToInt16(redScores[i]) > Convert.ToInt16(blueScores[i]))
                {
                    redWins++;
                }

                else if (Convert.ToInt16(redScores[i]) < Convert.ToInt16(blueScores[i]))
                {
                    blueWins++;
                }
            }

            //outputs win counts, factoring in plurality
            if (redWins != 1)
                redWinsLabel.Text = redWins.ToString() + " TOTAL WINS";
            else
                redWinsLabel.Text = redWins.ToString() + " TOTAL WIN";
            if (blueWins != 1)
                blueWinsLabel.Text = blueWins.ToString() + " TOTAL WINS";
            else
                blueWinsLabel.Text = blueWins.ToString() + " TOTAL WIN";

        }

        //fills record boxes as appropriate based on index value
        public void DrawRecords()
        {
            int i = index;

            redScoreLabel1.Text = redScores[i];
            redScoreLabel2.Text = redScores[i + 1];
            redScoreLabel3.Text = redScores[i + 2];

            blueScoreLabel1.Text = blueScores[i];
            blueScoreLabel2.Text = blueScores[i + 1];
            blueScoreLabel3.Text = blueScores[i + 2];

            ColorScores();

            Refresh();
        }

        //scrolls up through records
        private void upButton_Click(object sender, EventArgs e)
        {
            if (index > 0)
                index--;
            DrawRecords();
        }
        //scrolls down throough records
        private void downButton_Click(object sender, EventArgs e)
        {
            if (index < redScores.Count() - 3)
                index++;
            DrawRecords();
        }

        //returns to menu
        private void returnButton_Click(object sender, EventArgs e)
        {
            Form form = this.FindForm();
            MenuScreen ms = new MenuScreen();
            form.Controls.Remove(this);

            form.Controls.Add(ms);
            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
        }

        //fills lists with zero-zero scores to minimally three spots
        private void FillToThree()
        {
            if (redScores.Count() < 3)
            {
                redScores.Add("0");
                blueScores.Add("0");

                //process will repeat until three scores are present
                FillToThree();
            }
        }
        
        //colors the scores of each label set to reflect victor and loser
        private void ColorScores()
        {
            if (Convert.ToInt16(redScoreLabel1.Text) > Convert.ToInt16(blueScoreLabel1.Text))
            {
                redScoreLabel1.ForeColor = Color.LightGreen;
                blueScoreLabel1.ForeColor = Color.DarkRed;
            }
            else if (Convert.ToInt16(redScoreLabel1.Text) < Convert.ToInt16(blueScoreLabel1.Text))
            {
                blueScoreLabel1.ForeColor = Color.LightGreen;
                redScoreLabel1.ForeColor = Color.DarkRed;
            }

            if (Convert.ToInt16(redScoreLabel2.Text) > Convert.ToInt16(blueScoreLabel2.Text))
            {
                redScoreLabel2.ForeColor = Color.LightGreen;
                blueScoreLabel2.ForeColor = Color.DarkRed;
            }
            else if (Convert.ToInt16(redScoreLabel2.Text) < Convert.ToInt16(blueScoreLabel2.Text))
            {
                blueScoreLabel2.ForeColor = Color.LightGreen;
                redScoreLabel2.ForeColor = Color.DarkRed;
            }

            if (Convert.ToInt16(redScoreLabel3.Text) > Convert.ToInt16(blueScoreLabel3.Text))
            {
                redScoreLabel3.ForeColor = Color.LightGreen;
                blueScoreLabel3.ForeColor = Color.DarkRed;
            }
            else if (Convert.ToInt16(redScoreLabel3.Text) < Convert.ToInt16(blueScoreLabel3.Text))
            {
                blueScoreLabel3.ForeColor = Color.LightGreen;
                redScoreLabel3.ForeColor = Color.DarkRed;
            }
        }
    }
}
