using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class Diagram : Shape
    {
        public DiagramFactory factory
        {
            get
            {
                return factory;
            }
            set
            {
                factory = value;
            }
        }

        public List<Block> blockList
        {
            get
            {
                return blockList;
            }
            set
            {
                blockList = value;
            }
        }

        public Diagram(DiagramFactory f)
        {
            factory = f;
        }

        public override void Draw(Graphics.CommonGraphics g)
        {
            foreach (var block in blockList)
            {
                block.Draw(g); 
            }
        }

        public void Convert(DiagramFactory f)
        {
            

        }        
    }
}
