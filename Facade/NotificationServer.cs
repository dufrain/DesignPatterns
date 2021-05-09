using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class NotificationServer
    {
        // connect() =>Connection
        // authenticate(appId, key)
        // send(authToken, message, target)
        // conn.disconnect()

        public Connection Connect(string ipAddress)
        {
            return new Connection();
        }

        public AuthToken Authenticate(string appId, string key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken authToken, Message message, string target)
        {
            Console.WriteLine("Sending a message");
        }
    }
}
