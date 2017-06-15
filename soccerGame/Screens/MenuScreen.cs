using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soccerGame.Screens
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
            

            manoLabel.Parent = manoBox;
            soccerLabel.Parent = soccerBox;

            manoLabel.Location = new Point(soccerBox.Width / 2 - soccerLabel.Width / 2, manoBox.Height / 2 - manoLabel.Height / 2);
            soccerLabel.Location = new Point(soccerBox.Width / 2 - soccerLabel.Width / 2, soccerBox.Height / 2 - soccerLabel.Height / 2);
        }

        //opens game screen
        private void playButton_Click_1(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen  gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            gs.Focus();
        }

        //quits game
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            this.Location = new Point((f.Width - this.Width) / 2, (f.Height - this.Height) / 2);
        }

        //opens records screen
        private void recordsButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            RecordScreen rs = new RecordScreen();
            f.Controls.Add(rs);
            rs.Location = new Point((f.Width - rs.Width) / 2, (f.Height - rs.Height) / 2);
            rs.Focus();
        }
    }
}
