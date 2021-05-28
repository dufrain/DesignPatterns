using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new PointService(new PointIconFactory());
            foreach (var point in service.GetPoints())
            {
                point.Draw();
            }
            Console.ReadKey();
        }
    }
}
