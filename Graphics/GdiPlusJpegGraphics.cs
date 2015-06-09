using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Graphics
{
    public class GdiPlusJpegGraphics : GdiPlusGraphics
    {
         
        public GdiPlusJpegGraphics(Bitmap bitmap) 
        {
            Lib = System.Drawing.Graphics.FromImage(bitmap);
        }
    }
}
