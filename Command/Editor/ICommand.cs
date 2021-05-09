﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Editor
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}
