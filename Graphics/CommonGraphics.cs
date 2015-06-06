using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class CommonGraphics
    {
        public virtual void DrawLine(int x1, int y1, int x2, int y2, Color color)
        {
            throw new System.NotImplementedException();
        }

        public virtual void DrawRectangle(int x, int y, int width, int height, Color color)
        {
            throw new System.NotImplementedException();
        }

        public virtual void DrawEclipse(int x, int y, int width, int height, Color color)
        {
            throw new System.NotImplementedException();
        }

        public virtual void DrawString(int x, int y, string text, Color color)
        {
            throw new System.NotImplementedException();
        }

        public virtual void DrawFilledEclipse(int x, int y, int width, int height, Color color)
        {
            throw new System.NotImplementedException();
        }

        public virtual void FillPolygon(Point[] points, Color fillColor)
        {
            throw new System.NotImplementedException();
        }
    }
}
