using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class BrushTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("brush Icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}
