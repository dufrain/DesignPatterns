using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class SelectionTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("Selection Icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Draw a dashed rectangle");
        }
    }
}
