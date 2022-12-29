namespace DesignPatterns.Visitor
{
    public class HighLightOperation : IOperation
    {
        public void Apply(HeadingNode headingNode)
        {
            System.Console.WriteLine("HeadingNode Highlighted");
        }

        public void Apply(AnchorNode anchorNode)
        {
            System.Console.WriteLine("AnchoreNode Highlighted");
        }
    }
}