using DesignPatterns.Visitor;

namespace DesignPatterns.Composite
{
    public class Group : IComponent
    {
        private List<IComponent> _components = new();

        public void Render()
        {
            foreach (var component in _components)
                component.Render();
        }

        public void Add(IComponent component) =>
            _components.Add(component);
    }
}