using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class Block : Shape
    {
       

        public override void Draw(Graphics.CommonGraphics g)
        {
            throw new System.NotImplementedException();
        }

        

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

        public virtual Block Clone(DiagramFactory f)
        {
            return null;
        }

        public override void Fill(Graphics.CommonGraphics g, Color fillColor)
        {
            throw new System.NotImplementedException();
        }
    }
}
