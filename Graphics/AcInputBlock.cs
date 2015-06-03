﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class AcInputBlock : AcBlock
    {
        public AcInputBlock()
        {

        }

        public AcInputBlock (ShapeInfo info)
            :base(info)
        {

        }

        public AcInputBlock(int x, int y, int width, int height)
            :base(x, y, width, height)
        {

        }

        public override Graphics.Block Clone(Graphics.DiagramFactory f)
        {
            AcInputBlock cloneObj = new AcInputBlock();
            cloneObj.Info = this.Info;
            return cloneObj;
        }

        public override void Draw(Graphics.CommonGraphics g)
        {
            Point A = new Point(this.Info.X, this.Info.Y);
            Point B = new Point(this.Info.X + this.Info.Width, this.Info.Y);
            Point C = new Point(this.Info.X + this.Info.Width,
                                this.Info.Y + this.Info.Height - this.Info.Height/5);
            Point D = new Point(this.Info.X + this.Info.Width - this.Info.Width/5,
                                this.Info.Y + this.Info.Height);
            Point E = new Point(this.Info.X, this.Info.Y + this.Info.Height);

            g.DrawLine(A.X, A.Y, B.X, B.Y);
            g.DrawLine(B.X, B.Y, C.X, C.Y);
            g.DrawLine(C.X, C.Y, D.X, D.Y);
            g.DrawLine(D.X, D.Y, E.X, E.Y);
            g.DrawLine(E.X, E.Y, A.X, A.Y);
        }
    }
}