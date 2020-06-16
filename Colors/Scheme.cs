using System.Windows.Forms;
using System.Drawing;

namespace Colors
{
    interface Scheme
    {
        void Paint(PaintEventArgs e, Form form, params Color[] colors);
    }
}
