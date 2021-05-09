using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var history = new BrowseHistory();
            history.Push("a");
            history.Push("b");
            history.Push("c");

            Iterator<string> iterator = history.CreateInterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }

            Console.ReadKey();
        }
    }
}
