using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

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

        public override void DrawEclipse(int x, int y, int width, int height)
        {
            lib.DrawEllipse(Pens.Black, x, y, width, height);
        }

        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            lib.DrawLine(Pens.Black, x1, y1, x2, y2);
        }

        public override void DrawRectangle(int x, int y, int width, int height)
        {
            lib.DrawRectangle(Pens.Black, x, y, width, height);
        }

        public override void DrawString(int x, int y, string text)
        {
            Font font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            lib.DrawString(text, font, Brushes.Black, x, y, stringFormat);
        }

        public override void DrawFilledEclipse(int x, int y, int width, int height)
        {
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            lib.FillEllipse(solidBrush, x, y, width, height);
        }
    }
}
