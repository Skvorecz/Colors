using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    public partial class MainForm : Form
    {
        ColorCircle colorCircle;
        Pointer pointer;
        Pointer oppositePointer;

        Color rightColor;
        Color leftColor;

        public MainForm()
        {
            colorCircle = new ColorCircle(125, 125);
            colorCircle.MouseDown += ColorCircle_MouseDown;
            Controls.Add(colorCircle);

            InitializeComponent();
        }

        private void ColorCircle_MouseDown(object sender, MouseEventArgs e)
        {
            leftColor = GetPixelColor(colorCircle, e.X, e.Y);

            int x = e.X - colorCircle.Center.X;
            int y = e.Y - colorCircle.Center.Y;
            double a = Math.Atan2(x, y);

            x = (int)(colorCircle.Radius * Math.Sin(a));
            y = (int)(colorCircle.Radius * Math.Cos(a));

            x = x + colorCircle.Center.X + colorCircle.Location.X;
            y = y + colorCircle.Center.Y + colorCircle.Location.Y;

            if (pointer == null)
            {
                pointer = new Pointer();
                Controls.Add(pointer);
            }
            pointer.Location = new Point(x, y);
            pointer.BringToFront();

            leftColor = GetPixelColor(colorCircle, pointer.Location.X - colorCircle.Location.X, pointer.Location.Y - colorCircle.Location.Y);

            if (oppositePointer == null)
            {
                oppositePointer = new Pointer();
                Controls.Add(oppositePointer);
            }            
            oppositePointer.Location = new Point(colorCircle.Location.X + colorCircle.Width - pointer.Location.X + colorCircle.Center.X, colorCircle.Location.Y + colorCircle.Height - pointer.Location.Y + colorCircle.Center.Y);
            oppositePointer.BringToFront();

            rightColor = GetPixelColor(colorCircle, oppositePointer.Location.X - colorCircle.Location.X, oppositePointer.Location.Y - colorCircle.Location.Y);
            
            Refresh();
        }

        public Color GetPixelColor(PictureBox pictureBox, int x, int y)
        {
            return ((Bitmap)pictureBox.Image).GetPixel(x, y);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Scheme scheme = new Complementary();
            scheme.Paint(e, this, leftColor, rightColor);
        }
    }
}
