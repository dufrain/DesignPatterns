
namespace Visitor
{
    public class HeadingNode : HtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
