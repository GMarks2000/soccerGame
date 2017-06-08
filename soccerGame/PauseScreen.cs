using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soccerGame
{
    public partial class PauseScreen : Form
    {
        public PauseScreen()
        {
            InitializeComponent();
        }

        static PauseScreen pause;
        static public DialogResult result;

        public static DialogResult Show(string Text, string btnYes, string btnNo, Form f)
        {
            pause = new PauseScreen();
            /*
            pause.titleLabel.Text = Text;
            pause.yesLabel.Text = btnYes;
            pause.noLabel.Text = btnNo;
            */
            pause.Location = new Point((f.Width - pause.Width) / 2, (f.Height - pause.Height) / 2);

            pause.ShowDialog();
            return result;
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            this.Close();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            this.Close();
        }

        //unpause on escape press
        private void PauseScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {

            }
        }
    }
}
