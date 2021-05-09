using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var htmlDoc = new HtmlDocument();
            var anchor = new AnchorNode();
            var header = new HeadingNode();
            htmlDoc.Add(anchor);
            htmlDoc.Add(header);
            htmlDoc.Execute(new HighlightOperation());
            htmlDoc.Execute(new PlainTextOperation());
            Console.ReadKey();
        }
    }
}
