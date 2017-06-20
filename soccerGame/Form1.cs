using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using soccerGame.Screens;
using System.Media;
using System.IO;
/// <summary>
/// Made by Gareth Marks
/// Due 21 June 2017
/// To simulate a simple 1v1 soccer game
/// 
/// ***PC CONTROLS***
/// Player 1:
/// WASD to move
/// Q and E to turn
/// Space to shoot/tackle
/// Player 2:
/// Arrow keys to move
/// J and L to turn
/// K to shoot/tackle
/// Press Escape to pause game
/// </summary>
namespace soccerGame
{
    public partial class Form1 : Form
    {

        //dynamic sound library
        public static System.Windows.Media.MediaPlayer airHorn;
        public static System.Windows.Media.MediaPlayer applause;
        public static System.Windows.Media.MediaPlayer boo;
        public static System.Windows.Media.MediaPlayer buzzer;
        public static System.Windows.Media.MediaPlayer cheer;
        public static System.Windows.Media.MediaPlayer kick;
        public static System.Windows.Media.MediaPlayer ambient;


        public Form1()
        {
            InitializeComponent();

            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
    }
}
