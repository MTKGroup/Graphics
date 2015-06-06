using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphics
{
    public abstract class Shape
    {
        public Shape()
        {
            this.Info = new ShapeInfo();
        }

        public Shape(ShapeInfo info)
        {
            this.Info = info;
        }

        public Shape(int x, int y, int width, int height, Color color)
        {
            this.Info = new ShapeInfo();
            this.Info.X = x;
            this.Info.Y = y;
            this.Info.Width = width;
            this.Info.Height = height;
            this.Info.Color = color;
        }

        public ShapeInfo Info { get; set;}

        public virtual void Draw(CommonGraphics g)
        {
            
        }

        public virtual void Fill(CommonGraphics g, Color fillColor)
        {

        }
    }
}
