using System.Windows.Forms;
using System.Drawing;

namespace Colors
{
    class Complementary : Scheme
    {
        public Complementary(ColorCircle colorCircle) : base(colorCircle) { }

        public override Point[] PointersPositions(Point basePoint)
        {
            Point[] result = new Point[2];
            result[0] = basePoint;
            result[1] = new Point(colorCircle.Width - basePoint.X, colorCircle.Height - basePoint.Y);
            return result;
        }

        public override void Paint(PaintEventArgs e, Form form, params Color[] colors)
        {
            Scheme.PaintHalves(e, form, colors);
        }
        
    }
}
