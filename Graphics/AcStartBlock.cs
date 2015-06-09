using System;
using System.Collections.Generic;
using System.Drawing;
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

        public AcStartBlock(int x, int y, int width, int height, Color color)
            :base(x, y, width, height, color)
        {

        }

        public override Graphics.Block Convert(Graphics.DiagramFactory f)
        {
            return f.CreateStart(this.Info);
        }

        public override void Draw(Graphics.CommonGraphics g)
        {
            g.DrawFilledEclipse(this.Info.X, this.Info.Y, this.Info.Width, this.Info.Height, this.Info.Color);
        }

        public override void Fill(Graphics.CommonGraphics g, Color fillColor)
        {
            g.DrawFilledEclipse(this.Info.X, this.Info.Y, this.Info.Width, this.Info.Height, fillColor);
        }

        public override Shape Clone()
        {
            var newShape = new AcStartBlock(this.Info.Clone());
            return newShape;
        }
    }
}
