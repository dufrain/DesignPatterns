using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Black And White");
        }
    }
}
