﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public abstract class EffectedShape : Shape
    {


        public Shape shape {get; set;}
    
        public override void Draw(CommonGraphics g)
        {
            this.Format(g);
            this.shape.Draw(g);
        }

        public abstract void Format(CommonGraphics g);

    }
}
