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

        public bool Checked { set; get; } = false;
        public bool Opened { set; get; }

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
            Opened = true;
        }
        public void OpenAll()
        {
            this.Open();
            this.Checked = true;
            if (this.TotalMines == 0)
            {
                if (LeftTopBox != null)
                {
                    if (LeftTopBox.Checked == false)
                    {
                        LeftTopBox.OpenAll();
                    }
                }
                if (LeftBottomBox != null)
                {
                    if (LeftBottomBox.Checked == false)
                    {
                        LeftBottomBox.OpenAll();
                    }
                }
                if (LeftBox != null)
                {
                    if (LeftBox.Checked == false)
                    {
                        LeftBox.OpenAll();
                    }
                }
                if (TopBox != null)
                {
                    if (TopBox.Checked == false)
                    {
                        TopBox.OpenAll();
                    }
                }
                if (RightTopBox != null)
                {
                    if (RightTopBox.Checked == false)
                    {
                        RightTopBox.OpenAll();
                    }
                }
                if (RightBottomBox != null)
                {
                    if (RightBottomBox.Checked == false)
                    {
                        RightBottomBox.OpenAll();
                    }
                }
                if (RightBox != null)
                {
                    if (RightBox.Checked == false)
                    {
                        RightBox.OpenAll();
                    }
                }
                if (BottomBox != null)
                {
                    if (BottomBox.Checked == false)
                    {
                        BottomBox.OpenAll();
                    }
                }
            }
        }
        internal void OpenAllWithrRLClick()
        {            
            if (LeftTopBox != null)
            {
                if (LeftTopBox.Checked == false)
                {
                    if(LeftTopBox.HasMine && !LeftTopBox.HasFlag)
                    {
                        MessageBox.Show("Boooom");
                        return;
                    }
                    LeftTopBox.OpenAll();
                }
            }
            if (LeftBottomBox != null)
            {
                if (LeftBottomBox.Checked == false)
                {
                    if (LeftBottomBox.HasMine && !LeftBottomBox.HasFlag)
                    {
                        MessageBox.Show("Boooom");
                        return;
                    }
                    LeftBottomBox.OpenAll();
                }
            }
            if (LeftBox != null)
            {
                if (LeftBox.Checked == false)
                {
                    if (LeftBox.HasMine && !LeftBox.HasFlag)
                    {
                        MessageBox.Show("Boooom");
                        return;
                    }
                    LeftBox.OpenAll();
                }
            }
            if (TopBox != null)
            {
                if (TopBox.Checked == false)
                {
                    if (TopBox.HasMine && !TopBox.HasFlag)
                    {
                        MessageBox.Show("Boooom");
                        return;
                    }
                    TopBox.OpenAll();
                }
            }
            if (RightTopBox != null)
            {
                if (RightTopBox.Checked == false)
                {
                    if (RightTopBox.HasMine && !RightTopBox.HasFlag)
                    {
                        MessageBox.Show("Boooom");
                        return;
                    }
                    RightTopBox.OpenAll();
                }
            }
            if (RightBottomBox != null)
            {
                if (RightBottomBox.Checked == false)
                {
                    if (RightBottomBox.HasMine && !RightBottomBox.HasFlag)
                    {
                        MessageBox.Show("Boooom");
                        return;
                    }
                    RightBottomBox.OpenAll();
                }
            }
            if (RightBox != null)
            {
                if (RightBox.Checked == false)
                {
                    if (RightBox.HasMine && !RightBox.HasFlag)
                    {
                        MessageBox.Show("Boooom");
                        return;
                    }
                    RightBox.OpenAll();
                }
            }
            if (BottomBox != null)
            {
                if (BottomBox.Checked == false)
                {
                    if (BottomBox.HasMine && !BottomBox.HasFlag)
                    {
                        MessageBox.Show("Boooom");
                        return;
                    }
                    BottomBox.OpenAll();
                }
            }
        }

        private void btnBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Game.OpenBoxWithLeftClick(Row, Col);
            }
            else if (e.Button == MouseButtons.Right)
            {
                HasFlag = !HasFlag;
            }            
        }

        private void lblMines_MouseDown(object sender, MouseEventArgs e)
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

        private void lblMines_MouseUp(object sender, MouseEventArgs e)
        {
            if (RightButton && LeftButton)
            {
                Game.OpenBoxWithRLClick(Row, Col);
            }
            RightButton = false;
            LeftButton = false;
        }

      
    }
}
