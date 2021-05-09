using System;
using System.Collections.Generic;

namespace Composite
{
    class Group : IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        public void add(IComponent component)
        {
            components.Add(component);
        }

        public void Render()
        {
            foreach (var components in components)
            {
                components.Render();
            }
        }
    }
}
