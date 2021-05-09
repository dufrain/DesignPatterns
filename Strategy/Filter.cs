using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface Filter
    {
        void apply(string fileName);
    }
}
