using System;

namespace Composite 
{
    class Shape : IComponent
    {
        public void Render()
        {
            Console.WriteLine("Render Shape");
        }
    }
}
