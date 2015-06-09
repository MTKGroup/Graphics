using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class FcFactory : DiagramFactory
    {

        public override Block CreateInput(Graphics.ShapeInfo info)
        {
            
            return new FcInputBlock(info.Clone());
        }

        public override Block CreateStart(Graphics.ShapeInfo info)
        {
            return new FcStartBlock(info.Clone());
        }
    }
}
