namespace DesignPatterns.Decorator
{
    public class CloudStream : IStream
    {
        public virtual void Write(string data)
        {
            System.Console.WriteLine($"Storing {data}");
        }
    }
}