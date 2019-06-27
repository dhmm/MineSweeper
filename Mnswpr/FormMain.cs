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
            game = new Game(pnlArena);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            game.Start();
        }
    }
}
