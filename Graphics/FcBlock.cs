using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class FcBlock : Block
    {
        public override Graphics.Block Clone(Graphics.DiagramFactory f)
        {
            throw new System.NotImplementedException();
        }

        public override void Draw(Graphics.CommonGraphics g)
        {
            throw new System.NotImplementedException();
        }

        public FcBlock()
        { }

        public FcBlock(ShapeInfo info)
            :base(info)
        {
            
        }

        public FcBlock(int x, int y, int width, int height)
            :base(x, y, width, height)
        {
        
        }
    }
}
