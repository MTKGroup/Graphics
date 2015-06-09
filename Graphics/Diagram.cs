using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class Diagram : Shape
    {
        public DiagramFactory Factory {get; set;}

        public List<Shape> blockList {get; set;}

        public Diagram(DiagramFactory f)
        {
            Factory = f;
            blockList = new List<Shape>();
        }

        public override void Draw(Graphics.CommonGraphics g)
        {
            
            foreach (var block in this.blockList)
            {
                block.Draw(g);
            }
        }

        public void Convert(DiagramFactory f)
        {
            List<Shape> convertedBlockList = new List<Shape>();
            Shape convertedBlock;
            foreach (var block in this.blockList)
            {

                convertedBlock = extractEffectecShape(block, f);
    

                if (convertedBlock != null)
                    convertedBlockList.Add(convertedBlock);
            }

            this.blockList = convertedBlockList;
            this.Factory = f;
        }

        private Shape extractEffectecShape(Shape shape, DiagramFactory f)
        {
            if (shape is Block)
                return (shape as Block).Convert(f);
            if (shape is EffectedShape) {
                var newShape = shape.Clone() as EffectedShape;
                newShape.shape = extractEffectecShape((shape as EffectedShape).shape, f);
                return newShape;
            }
            return null;
        }

        internal void addShape(Shape tmp)
        {
            if (tmp != null)
                this.blockList.Add(tmp.Clone());
        }

        public override void Fill(CommonGraphics g, System.Drawing.Color fillColor)
        {
        }

        public override Shape Clone()
        {
            return null;
        }
    }
}
