using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class FcStarBlock : FcBlock
    {
        public override Graphics.Block Clone(Graphics.DiagramFactory f)
        {
            throw new System.NotImplementedException();
        }

        public override void Draw(Graphics.CommonGraphics g)
        {
            //g.DrawEclipse();
            //g.DrawString();
        }
    }
}
