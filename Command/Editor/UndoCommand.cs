using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Editor
{
    class UndoCommand : ICommand
    {
        private History _history;

        public UndoCommand(History history)
        {
            _history = history;
        }

        public void Execute()
        {
            if (_history.Size() > 0)
            {
                _history.Pop().Unexecute();
            }
        }
    }
}
