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
        Scheme scheme;
        ColorCircle colorCircle;
        Pointer[] pointers;
        Color[] colors;

        public MainForm()
        {
            colorCircle = new ColorCircle(125, 125);
            colorCircle.MouseDown += ColorCircle_MouseDown;
            Controls.Add(colorCircle);

            InitializeComponent();

            schemeComboBox.SelectedIndex = 0;
        }

        private void ColorCircle_MouseDown(object sender, MouseEventArgs e)
        {
            //Находим точку, ближайшую к центральной окружности
            int x = e.X - colorCircle.Center.X;
            int y = e.Y - colorCircle.Center.Y;
            double angle = Math.Atan2(x, y);

            x = (int)(colorCircle.Radius * Math.Sin(angle));
            y = (int)(colorCircle.Radius * Math.Cos(angle));

            x = x + colorCircle.Center.X;
            y = y + colorCircle.Center.Y;

            Point[] points = scheme.PointersPositions(new Point(x, y));

            for (int i = 0; i < points.Length; i++)
            {
                if(pointers[i] == null)
                {
                    pointers[i] = new Pointer();
                    Controls.Add(pointers[i]);
                }
                pointers[i].Location = new Point(points[i].X + colorCircle.Location.X, points[i].Y + colorCircle.Location.Y);
                pointers[i].BringToFront();

                colors[i] = GetPixelColor(colorCircle, pointers[i].Location.X - colorCircle.Location.X, pointers[i].Location.Y - colorCircle.Location.Y);
            }

            Refresh();
        }

        public Color GetPixelColor(PictureBox pictureBox, int x, int y)
        {
            return ((Bitmap)pictureBox.Image).GetPixel(x, y);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            scheme.Paint(e, this, colors);
        }

        private void schemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pointers != null)
                foreach (Pointer p in pointers)
                    Controls.Remove(p);

            switch (schemeComboBox.SelectedItem.ToString())
            {
                case "Complementary":
                    scheme = new Complementary(colorCircle);
                    pointers = new Pointer[2];
                    colors = new Color[2];
                    break;

                case "Analogous":
                    scheme = new Analogous(colorCircle);
                    pointers = new Pointer[2];
                    colors = new Color[2];
                    break;

                case "Triad":
                    scheme = new Triad(colorCircle);
                    pointers = new Pointer[3];
                    colors = new Color[3];
                    break;
            }
        }
    }
}
