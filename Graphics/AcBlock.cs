using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Graphics
{
    public abstract class AcBlock : Block
    {
        public override abstract void Draw(Graphics.CommonGraphics g);

        public override abstract void Fill(Graphics.CommonGraphics g, Color fillColor);

        public AcBlock()
        { }

        public AcBlock(ShapeInfo info)
            :base(info)
        {
 
        }

        public AcBlock(int x, int y, int width, int height, Color color)
            :base(x, y, width, height, color)
        {

        }

        public override abstract Block Convert(DiagramFactory f);
    }
}
