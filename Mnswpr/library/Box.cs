using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mnswpr.library
{
    public partial class Box : UserControl
    {
        Game Game = null;

        public Box LeftBox { set; get; } = null;
        public Box LeftTopBox { set; get; } = null;
        public Box LeftBottomBox { set; get; } = null;
        public Box RightBox { set; get; } = null;
        public Box RightTopBox { set; get; } = null;
        public Box RightBottomBox { set; get; } = null;
        public Box TopBox { set; get; } = null;
        public Box BottomBox { set; get; } = null;

        private int Row { set; get; } = -1;
        private int Col { set; get; } = -1;

        public bool HasMine { set; get; } = false;
        public bool HasFlag
        {
            set
            {
                if(value)
                {
                    pctFlag.Show();
                    btnBox.Hide();
                }
                else
                {
                    pctFlag.Hide();
                    btnBox.Show();
                }
            }
            get
            {
                return pctFlag.Visible;
            }
        }

        private int _totalMines = 0;
        public int TotalMines
        {
            set
            {
                _totalMines = value;
                if (value == 0)
                {
                    lblMines.Text = "";
                }
                else
                {
                    lblMines.Text = value.ToString();
                }            
            }
            get
            {
                return _totalMines;
            }
        }

        bool RightButton = false;
        bool LeftButton = false;
        public Box(Game game , int row ,int col)
        {
            InitializeComponent();
            Game = game;
            Row = row;
            Col = col;
        }

        public void Open()
        {
            btnBox.Hide();
        }
     
        private void btnBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RightButton = true;
            }

            if (e.Button == MouseButtons.Left)
            {
                LeftButton = true;
            }
        }

        private void btnBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (LeftButton && !RightButton)
            {
                Game.OpenBoxWithLeftClick(Row, Col);
            }
            else if (RightButton && !LeftButton)
            {
                HasFlag = !HasFlag;
            }
            else if (RightButton && LeftButton)
            {
                Game.OpenBoxWithRLClick(Row,Col);
            }

            RightButton = false;
            LeftButton = false;
        }



    }
}
