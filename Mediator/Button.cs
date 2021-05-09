using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Button : UIControl
    {
        private bool isEnabled;
        public void SetEnabled(bool isEnabled)
        {
            this.isEnabled = isEnabled;
            owner.Changed(this);
        }
        public bool GetEnabled()
        {
            return isEnabled;
        }

        public Button(DialogBox owner) : base(owner)
        {
        }
    }
}
