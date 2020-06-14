using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    class AYAYA : PictureBox
    {
        public AYAYA ()
        {            
            Image = Properties.Resources.AYAYA;
            SizeMode = PictureBoxSizeMode.StretchImage;
            Size = new System.Drawing.Size(25, 25);
        }
    }
}
