using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class FcStartBlock : FcBlock
    {
        public FcStartBlock()
        {

        }

        public FcStartBlock (ShapeInfo info)
            :base(info)
        {

        }

        public FcStartBlock (int x, int y, int width, int height)
            :base(x, y, width, height)
        {

        }

        public override Graphics.Block Clone(Graphics.DiagramFactory f)
        {
            FcStartBlock cloneObj = new FcStartBlock();

            cloneObj.Info = this.Info;

            return cloneObj;
        }

        public override void Draw(Graphics.CommonGraphics g)
        {
            g.DrawEclipse(this.Info.X, this.Info.Y, this.Info.Width, this.Info.Height);
            g.DrawString(this.Info.X + this.Info.Width / 2, this.Info.Y + this.Info.Height / 2, "Start");
        }
    }
}
