using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Editor
    {
        public string content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(content);
        }

        public void restore(EditorState state)
        {
            if (state != null)
            {
                content = state.Content;
            }
        }
    }
}
