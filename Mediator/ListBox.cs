using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ListBox : UIControl
    {
        private string selector;
        public void SetSelector(string selector)
        {
            this.selector = selector;
            owner.Changed(this); 
        }
        public string GetSelector()
        {
            return selector;
        }

        public ListBox(DialogBox owner) : base(owner)
        {
        }
    }
}
