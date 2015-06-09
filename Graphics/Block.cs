using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Graphics
{
    public abstract class Block : Shape
    {


        public override abstract void Draw(Graphics.CommonGraphics g);

        

        public Block()
        { }

        public Block(ShapeInfo info)
            :base(info)
        {
            
        }

        public Block(int x, int y, int width, int height, Color color)
            :base(x, y, width, height, color)
        {

        }

        public abstract Block Convert(DiagramFactory f);

        public override abstract void Fill(Graphics.CommonGraphics g, Color fillColor);
    }
}
