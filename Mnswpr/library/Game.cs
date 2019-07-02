using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mnswpr.library
{
    public class Game
    {
        Random R = new Random();

        Panel PnlArena = null;
        int BoxWidth = 20;
        int BoxHeight = 20;
        int BoxesInWidth = 10;
        int BoxesInHeight = 10;
        int TotalMines = 10;

        Box[,] Boxes = null;

        public Game(Panel pnlArena)
        {
            this.PnlArena = pnlArena;
            Boxes = new Box[BoxesInWidth, BoxesInHeight];
            if(TotalMines > ( BoxesInWidth * BoxesInHeight )  )
            {
                MessageBox.Show("Error : You have too many mines");
                Application.ExitThread();
            }
        }
        public void Start()
        {
            ClearAll();
            AddBoxes();
            AddMines();
            JoinBoxes();
            AddNumbers();

        }
        private void ClearAll()
        {
            this.PnlArena.Controls.Clear();
            Boxes = new Box[BoxesInWidth, BoxesInHeight];
        }
        private void AddBoxes()
        {
            for(int row=0;row< BoxesInHeight; row++)
            {
                for(int col = 0; col < BoxesInWidth; col++)
                {
                    Box box = new Box(this,row,col);
                    box.Left = col * BoxWidth;
                    box.Top = row * BoxHeight;                    
                    Boxes[row, col] = box;
                    this.PnlArena.Controls.Add(box);
                }
            }
        }
        private void JoinBoxes()
        {
            for (int row = 0; row < BoxesInWidth; row++)
            {
                for (int col = 0; col < BoxesInHeight; col++)
                {
                    Box activeBox = Boxes[row, col];

                    if (row > 0)
                    {
                        activeBox.TopBox = Boxes[row - 1, col];
                        if (col > 0)
                        { activeBox.LeftTopBox = Boxes[row - 1, col - 1]; }

                        if (col < BoxesInHeight - 1)
                        { activeBox.RightTopBox = Boxes[row - 1, col + 1]; }
                    }

                    if (col > 0)
                    { activeBox.LeftBox = Boxes[row, col - 1]; }
                    if (col < BoxesInHeight - 1)
                    { activeBox.RightBox = Boxes[row, col + 1]; }

                    if (row < BoxesInWidth - 1)
                    {
                        activeBox.BottomBox = Boxes[row + 1, col];

                        if (col > 0)
                        { activeBox.LeftBottomBox = Boxes[row + 1, col - 1]; }

                        if (col < BoxesInHeight - 1)
                        { activeBox.RightBottomBox = Boxes[row + 1, col + 1]; }
                    }                    
                }
            }
        }
        private void AddNumbers()
        {
            for(int row=0;row<BoxesInWidth;row++)
            {
                for (int col = 0; col < BoxesInHeight; col++)
                {
                    int total = 0;
                    if (row > 0)
                    {
                        total += (Boxes[row - 1, col].HasMine ? 1 : 0);
                        if (col > 0)
                        { total += (Boxes[row - 1, col - 1].HasMine ? 1 : 0); }

                        if (col < BoxesInHeight - 1)
                        { total += (Boxes[row - 1, col + 1].HasMine ? 1 : 0); }
                    }

                    if (col > 0)
                    { total += (Boxes[row, col - 1].HasMine ? 1 : 0); }
                    if (col < BoxesInHeight - 1)
                    { total += (Boxes[row, col + 1].HasMine ? 1 : 0); }

                    if (row < BoxesInWidth - 1)
                    {
                        total += (Boxes[row + 1, col].HasMine ? 1 : 0);

                        if (col > 0)
                        { total += (Boxes[row + 1, col - 1].HasMine ? 1 : 0); }

                        if (col < BoxesInHeight - 1)
                        { total += (Boxes[row + 1, col + 1].HasMine ? 1 : 0); }
                    }
                    Boxes[row, col].TotalMines = total;
                }
            }
        }
        private void AddMines()
        {
            int minesToAdd = TotalMines;
            while(minesToAdd > 0 )
            {
                int row = R.Next(BoxesInWidth);
                int col = R.Next(BoxesInHeight);
                if(Boxes[row,col].HasMine == false)
                {
                    Boxes[row, col].HasMine = true;
                    Boxes[row, col].BackColor = System.Drawing.Color.Red;
                    minesToAdd--;
                }
            }
        }        
        
        public void OpenBoxWithLeftClick(int row,int col)
        {
            Box box = Boxes[row, col];
            box.Open();
            if(box.HasMine)
            {
                MessageBox.Show("Booom");
            }
            else if ( box.TotalMines == 0 )
            {
                box.OpenAll();
            }
        }
        //Must run only on opened cell
        public void OpenBoxWithRLClick(int row,int col)
        {
            Box box = Boxes[row, col];
            box.OpenAllWithrRLClick();        
        }
    }
}
