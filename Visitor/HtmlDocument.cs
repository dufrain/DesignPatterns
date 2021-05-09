using System.Collections.Generic;

namespace Visitor
{
    public class HtmlDocument
    { 
        private List<HtmlNode> nodes = new List<HtmlNode>();

        public void Add(HtmlNode node)
        {
            nodes.Add(node);
        }

        public void Execute(IOperation operation)
        {
            foreach (var node in nodes)
            {
                node.Execute(operation);
            }
        }
    }
}
