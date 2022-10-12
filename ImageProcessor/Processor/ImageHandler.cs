﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor
{
    public class ImageHandler : IImageHandler
    {
        public  Bitmap loadImage(string path)
        {
            Bitmap bmp = null;
            //if (path == null) throw new ArgumentException("test");
            try 
            {
                bmp = new Bitmap(path);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            return bmp;
        }

        public void saveImage(string path, Bitmap image)
        {
            image.Save(path);
        }
    }
}
