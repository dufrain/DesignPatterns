using Adapter.avaFilters;

namespace Adapter
{
    // composition aproach
    public class CaramelFilter : IFilter
    {
        private Carmel carmel;

        public CaramelFilter(Carmel carmel)
        {
            this.carmel = carmel;
        }

        public void Apply(Image image)
        {
            carmel.Render(image);
        }
    }
}
