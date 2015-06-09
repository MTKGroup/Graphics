using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class GdiPlusBitmapGraphics : GdiPlusGraphics
    {
        public GdiPlusBitmapGraphics(Bitmap bitmap)
        {
            this.Lib = System.Drawing.Graphics.FromImage(bitmap);
        }
    }
}
