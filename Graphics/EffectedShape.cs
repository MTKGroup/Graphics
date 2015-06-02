using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public abstract class EffectedShape : Shape
    {
        public Shape shape
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public override void Draw(CommonGraphics g)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Format(CommonGraphics g, Shape shape)
        {
            throw new System.NotImplementedException();
        }
    }
}
