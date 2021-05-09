using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("1234");
            var authToken = server.Authenticate("asd", "asd");
            server.Send(authToken, new Message(message), target);
            connection.disconnect();
        }
    }
}
