using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();

        public PointIcon GetPointIcon(PointType type)
        {
            if (!icons.ContainsKey(type))
            {
                icons.Add(type,new PointIcon(type,null));
            }
            return icons.GetValueOrDefault(type);
        }
    }
}
