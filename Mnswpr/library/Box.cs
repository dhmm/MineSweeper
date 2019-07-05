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
        internal int GetFlagsCountAround()
        {
            int flags = 0;
            if (LeftTopBox != null)
            {
                if (LeftTopBox.HasFlag)
                {
                    flags++;
                }
            }
            if (LeftBottomBox != null)
            {
                if (LeftBottomBox.HasFlag)
                {
                    flags++;
                }
            }
            if (LeftBox != null)
            {
                if (LeftBox.HasFlag)
                {
                    flags++;
                }
            }
            if (TopBox != null)
            {
                if (TopBox.HasFlag)
                {
                    flags++;
                }
            }
            if (RightTopBox != null)
            {
                if (RightTopBox.HasFlag)
                {
                    flags++;
                }
            }
            if (RightBottomBox != null)
            {
                if (RightBottomBox.HasFlag)
                {
                    flags++;
                }
            }
            if (RightBox != null)
            {
                if (RightBox.HasFlag)
                {
                    flags++;
                }
            }
            if (BottomBox != null)
            {
                if (BottomBox.HasFlag)
                {
                    flags++;
                }
            }
            return flags;
        }

        public void MineExplosed()
        {
            this.btnBox.Hide();
            this.pctFlag.Hide();
            this.lblMines.Hide();
            this.BackColor = Color.Red;
        }

        internal void OpenAllWithrRLClick()
        { 
            if( this.TotalMines != GetFlagsCountAround() )
            {
                return;
            }
                           
            if (LeftTopBox != null)
            {
                if (LeftTopBox.Checked == false)
                {
                    if(LeftTopBox.HasMine && !LeftTopBox.HasFlag)
                    {
                        Game.YouLost(LeftTopBox);
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
                        Game.YouLost(LeftBottomBox);
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
                        Game.YouLost(LeftBox);
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
                        Game.YouLost(TopBox);
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
                        Game.YouLost(RightTopBox);
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
                        Game.YouLost(RightBottomBox);
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
                        Game.YouLost(RightBox);
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
                        Game.YouLost(BottomBox);
                        return;
                    }
                    BottomBox.OpenAll();
                }
            }
        }

        internal void GameLostOpen()
        {
            if(HasMine && !HasFlag)
            {
                MineExplosed();
            }
            else
            {
                if(!HasFlag)
                {
                    Open();
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
                if(LeftButton)
                {
                    ColorAroundBoxes();
                }
            }

            if (e.Button == MouseButtons.Left)
            {
                LeftButton = true;
                if(RightButton)
                {
                    ColorAroundBoxes();
                }
            }
        }
        public void SetRLClickColor()
        {
            this.btnBox.BackColor = Color.Gray;
        }
        public void RestoreColor()
        {
            this.btnBox.BackColor = Color.Silver;
        }
        private void ColorAroundBoxes()
        {            
            if (LeftTopBox != null)
            {
                if (LeftTopBox.Opened == false)
                {
                    LeftTopBox.SetRLClickColor();
                }
            }
            if (LeftBottomBox != null)
            {
                if (LeftBottomBox.Opened == false)
                {
                    LeftBottomBox.SetRLClickColor();
                }
            }
            if (LeftBox != null)
            {
                if (LeftBox.Opened == false)
                {
                    LeftBox.SetRLClickColor();
                }
            }
            if (TopBox != null)
            {
                if (TopBox.Opened == false)
                {
                    TopBox.SetRLClickColor();
                }
            }
            if (RightTopBox != null)
            {
                if (RightTopBox.Opened == false)
                {
                    RightTopBox.SetRLClickColor();
                }
            }
            if (RightBottomBox != null)
            {
                if (RightBottomBox.Opened == false)
                {
                    RightBottomBox.SetRLClickColor();
                }
            }
            if (RightBox != null)
            {
                if (RightBox.Opened == false)
                {
                    RightBox.SetRLClickColor();
                }
            }
            if (BottomBox != null)
            {
                if (BottomBox.Opened == false)
                {
                    BottomBox.SetRLClickColor();
                }
            }
        }
        private void ClearAroundBoxesColor()
        {
            if (LeftTopBox != null)
            {
                LeftTopBox.RestoreColor();
            }
            if (LeftBottomBox != null)
            {
                LeftBottomBox.RestoreColor();
            }
            if (LeftBox != null)
            {
                LeftBox.RestoreColor();
            }
            if (TopBox != null)
            {
                TopBox.RestoreColor();
            }
            if (RightTopBox != null)
            {
                RightTopBox.RestoreColor();
            }
            if (RightBottomBox != null)
            {
                RightBottomBox.RestoreColor();
            }
            if (RightBox != null)
            {
                RightBox.RestoreColor();
            }
            if (BottomBox != null)
            {
                BottomBox.RestoreColor();
            }
        }
        private void lblMines_MouseUp(object sender, MouseEventArgs e)
        {
            if (RightButton && LeftButton)
            {
                ClearAroundBoxesColor();
                Game.OpenBoxWithRLClick(Row, Col);
            }
            RightButton = false;
            LeftButton = false;
        }

        private void pctFlag_MouseClick(object sender, MouseEventArgs e)
        {
            if (Game.GameLost == false)
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.HasFlag = false;
                }
            }
        }
    }
}
