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

        protected static void PaintHalves(PaintEventArgs e, Form form, params Color[] colors)
        {
            e.Graphics.FillRectangle(new SolidBrush(colors[0]), 0, 0, form.Width / 2, form.Height);
            e.Graphics.FillRectangle(new SolidBrush(colors[1]), form.Width / 2, 0, form.Width / 2, form.Height);
        }
    }
}
