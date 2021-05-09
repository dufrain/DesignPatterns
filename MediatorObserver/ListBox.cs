
using System;

namespace MediatorObserver
{
    public class ListBox : UIControl
    {
        private string selector;
        public void SetSelector(string selector)
        {
            this.selector = selector;
            NotifyEventHandlers();
        }
        public string GetSelector()
        {
            return selector;
        }
    }
}
