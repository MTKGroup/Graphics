using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class AcFactory : DiagramFactory
    {
        public override Block CreateInput(Graphics.ShapeInfo info)
        {
            return new AcInputBlock(info);
        }

        public override Block CreateStart(Graphics.ShapeInfo info)
        {
            return new AcStartBlock(info);
        }
    }
}
