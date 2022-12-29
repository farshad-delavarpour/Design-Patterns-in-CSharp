using DesignPatterns.Adapter.fxFilter;

namespace DesignPatterns.Adapter
{
    public class CaramelFilter : IFilter
    {
        private Caramel _caramel;

        public CaramelFilter(Caramel caramel)
        {
            _caramel = caramel;
        }

        public void Apply(Image image)
        {
            _caramel.Init();
            _caramel.Render(image);
        }
    }
}