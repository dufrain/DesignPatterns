using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ImageStorage
    {
        public void Store(string fileName, Compressor compressor, Filter filter)
        {
            compressor.compress(fileName);
            filter.apply(fileName);
        }
    }
}
