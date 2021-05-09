using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = new HttpRequest("admin", "1234");
            var authenticator = new Authenticator(new Logger(new Compressor(null)));

            var webServer = new WebServer(authenticator);

            webServer.Handle(request);

            Console.ReadLine();
        }
    }
}
