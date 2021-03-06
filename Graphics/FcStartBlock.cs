﻿using System;
using System.Collections.Generic;
using System.Drawing;
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

        public FcStartBlock(int x, int y, int width, int height, Color color)
            :base(x, y, width, height, color)
        {

        }

        public override Block Convert(Graphics.DiagramFactory f)
        {
            return f.CreateStart(this.Info);
        }

        public override void Draw(Graphics.CommonGraphics g)
        {
            g.DrawEclipse(this.Info.X, this.Info.Y, this.Info.Width, this.Info.Height, this.Info.Color);
            g.DrawString(this.Info.X + this.Info.Width / 2, this.Info.Y + this.Info.Height / 2, "Start", this.Info.Color);
        }

        public override void Fill(Graphics.CommonGraphics g, Color fillColor)
        {
            g.DrawFilledEclipse(this.Info.X, this.Info.Y, this.Info.Width, this.Info.Height, fillColor);
        }

        public override Shape Clone()
        {
            var newShape = new FcStartBlock(this.Info.Clone());
            return newShape;
        }
    }
}
