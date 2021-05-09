
namespace MediatorObserver
{
    public class TextBox : UIControl
    {
        private string content;
        public void SetContent(string content)
        {
            this.content = content;
            NotifyEventHandlers();
        }
        public string GetContent()
        {
            return content;
        }
    }
}
