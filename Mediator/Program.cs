using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ArticlesDialogBox dialogBox = new ArticlesDialogBox();
            ListBox listbox = new ListBox(dialogBox);
            TextBox textBox = new TextBox(dialogBox);
            Button button = new Button(dialogBox);
            dialogBox.RegisterControls(listbox, textBox, button);
            dialogBox.Simulate();
            Console.ReadKey();
        }
    }
}
