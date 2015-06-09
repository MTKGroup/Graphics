using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class ShapeInfo
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public Color Color;

        public ShapeInfo()
        {

        }

        public ShapeInfo(int x, int y, int width, int height, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Color = color;
        }

        public ShapeInfo Clone() {
            return this.MemberwiseClone() as ShapeInfo;
        }
    }
}
