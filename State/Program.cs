using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.currentTool = new EraserTool();
            canvas.mouseDown();
            canvas.mouseUp();
            Console.Read();
        }
    }
}
