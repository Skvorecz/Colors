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

        protected static void PaintThirds(PaintEventArgs e, Form form, params Color[] colors)
        {
            Point center = new Point(form.Width / 2, form.Height / 2);
            Point topLeft = new Point(0, 0);
            Point topRight = new Point(form.Width, 0);
            Point bottomLeft = new Point(0, form.Height);
            Point bottomRight = new Point(form.Width, form.Height);
            Point bottomCenter = new Point(form.Width / 2, form.Height);

            e.Graphics.FillPolygon(new SolidBrush(colors[0]), new Point[] { topLeft, topRight, center });
            e.Graphics.FillPolygon(new SolidBrush(colors[1]), new Point[] { topLeft, center, bottomCenter, bottomLeft });
            e.Graphics.FillPolygon(new SolidBrush(colors[2]), new Point[] { bottomCenter, center, topRight, bottomRight });
        }
    }
}
