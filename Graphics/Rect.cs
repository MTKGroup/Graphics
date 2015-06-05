using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphics
{
    public class Rect : Shape
    {
        public Rect ()
        { }

        public Rect(ShapeInfo info)
            :base(info)
        {
        }

        public Rect(int x, int y, int width, int height, Color color)
            :base(x, y, width, height, color)
        { 
        }

        public override void Draw(CommonGraphics g)
        {
            g.DrawRectangle(this.Info.X, this.Info.Y, this.Info.Width, this.Info.Height, this.Info.Color);
        }
    }
}
