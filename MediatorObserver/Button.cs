
namespace MediatorObserver
{
    public class Button : UIControl
    {
        private bool isEnabled;
        public void SetEnabled(bool isEnabled)
        {
            this.isEnabled = isEnabled;
            NotifyEventHandlers();
        }
        public bool GetEnabled()
        {
            return isEnabled;
        }

       
    }
}
