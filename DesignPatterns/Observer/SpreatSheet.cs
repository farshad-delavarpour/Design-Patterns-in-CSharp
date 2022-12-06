namespace DesignPatterns.Observer
{
    public class SpreatSheet : IObserver
    {
        public void Update(object value)
        {
            System.Console.WriteLine($"SpreatSheet Updated => {value}");
        }
    }
}