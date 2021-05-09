using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Vivid filter applied!");
        }
    }
}
