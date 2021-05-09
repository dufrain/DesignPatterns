using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface Compressor
    {
        void compress(string fileName);
    }
}
