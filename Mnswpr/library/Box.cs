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
        public bool HasMine { set; get; } = false;
        public bool HasFlag
        {
            set
            {
                if(value)
                {
                    pctFlag.Show();
                }
                else
                {
                    pctFlag.Hide();
                }
            }
            get
            {
                return pctFlag.Visible;
            }
        } 
        public Box()
        {
            InitializeComponent();
        }

        bool RightButton = false;
        bool LeftButton = false;        
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
            if (e.Button == MouseButtons.Left && !RightButton)
            {
                MessageBox.Show("L");
            }
            else if (e.Button == MouseButtons.Right && !LeftButton)
            {
                MessageBox.Show("R");
            }
            else if (e.Button == MouseButtons.Right && LeftButton)
            {
                MessageBox.Show("L + R");
            }

            RightButton = false;
            LeftButton = false;
        }

    }
}
