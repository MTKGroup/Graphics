using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class Diagram : Shape
    {
        public DiagramFactory factory {get; set;}

        public List<Block> blockList {get; set;}

        public Diagram(DiagramFactory f)
        {
            factory = f;
            blockList = new List<Block>();
        }

        public override void Draw(Graphics.CommonGraphics g)
        {
<<<<<<< HEAD
            
=======
>>>>>>> origin/Nam
            foreach (var block in this.blockList)
            {
                block.Draw(g);
            }
        }

        public void Convert(DiagramFactory f)
        {
            List<Block> convertedBlockList = new List<Block>();
            foreach (var block in this.blockList)
            {
                Block convertedBlock = block.Clone(f);
                convertedBlockList.Add(convertedBlock);
            }

            this.blockList = convertedBlockList;
            this.factory = f;
        }        
    }
}
