
namespace Visitor
{
    public class AnchorNode : HtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
