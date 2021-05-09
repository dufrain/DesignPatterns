using Adapter.avaFilters;
using System;

namespace Adapter
{
    // inheritance aproach
    public class CaramelAdapter : Carmel, IFilter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}
