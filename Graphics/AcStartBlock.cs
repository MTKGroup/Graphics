using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class AcStartBlock : AcBlock
    {
        public AcStartBlock()
        {

        }

        public AcStartBlock (ShapeInfo info)
            :base(info)
        {

        }

        public AcStartBlock(int x, int y, int width, int height)
            :base(x, y, width, height)
        {

        }

        public override Graphics.Block Clone(Graphics.DiagramFactory f)
        {
            AcStartBlock cloneObj = new AcStartBlock();
            cloneObj.Info = this.Info;
            return cloneObj;
        }

        public override void Draw(Graphics.CommonGraphics g)
        {
            g.DrawFilledEclipse(this.Info.X, this.Info.Y, this.Info.Width, this.Info.Height);
        }
    }
}
