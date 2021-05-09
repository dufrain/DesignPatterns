using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new TransferMoneyTask();
            task.Execute();

            Console.ReadKey();
        }
    }
}
