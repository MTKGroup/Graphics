using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public abstract class DiagramFactory
    {
        public abstract Block CreateStart(ShapeInfo info);

        public abstract Block CreateInput(ShapeInfo info);
    }
}
