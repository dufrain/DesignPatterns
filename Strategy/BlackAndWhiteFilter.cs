using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class BlackAndWhiteFilter : Filter
    {
        public void apply(string fileName)
        {
            Console.WriteLine("Applying B&W filter");
        }
    }
}
