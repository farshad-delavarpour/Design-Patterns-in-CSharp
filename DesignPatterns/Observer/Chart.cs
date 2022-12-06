namespace DesignPatterns.Observer
{
    public class Chart : IObserver
    {
        public void Update(object value)
        {
            System.Console.WriteLine($"Chart Updated => {value}");
        }
    }
}