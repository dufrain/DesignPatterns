using System;

namespace Visitor
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("PlainTextOperation Heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("PlainTextOperation Anchor");
        }
    }
}
