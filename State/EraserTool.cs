using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class EraserTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("Eraser Icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Erase something");
        }
    }
}
