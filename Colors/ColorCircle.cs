using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Colors
{
    class ColorCircle : PictureBox
    {
        private Point center = new Point();

        public int Radius { get { return (int)(this.Width / 2.57); } }
        public Point Center
        {
            get
            {
                center.X = this.Width / 2;
                center.Y = this.Height / 2;
                return center;
            }
        }

        public ColorCircle()
        {
            Image = Properties.Resources.ColorCircle;
            SizeMode = PictureBoxSizeMode.AutoSize;
            DoubleBuffered = true;
        }

        public ColorCircle(int x, int y) : this()
        {
            Location = new Point(x, y);
        }
    }
}
