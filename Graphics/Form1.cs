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
        private Point start;
        private Point end;
        private bool ve;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            this.Paint += Form1_Paint;
            g.Lib = panel1.CreateGraphics();
            panel1.Paint += panel1_Paint;


        }

        void panel1_Paint(object sender, PaintEventArgs e)
        {
            
                g.DrawLine(this.start.X, this.start.Y, this.end.X, this.end.Y);
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.ve = true;
            this.start = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.ve)
            { 
                this.end = new Point(e.X, e.Y);
                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.ve = false;
            this.end = new Point(e.X, e.Y);
            panel1.Invalidate();
        }
    }
}
