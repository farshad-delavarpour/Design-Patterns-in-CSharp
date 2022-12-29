namespace DesignPatterns.Adapter
{
    public class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            System.Console.WriteLine("Vivid Filter Applied.");
        }
    }
}