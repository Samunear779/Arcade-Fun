using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Arcade_Fun
{
    public partial class arcadeGame : Form
    {
        public arcadeGame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void playGame_Click(object sender, EventArgs e)
        {
            playGame.Visible = false;
            game.ForeColor = Color.White;
            playGame.ForeColor = Color.Black;

            Refresh();
            Thread.Sleep(1000);
            game.Text = "Game will start in... 2";

            Refresh();
            Thread.Sleep(1000);
            game.Text = "Game will start in... 1";

            Refresh();
            Thread.Sleep(1000);
            game.Text = "                 GO!!";
            BackColor = Color.LimeGreen;
            game.TextAlign = ContentAlignment.MiddleCenter;
             


        }
    }
}
