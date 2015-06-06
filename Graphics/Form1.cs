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
        Block block1 = new AcInputBlock(50, 50, 155, 111, Color.Black);
        Block block2 = new AcStartBlock(50, 150, 155, 111, Color.Black);
        Diagram diagram = new Diagram(new AcFactory());
        DiagramFactory factory = new FcFactory();

        Shape effectedShape; 

        public Form1()

        {
            InitializeComponent();
            effectedShape = new ShadowShape(block1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Paint += Form1_Paint;
            g.Lib = panel1.CreateGraphics();
            panel1.Paint += panel1_Paint;

            diagram.blockList.Add(block1);
            diagram.blockList.Add(block2);

            
        }

        void panel1_Paint(object sender, PaintEventArgs e)
        {
            diagram.Convert(factory);
            diagram.Draw(g);
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
    }
}
