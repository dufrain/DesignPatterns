using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Editor
{
    public class History
    {
        private List<IUndoableCommand> _commands = new List<IUndoableCommand>();

        public void Push(IUndoableCommand command)
        {
            _commands.Add(command);
        }

        public IUndoableCommand Pop()
        {
            var lastCommant = _commands[_commands.Count - 1];
            _commands.RemoveAt(_commands.Count - 1);
            return lastCommant;
        }

        public int Size()
        {
            return _commands.Count;
        }
    }
}
