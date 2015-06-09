using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class ShadowShape : EffectedShape
    {
        public ShadowShape ()
        {

        }

        public ShadowShape (Shape s)
        {
            this.shape = s;
        }

        protected override void Format(Graphics.CommonGraphics g)
        {
            this.shape.Info.X += 10;
            this.shape.Info.Y += 10;
            shape.Fill(g, Color.DarkGray);

            this.shape.Info.X -= 10;
            this.shape.Info.Y -= 10;
            shape.Fill(g, Color.White);
        }

        public override Shape Clone()
        {
            var newshape = new ShadowShape(this.shape.Clone());
            return newshape;
        }

        public override void Fill(CommonGraphics g, Color fillColor)
        {
        }
    }
}
