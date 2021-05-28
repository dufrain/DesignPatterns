
namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new AdvancedRemoteControl(new SamsungTv());
            remoteControl.TurnOn();
            System.Console.ReadKey();
        }

    }
}
