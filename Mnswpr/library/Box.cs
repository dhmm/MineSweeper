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
        public Box()
        {
            InitializeComponent();
        }
    }
}
