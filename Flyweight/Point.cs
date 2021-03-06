using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Point
    {
        private int x;
        private int y;
        private PointIcon pointIcon;

        public Point(int x, int y, PointIcon pointIcon)
        {
            this.x = x;
            this.y = y;
            this.pointIcon = pointIcon;
        }

        public void Draw()
        {
            Console.WriteLine($"{pointIcon.type} at ({x},{y})");
        }
    }
}
