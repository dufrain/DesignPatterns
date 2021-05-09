using Command.Editor;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var history = new History();
            var document = new HtmlDocument();
            document.Content = "Hello World";
            var boldCommand = new BoldCommand(document, history);
            boldCommand.Execute(); 
            Console.WriteLine(document.Content);
            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            Console.WriteLine(document.Content);
            Console.ReadKey();

            //TODO: add more commands here
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command);
            button.Click();
            Console.ReadKey();

            var composite = new CompositeCommand();
            composite.Add(new ResizeCommand());
            composite.Add(new BlackAndWhiteCommand());
            composite.Execute();
            Console.ReadKey();
        }
    } 
}
