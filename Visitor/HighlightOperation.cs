using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Highlight Heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Highlight Anchor");
        }
    }
}
