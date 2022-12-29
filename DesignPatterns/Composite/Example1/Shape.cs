using DesignPatterns.Visitor;

namespace DesignPatterns.Composite
{
    public class Shape : IComponent
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public void Render()
        {
            System.Console.WriteLine($"Render {Name}");
        }
    }
}