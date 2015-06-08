using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    public partial class Form1 : Form
    {

        GdiPlusGraphics g = new GdiPlusGraphics();
        GdiPlusGraphics g2 = new GdiPlusGraphics();

        DiagramFactory factory;
        EffectedShape effect;
        Shape shape;
        List<Shape> shapes = new List<Shape>();
        ShapeThumb[] thumbs;

        Shape effectedShape; 
        private Point start = new Point();
        private Point end = new Point();
        private bool isDrawing;


        public Form1()

        {
            InitializeComponent();
            this.DoubleBuffered = true;

            effectedShape = new ShadowShape(shape);
            g.Lib = panel1.CreateGraphics();
            panel1.Paint += panel1_Paint;

            createSelectBoxDiagram();
            createSelectBoxEffect();
            createSelectBoxShape();
        }

        private void createSelectBoxShape()
        {
            ShapeThumb l1 = new ShapeThumb(this.factory.CreateStart(
                                    new ShapeInfo()));
            l1.Bounds   =   new Rectangle(30, 30, 80, 80);
            l1.Text     =   "Start";
            l1.FlatStyle = FlatStyle.Flat;

            ShapeThumb l2 = new ShapeThumb(this.factory.CreateInput(
                                    new ShapeInfo()));
            l2.Bounds = new Rectangle(30, 120, 80, 80);
            l2.Text = "Input";
            l2.FlatStyle = FlatStyle.Flat;
            

            l1.CheckedChanged += ShapeThumb_CheckedChanged;
            l2.CheckedChanged += ShapeThumb_CheckedChanged;

            thumbs = new ShapeThumb[] {l1, l2};
            grpBoxShape.Controls.Add(l1);
            grpBoxShape.Controls.Add(l2);
        }

        void ShapeThumb_CheckedChanged(object sender, EventArgs e)
        {
            ShapeThumb s = sender as ShapeThumb;
            shape = s.Shape;
        }

 

 





        private void createSelectBoxEffect()
        {
            RadioButton r1 = new RadioButton();
            r1.Location = new Point(10, 25);
            r1.Text = "None";

            RadioButton r2 = new RadioButton();
            r2.Location = new Point(10, 50);
            r2.Text = "Shadow";
            r2.Tag = new ShadowShape();

            RadioButton r3 = new RadioButton();
            r3.Location = new Point(10, 75);
            r3.Text = "Highlight";
            r3.Tag = new HighlightShape();

            r1.CheckedChanged += radioEffect_CheckedChanged;
            r2.CheckedChanged += radioEffect_CheckedChanged;
            r3.CheckedChanged += radioEffect_CheckedChanged;

            r1.Checked = true;
            grpBoxEffect.Controls.Add(r1);
            grpBoxEffect.Controls.Add(r2);
            grpBoxEffect.Controls.Add(r3);

        }

        private void radioEffect_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked)
                effect = r.Tag as EffectedShape;
        }



        private void createSelectBoxDiagram()
        {
            RadioButton r1  =   new RadioButton();
            r1.Location     =   new Point(10, 25);
            r1.Text         =   "Activity diagram";
            r1.Tag          =   new AcFactory();

            RadioButton r2  =   new RadioButton();
            r2.Location     =   new Point(10, 50);
            r2.Text         =   "Flow chart diagram";
            r2.Tag          =   new FcFactory();

            r1.CheckedChanged += radiobox_CheckedChanged;
            r2.CheckedChanged += radiobox_CheckedChanged;

            r1.Checked = true;
            grpBoxTypeDiagram.Controls.Add(r1);
            grpBoxTypeDiagram.Controls.Add(r2);

        }

        private void radiobox_CheckedChanged(object sender, EventArgs e)
        {
            var radio = ((RadioButton)sender);
            if (radio.Checked)
            {
                this.factory = (DiagramFactory)radio.Tag;
                
                //change thumbnail
                if (this.thumbs == null) return;
                foreach (var t in this.thumbs.ToList())
                {
                    t.changeFactory(this.factory);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                  
        }

        void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var s in this.shapes)
            {
                s.Draw(g);
            }

            if (shape != null) {
                shape.Info.X = start.X;
                shape.Info.Y = start.Y;
                shape.Info.Width = end.X - start.X;
                shape.Info.Height = end.Y - start.Y;
                shape.Draw(g);
            }
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            this.isDrawing = true;
            this.start.X = this.end.X = e.X;
            this.start.Y = this.end.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isDrawing)
            {
                this.end.X = e.X;
                this.end.Y = e.Y;
                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.isDrawing = false;
            this.end.X = e.X;
            this.end.Y = e.Y;
            panel1.Invalidate();
        }



        private void graphicsLibraryToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;

            if (item.Checked) 
            {
                //turn off others
                foreach (ToolStripMenuItem i in graphicsToolStripMenuItem.DropDownItems)
                {
                    if (!i.Equals(item))
                        i.Checked = false;
                }

            }

        }
    }
}
