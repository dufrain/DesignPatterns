using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Canvas
    {
        public Tool currentTool { get; set; }

        public void mouseDown() {
            currentTool.mouseDown();
        }

        public void mouseUp()
        {
            currentTool.mouseUp();
        }
    }
}
