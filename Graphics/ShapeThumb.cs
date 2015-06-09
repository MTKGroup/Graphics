using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    class ShapeThumb : Label
    {
        private Color color;
        private Shape shape;

        public Shape Shape
        {
            get { return shape; }
            private set { shape = value; }
        }
        private GdiPlusGraphics g2 = new GdiPlusGraphics();
        private bool _checked;

        public event EventHandler CheckedChanged;


        public bool Checked
        {
            get { return _checked; }
            set 
            {
                if (_checked != value)
                {
                    _checked = value;

                    CheckedChanged(this, new EventArgs());

                    int r = (int)(shape.Info.Color.R * 1.3);
                    int g = (int)(shape.Info.Color.G * 1.3);
                    int b = (int)(shape.Info.Color.B * 1.3);

                 

                    if (value)
                        shape.Info.Color = Color.FromArgb(255, r, g, b);
                    else
                        shape.Info.Color = this.ForeColor;

                    Invalidate();
                }

                
            }
        }

        public ShapeThumb(Shape s) 
        {
            color = ForeColor;
            shape = s;
            shape.Info = new ShapeInfo(this.Width / 5, this.Height / 5, this.Width * 3 / 5, this.Height * 3 / 5, ForeColor);
        }

        

        protected override void OnClientSizeChanged(EventArgs e)
        {
            base.OnClientSizeChanged(e);
            shape.Info = new ShapeInfo(this.Width / 5, this.Height / 5, this.Width * 3 / 5, this.Height * 3 / 5, ForeColor);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            g2.Lib = e.Graphics;

            e.Graphics.Clear(this.Parent.BackColor);
            shape.Draw(g2);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseHover(e);

            shape.Info.Color = Color.ForestGreen;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            if (!this.Checked)
            {
                shape.Info.Color = this.ForeColor;
                Invalidate();
            }
            else
            {
                //shape.Info.Color = Color.FromArgb(255, 255, 200, 10);
                Invalidate();
            }

        }

        protected override void OnMouseUp(MouseEventArgs e)
        {

            shape.Info.X = this.Width/5;
            shape.Info.Y = this.Height / 5;
            shape.Info.Width = this.Width * 3 / 5;
            shape.Info.Height = this.Height * 3 / 5;
            Invalidate();

            base.OnMouseUp(e);

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            shape.Info.X = this.Width / 4;
            shape.Info.Y = this.Height / 4;
            shape.Info.Width = this.Width /2;
            shape.Info.Height = this.Height /2;
            Invalidate();

        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            foreach (var c in this.Parent.Controls)
            {
                if (c is ShapeThumb && !c.Equals(this) && (c as ShapeThumb).Checked)
                {
                    (c as ShapeThumb).Checked = false;
                    
                }
            }

            this.Checked = true;
        }

        internal void changeFactory(DiagramFactory diagramFactory)
        {
            this.shape = ((Block)this.shape).Convert(diagramFactory);
            Invalidate();
        }

        internal Graphics.Shape GetClonedShape(DiagramFactory diagramFactory)
        {
            var block = shape as Block;
            return block.Convert(diagramFactory);
        }
    }
}
