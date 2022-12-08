namespace DesignPatterns.ChainOfResponsibility
{
    public class Compressor : Handler
    {
        public Compressor(Handler handler) : base(handler)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Compress ...");
            return true;
        }
    }
}