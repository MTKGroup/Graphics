using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class Block : Shape
    {
        public virtual Block Clone(DiagramFactory f)
        {
            throw new System.NotImplementedException();
        }

        public override void Draw(Graphics.CommonGraphics g)
        {
            throw new System.NotImplementedException();
        }
    }
}
