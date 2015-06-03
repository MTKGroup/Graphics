using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class FcInputBlock : FcBlock
    {
        public FcInputBlock()
        {

        }

        public FcInputBlock (ShapeInfo info)
            :base(info)
        {

        }

        public FcInputBlock(int x, int y, int width, int height)
            :base(x, y, width, height)
        {

        }

        public override Graphics.Block Clone(Graphics.DiagramFactory f)
        {
            FcInputBlock cloneObj = new FcInputBlock();
            cloneObj.Info = this.Info;
            return cloneObj;
        }

        public override void Draw(Graphics.CommonGraphics g)
        {
            Point A = new Point(this.Info.X, this.Info.Y);
            Point B = new Point(this.Info.X + this.Info.Width, this.Info.Y);
            Point C = new Point(this.Info.X - this.Info.Width / 5 + this.Info.Width,
                                this.Info.Y + this.Info.Height);
            Point D = new Point(this.Info.X - this.Info.Width/5, this.Info.Y + this.Info.Height);
            

            g.DrawLine(A.X, A.Y, B.X, B.Y);
            g.DrawLine(A.X, A.Y, D.X, D.Y);
            g.DrawLine(B.X, B.Y, C.X, C.Y);
            g.DrawLine(D.X, D.Y, C.X, C.Y);
        }
    }
}
