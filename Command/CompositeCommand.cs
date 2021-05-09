using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class CompositeCommand : ICommand
    {
        private List<ICommand> commands = new List<ICommand>();

        public void Add(ICommand command)
        {
            commands.Add(command);
        }

        public void Execute()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
    }
}
