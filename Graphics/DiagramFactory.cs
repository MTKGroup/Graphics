using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class DiagramFactory
    {
        public virtual Block CreateStart(ShapeInfo info)
        {
            throw new System.NotImplementedException();
        }

        public virtual Block CreateInput(ShapeInfo info)
        {
            throw new System.NotImplementedException();
        }
    }
}
