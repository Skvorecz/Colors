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
        AYAYA ayaya;
        AYAYA oppositeAYAYA;

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

            if (leftColor.ToArgb() == Color.Black.ToArgb())
                return;

            int x = e.X - colorCircle.Center.X;
            int y = e.Y - colorCircle.Center.Y;
            double a = Math.Atan2(x, y);

            x = (int)(colorCircle.Radius * Math.Sin(a));
            y = (int)(colorCircle.Radius * Math.Cos(a));

            x = x + colorCircle.Center.X + colorCircle.Location.X;
            y = y + colorCircle.Center.Y + colorCircle.Location.Y;

            if (ayaya == null)
            {
                ayaya = new AYAYA();
                Controls.Add(ayaya);
            }
            ayaya.Location = new Point(x, y);
            ayaya.BringToFront();

            leftColor = GetPixelColor(colorCircle, ayaya.Location.X - colorCircle.Location.X, ayaya.Location.Y - colorCircle.Location.Y);

            if (oppositeAYAYA == null)
            {
                oppositeAYAYA = new AYAYA();
                Controls.Add(oppositeAYAYA);
            }            
            oppositeAYAYA.Location = new Point(colorCircle.Location.X + colorCircle.Width - ayaya.Location.X + colorCircle.Center.X, colorCircle.Location.Y + colorCircle.Height - ayaya.Location.Y + colorCircle.Center.Y);
            oppositeAYAYA.BringToFront();

            rightColor = GetPixelColor(colorCircle, oppositeAYAYA.Location.X - colorCircle.Location.X, oppositeAYAYA.Location.Y - colorCircle.Location.Y);
            
            Refresh();
        }

        public Color GetPixelColor(PictureBox pictureBox, int x, int y)
        {
            return ((Bitmap)pictureBox.Image).GetPixel(x, y);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(leftColor, this.Height / 3), 0, 0, this.Width / 3, this.Height);
            //e.Graphics.DrawRectangle(new Pen(rightColor, this.Height / 3), 300, 0, this.Width / 3, this.Height);

            e.Graphics.FillRectangle(new SolidBrush(leftColor), 0, 0, this.Width / 2, this.Height);
            e.Graphics.FillRectangle(new SolidBrush(rightColor), this.Width / 2, 0, this.Width / 2, this.Height);
        }
    }
}
