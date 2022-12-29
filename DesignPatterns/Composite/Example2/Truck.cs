namespace DesignPatterns.Composite.Example2
{
    public class Truck : IComponent
    {
        public void Deploy()
        {
            System.Console.WriteLine("Truck Deployed.");
        }
    }
}