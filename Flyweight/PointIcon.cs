using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class PointIcon
    {
        public PointType type { get; }
        public byte[] icon { get; }

        public PointIcon(PointType type, byte[] icon)
        {
            this.type = type;
            this.icon = icon;
        }
    }
}
