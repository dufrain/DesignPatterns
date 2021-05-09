using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new NotificationService();
            service.Send("hi","target");
            Console.ReadKey();
        }
    }
}
