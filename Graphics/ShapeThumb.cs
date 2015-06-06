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

                    shape.Info.Color = Color.FromArgb(255, r, g, b);

                    Invalidate();
                }

                
            }
        }

        public ShapeThumb(Shape s) 
        {
            color = ForeColor;
            shape = s;

            shape.Info = new ShapeInfo(5, 5, this.Width - 10, this.Height - 10, ForeColor);
        }

        protected override void OnClientSizeChanged(EventArgs e)
        {
            base.OnClientSizeChanged(e);
            shape.Info = new ShapeInfo(5, 5, this.Width - 10, this.Height - 10, ForeColor);

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

        }

        protected override void OnMouseUp(MouseEventArgs e)
        {

            shape.Info.X = 5;
            shape.Info.Y = 5;
            shape.Info.Width = this.Width - 10;
            shape.Info.Height = this.Height - 10;
            Invalidate();

            base.OnMouseUp(e);

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            shape.Info.X = 10;
            shape.Info.Y = 10;
            shape.Info.Width = this.Width - 20;
            shape.Info.Height = this.Height - 20;
            Invalidate();

        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            foreach (var c in this.Parent.Controls)
            {
                if (c is ShapeThumb && !c.Equals(this) && this.Checked)
                    (c as ShapeThumb).Checked = false;
            }

            this.Checked = true;
        }
    }
}
