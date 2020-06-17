using System.Windows.Forms;
using System.Drawing;
using System;

namespace Colors
{
    class Analogous : Scheme
    {
        public Analogous (ColorCircle colorCircle) : base (colorCircle) { }

        public override Point[] PointersPositions(Point basePoint)
        {
            Point[] result = new Point[2];
            result[0] = basePoint;



            double angle = Math.Atan2(basePoint.X - colorCircle.Center.X, basePoint.Y - colorCircle.Center.Y);
            angle += 30 * Math.PI / 180;

            int x = (int)(colorCircle.Radius * Math.Sin(angle)) + colorCircle.Center.X;
            int y = (int)(colorCircle.Radius * Math.Cos(angle)) + colorCircle.Center.Y;

            result[1] = new Point(x, y);

            return result;
        }

        public override void Paint(PaintEventArgs e, Form form, params Color[] colors)
        {
            Scheme.PaintHalves(e, form, colors);
        }
    }
}
