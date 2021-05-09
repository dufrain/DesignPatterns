using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreCreditCard(new CompressedCloudStream( new EncryptedCloudStream( new CloudStream())));
            Console.ReadKey();
        }

        public static void StoreCreditCard(IStream stream) {
            stream.Write("1234-1234-1234-1234");
        }
    }
}
