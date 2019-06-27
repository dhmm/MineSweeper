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
                    Box box = new Box();
                    box.Left = col * BoxWidth;
                    box.Top = row * BoxHeight;
                    Boxes[row, col] = box;
                    this.PnlArena.Controls.Add(box);
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
        
    }
}
