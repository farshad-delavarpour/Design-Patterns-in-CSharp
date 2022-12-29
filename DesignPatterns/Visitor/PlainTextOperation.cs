namespace DesignPatterns.Visitor
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode headingNode)
        {
            System.Console.WriteLine("Heading Node PlainText");
        }

        public void Apply(AnchorNode anchorNode)
        {
            System.Console.WriteLine("Anchore Node PlainText");
        }
    }
}