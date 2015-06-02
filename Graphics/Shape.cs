using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class Shape
    {
        public ShapeInfo info
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public virtual void Draw(CommonGraphics g)
        {
            throw new System.NotImplementedException();
        }
    }
}
