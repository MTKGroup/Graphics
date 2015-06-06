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
        Shape shape = new FcInputBlock(50, 50, 155, 111, Color.Black);

        Shape effectedShape; 
        private Point start = new Point();
        private Point end = new Point();
        private bool isDrawing;

        public Form1()

        {
            InitializeComponent();
            effectedShape = new ShadowShape(shape);


            this.DoubleBuffered = true;
            g.Lib = panel1.CreateGraphics();

            panel1.Paint += panel1_Paint;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                  
        }

        void panel1_Paint(object sender, PaintEventArgs e)
        {
            //shape.Draw(g);
            effectedShape.Draw(g);
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
    }
}
