using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Graphics
{
    public abstract class FcBlock : Block
    {
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

        public FcBlock(int x, int y, int width, int height, Color color)
            :base(x, y, width, height, color)
        {
        
        }
    }
}
