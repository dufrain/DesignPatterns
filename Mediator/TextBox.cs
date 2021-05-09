using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class TextBox : UIControl
    {
        private string content;
        public void SetContent(string content)
        {
            this.content = content;
            owner.Changed(this);
        }
        public string GetContent()
        {
            return content;
        }

        public TextBox(DialogBox owner) : base(owner)
        {
        }
    }
}
