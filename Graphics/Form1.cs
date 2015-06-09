using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

        CommonGraphics graphic;
        Bitmap buffer;
        bool isBufferring;

        EffectedShape effect;
        Shape shape;
        Diagram diagram;
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
            panel1.Paint += panel1_Paint;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            buffer = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            //panel1.GetType().GetMember"DoubleBuffered").SetValue(panel1, true);

            createSelectBoxDiagram();
            createSelectBoxEffect();
            createSelectBoxShape();
            configGraphicsLib();

            
        }

        private void configGraphicsLib()
        {
            
            gdiLibraryToolStripMenuItem.Tag     =   new GdiPlusGraphics(System.Drawing.Graphics.FromImage(this.buffer));
            cairoLibraryToolStripMenuItem.Tag   =   new CairoGraphics(System.Drawing.Graphics.FromImage(this.buffer));
            gdiLibraryToolStripMenuItem.Checked =   true;
        }

        private void createSelectBoxShape()
        {
            ShapeThumb l1 = new ShapeThumb(this.diagram.Factory.CreateStart(
                                    new ShapeInfo()));
            l1.Bounds   =   new Rectangle(50, 30, 80, 80);
            l1.Text     =   "Start";
            l1.FlatStyle = FlatStyle.Flat;

            ShapeThumb l2 = new ShapeThumb(this.diagram.Factory.CreateInput(
                                    new ShapeInfo()));
            l2.Bounds = new Rectangle(50, 120, 80, 80);
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
            var l = sender as ShapeThumb;
            if (l.Checked) {
                shape = l.GetClonedShape(this.diagram.Factory);
                shape.Info.Color = panel1.ForeColor;
            }
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
            {
                effect = r.Tag as EffectedShape;
            }
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
                if (this.diagram == null)
                    this.diagram = new Diagram((DiagramFactory)radio.Tag);
                else
                {
                    this.diagram.Convert((DiagramFactory)radio.Tag);
                    PrepareDraw();
                    panel1.Invalidate();
                }
                    
                
                //change thumbnail
                if (this.thumbs == null) return;
                foreach (var t in this.thumbs.ToList())
                {
                    t.changeFactory(this.diagram.Factory);
                }

                //change current shape
                if (this.shape != null)
                    this.shape = (this.shape as Block).Convert(this.diagram.Factory);
            }
        }

        System.Drawing.Graphics a;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        long prev = 0;
        void panel1_Paint(object sender, PaintEventArgs e)
        {

            base.OnPaint(e);

            if (!isBufferring) 
            {
                isBufferring = true;
                e.Graphics.DrawImage(this.buffer, 0, 0);
                isBufferring = false;
            }


            
            
        }

        void PrepareDraw() 
        {
            if (isBufferring) return;
            isBufferring = true;

            graphic.Clear(panel1.BackColor);
            diagram.Draw(graphic);

            if (shape != null && isDrawing)
            {
                shape.Info.X = start.X;
                shape.Info.Y = start.Y;
                shape.Info.Width = end.X - start.X;
                shape.Info.Height = end.Y - start.Y;
                if (effect != null)
                    effect.Draw(graphic);
                else
                    shape.Draw(graphic);
            }

            isBufferring = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.isDrawing = true;
            this.start.X = e.X;
            this.start.Y = e.Y;
            if (effect != null) 
            {
                effect.shape = shape;
            }
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isDrawing)
            {
                this.end.X = e.X;
                this.end.Y = e.Y;
                PrepareDraw();
                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.isDrawing = false;
            this.end.X = e.X;
            this.end.Y = e.Y;

            if (effect != null && shape != null)
                this.diagram.addShape(effect);
            else if (shape != null)
                this.diagram.addShape(shape);

            PrepareDraw();
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
            graphic = item.Tag as CommonGraphics;
            PrepareDraw();
            panel1.Invalidate();

        }

        private void jpegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            CommonGraphics g = new GdiPlusJpegGraphics(bitmap);
            g.Clear(panel1.BackColor);
            if (diagram != null)
                diagram.Draw(g);

            bitmap.Save("output.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            var process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo("output.jpg");
            process.StartInfo.WorkingDirectory = Application.StartupPath;
            process.Start();


        }

        private void bitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            CommonGraphics g = new GdiPlusJpegGraphics(bitmap);
            g.Clear(panel1.BackColor);
            if (diagram != null)
                diagram.Draw(g);

            bitmap.Save("output.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            var process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo("output.bmp");
            process.StartInfo.WorkingDirectory = Application.StartupPath;
            process.Start();
        }

        private void openImageFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath);
        }
    }
}
