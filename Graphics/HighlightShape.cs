using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class HighlightShape : EffectedShape
    {
        public HighlightShape ()
        {

        }

        public HighlightShape(Shape s)
        {
            this.shape = s;
        }

        protected override void Format(Graphics.CommonGraphics g)
        {
            this.shape.Info.X -= 10;
            this.shape.Info.Y -= 10;
            this.shape.Info.Width += 20;
            this.shape.Info.Height += 20;
            shape.Fill(g, Color.DarkGray);

            this.shape.Info.X += 10;
            this.shape.Info.Y += 10;
            this.shape.Info.Width -= 20;
            this.shape.Info.Height -= 20;
            shape.Fill(g, Color.White);
        }

        public override Shape Clone()
        {
            var newshape = new HighlightShape(this.shape.Clone());
            return newshape;
        }

        public override void Fill(CommonGraphics g, Color fillColor)
        {

        }
    }
}
