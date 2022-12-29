namespace DesignPatterns.Composite.Example2
{
    public class Team : IComponent
    {
        private List<IComponent> _components = new();

        public void Deploy()
        {
            foreach (var component in _components)
                component.Deploy();
        }

        public void Add(IComponent component) =>
            _components.Add(component);
    }
}