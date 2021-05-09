using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class JpegCompressor : Compressor
    {
        public void compress(string fileName)
        {
            Console.WriteLine("Compressing using jpeg");
        }
    }
}
