using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class SonyTv : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Sony SetChannel");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony turn off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Sony turn on");
        }
    }
}
