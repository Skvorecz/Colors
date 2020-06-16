using System.Windows.Forms;
using System.Drawing;

namespace Colors
{
    abstract class Scheme
    {
        protected ColorCircle colorCircle;

        public abstract void Paint(PaintEventArgs e, Form form, params Color[] colors);
        public abstract Point[] PointersPositions(Point basePoint);

        public Scheme(ColorCircle colorCircle)
        {
            this.colorCircle = colorCircle;
        }
    }
}
