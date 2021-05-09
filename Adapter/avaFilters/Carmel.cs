using System;

namespace Adapter.avaFilters
{
    public class Carmel
    {
        public void Init() { }

        public void Render(Image image) {
            Console.WriteLine("Carmel fileter applied!");
        }
    }
}
