namespace DesignPatterns.Decorator.Example2
{
    public class Artefact : IArtefact
    {
        public Artefact(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string Render() => Name;
    }
}