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
        public int Radius { get; } = 94;
        public Point Center { get; } = new Point(121, 122);

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

        //protected override void OnPaint(PaintEventArgs pe)
        //{
        //    GraphicsPath path = new GraphicsPath();
        //    path.AddEllipse(0, 0, Image.Width, Image.Height);
        //    this.Region = new Region(path);
        //    base.OnPaint(pe);
        //}
    }
}
