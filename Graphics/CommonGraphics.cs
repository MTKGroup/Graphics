using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Graphics
{
    public abstract class CommonGraphics
    {
        public abstract void DrawLine(int x1, int y1, int x2, int y2, Color color);

        public abstract void DrawRectangle(int x, int y, int width, int height, Color color);

        public abstract void DrawEclipse(int x, int y, int width, int height, Color color);

        public abstract void DrawString(int x, int y, string text, Color color);

        public abstract void DrawFilledEclipse(int x, int y, int width, int height, Color color);

        public abstract void FillPolygon(Point[] points, Color fillColor);

        public abstract void Clear(Color color);
    }
}
