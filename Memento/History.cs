using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class History
    {
        private List<EditorState> states = new List<EditorState>();

        public void push(EditorState state)
        {
            states.Add(state);
        }

        public EditorState pop()
        {
            if (states.Count == 0)
            {
                return null;
            }

            var lastState = states[states.Count - 1];
            states.RemoveAt(states.Count - 1);
            return lastState;
        }
    }
}
