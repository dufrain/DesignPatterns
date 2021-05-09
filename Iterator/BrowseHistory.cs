using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class BrowseHistory
    {
        private List<string> urls = new List<string>();

        public void Push(string url)
        {
            urls.Add(url);
        }

        public string Pop()
        {
            var url = urls[urls.Count - 1];
            urls.RemoveAt(urls.Count - 1);
            return url;
        }

        public Iterator<string> CreateInterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : Iterator<string>
        {
            private BrowseHistory history;
            private int index;

            public ListIterator(BrowseHistory history)
            {
                this.history = history;
            }

            public string Current()
            {
                return history.urls[index]; 
            }

            public bool HasNext()
            {
                return index < history.urls.Count;
            }

            public void Next()
            {
                index++; 
            }
        }
    }
}
