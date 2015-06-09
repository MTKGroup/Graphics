using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class CairoGraphics : CommonGraphics
    {
        private System.Drawing.Graphics lib;
        private Cairo.Context context;
        private Cairo.Surface sur;
        public CairoGraphics() { }

        public CairoGraphics(System.Drawing.Graphics graphics)
        {
            // TODO: Complete member initialization
            //sur = new Cairo.Win32Surface(graphics.GetHdc());
            //context = new Cairo.Context(sur);
            this.lib = graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        public System.Drawing.Graphics Lib
        {
            get { return lib; }
            set { lib = value; }
        }

        public override void DrawEclipse(int x, int y, int width, int height, Color color)
        {
            Pen pen = new Pen(color);
            lib.DrawEllipse(pen, x, y, width, height);
        }

        public override void DrawLine(int x1, int y1, int x2, int y2, Color color)
        {
            Pen pen = new Pen(color);
            //context.SetSourceRGB(color.R, color.G, color.B);
            //context.MoveTo(x1, y1);
            //context.LineTo(x2, y2);
            //context.Stroke();
            //context.Save();
            lib.DrawLine(pen, x1, y1, x2, y2);
        }

        public override void DrawRectangle(int x, int y, int width, int height, Color color)
        {
            Pen pen = new Pen(color);
            lib.DrawRectangle(pen, x, y, width, height);
        }

        public override void DrawString(int x, int y, string text, Color color)
        {
            Brush brush = new SolidBrush(color);
            Font font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            lib.DrawString(text, font, brush, x, y, stringFormat);
        }

        public override void DrawFilledEclipse(int x, int y, int width, int height, Color color)
        {
            SolidBrush solidBrush = new SolidBrush(color);
            lib.FillEllipse(solidBrush, x, y, width, height);
        }

        public override void FillPolygon(System.Drawing.Point[] points, System.Drawing.Color fillColor)
        {
            Brush brush = new SolidBrush(fillColor);

            this.lib.FillPolygon(brush, points);
        }



        public override void Clear(Color color)
        {
            this.Lib.Clear(color);
            //context.SetSourceRGB(color.R, color.G, color.B);
            //context.Fill();
        }
    }
}
