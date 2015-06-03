using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphics
{
    public class Shape
    {
        public Shape()
        {
            this.Info = new ShapeInfo();
        }

        public Shape(ShapeInfo info)
        {
            this.Info = info;
        }

        public Shape(int x, int y, int width, int height)
        {
            this.Info = new ShapeInfo();
            this.Info.X = x;
            this.Info.Y = y;
            this.Info.Width = width;
            this.Info.Height = height;
        }

        public ShapeInfo Info { get; set;}

        public virtual void Draw(CommonGraphics g)
        {
            
        }
    }
}
