namespace DesignPatterns.Visitor
{
    public class HeadingNode : HtmlNode
    {
        public void HighLight()
        {
            System.Console.WriteLine("Heading Highlighted");
        }
    }
}