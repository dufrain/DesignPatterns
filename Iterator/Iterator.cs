using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public interface Iterator<T>
    {
        bool HasNext();

        T Current();

        void Next();
    }
}
