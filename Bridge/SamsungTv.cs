using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class SamsungTv : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Samsung SetChannel");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung turn off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Samsung turn on");
        }
    }
}
