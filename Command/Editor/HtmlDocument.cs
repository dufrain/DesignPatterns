using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Editor
{
    class HtmlDocument
    {
        public string Content { get; set; }

        public void MakeBold()
        {
            Content = "<b>" + Content + "</b>";
        }
    }
}
