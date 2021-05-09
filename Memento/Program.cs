using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.content = "a";
            history.push(editor.CreateState());

            editor.content = "b";
            history.push(editor.CreateState());

            editor.content = "c";
            editor.restore(history.pop());

            Console.WriteLine(editor.content);
            editor.restore(history.pop());

            Console.WriteLine(editor.content);

            editor.restore(history.pop());
            Console.WriteLine(editor.content);
            Console.ReadKey();

        }
    }
}
