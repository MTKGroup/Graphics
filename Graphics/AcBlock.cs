using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class AcBlock : Block
    {
        public override Graphics.Block Clone(Graphics.DiagramFactory f)
        {
            throw new System.NotImplementedException();
        }

        public override void Draw(Graphics.CommonGraphics g)
        {
            throw new System.NotImplementedException();
        }

        public AcBlock()
        { }

        public AcBlock(ShapeInfo info)
            :base(info)
        {
 
        }

        public AcBlock(int x, int y, int width, int height)
            :base(x, y, width, height)
        {

        }
    }
}
