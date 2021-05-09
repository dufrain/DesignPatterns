using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageStorage = new ImageStorage();

            imageStorage.Store("a", new JpegCompressor(),
                new BlackAndWhiteFilter());
            Console.ReadKey();
        }
    }
}
