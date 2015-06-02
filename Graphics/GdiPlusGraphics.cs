using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Graphics
{
    public class GdiPlusGraphics : CommonGraphics
    {
        System.Drawing.Graphics lib;

        public System.Drawing.Graphics Lib
        {
            get { return lib; }
            set { lib = value; }
        }
        public override void DrawEclipse(int cx, int cy, int hradius, int vradius)
        {
            throw new System.NotImplementedException();
        }

        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            lib.DrawLine(Pens.Black, x1, y1, x2, y2);
        }

        

        public override void DrawRectangle(int x, int y, int width, int height)
        {
            throw new System.NotImplementedException();
        }

        public override void DrawString(int x, int y, string text)
        {
            throw new System.NotImplementedException();
        }
    }
}
