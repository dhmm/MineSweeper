using Mnswpr.library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mnswpr
{
    public partial class FormMain : Form
    {
        Game game = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            game = new Game(pnlArena , lblMineCount);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            game.Start();
        }

        private void rdoLevel_Click(object sender, EventArgs e)
        {
            if(rdoEasy.Checked)
            {
                game.BoxesInWidth = 10;
                game.BoxesInHeight = 10;
                game.TotalMines = 10;
                pnlArena.Width = 200;
                pnlArena.Height = 200;
                this.Width = pnlArena.Left + pnlArena.Width + gbLevel.Width + 50;
                this.Height = pnlArena.Top + pnlArena.Height + 50; 
            }
            else if (rdoNormal.Checked)
            {
                game.BoxesInWidth = 20;
                game.BoxesInHeight = 20;
                game.TotalMines = 50;
                pnlArena.Width = 400;
                pnlArena.Height = 400;
                this.Width = 450;
                this.Height = 400;
                this.Width = pnlArena.Left + pnlArena.Width + gbLevel.Width + 50;
                this.Height = pnlArena.Top + pnlArena.Height + 50;
            }
            else if (rdoHard.Checked)
            {
                game.BoxesInWidth = 30;
                game.BoxesInHeight = 30;
                game.TotalMines = 100;
                pnlArena.Width = 600;
                pnlArena.Height = 600;
                this.Width = 550;
                this.Height = 500;
                this.Width = pnlArena.Left + pnlArena.Width + gbLevel.Width + 50;
                this.Height = pnlArena.Top + pnlArena.Height + 50;
            }
            game.Start();
        }
    }
}
