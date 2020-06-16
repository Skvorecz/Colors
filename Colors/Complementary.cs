using System.Windows.Forms;
using System.Drawing;

namespace Colors
{
    class Complementary : Scheme
    {
        public void Paint(PaintEventArgs e, Form form, params Color[] colors)
        {
            e.Graphics.FillRectangle(new SolidBrush(colors[0]), 0, 0, form.Width / 2, form.Height);
            e.Graphics.FillRectangle(new SolidBrush(colors[1]), form.Width / 2, 0, form.Width / 2, form.Height);
        }
        
    }
}
