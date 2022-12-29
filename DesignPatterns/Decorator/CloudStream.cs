namespace DesignPatterns.Decorator
{
    public class CloudStream
    {
        public virtual void Write(string data)
        {
            System.Console.WriteLine($"Storing {data}");
        }
    }
}