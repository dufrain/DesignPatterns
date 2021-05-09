using System;

namespace Decorator
{
    class CloudStream : IStream
    {
        public void Write(string data)
        {
            Console.WriteLine("Write stream to cloud:"+ data);
        }
    }
}
