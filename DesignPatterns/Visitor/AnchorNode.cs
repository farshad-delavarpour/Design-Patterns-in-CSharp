namespace DesignPatterns.Visitor
{
    public class AnchorNode : HtmlNode
    {
        public void HighLight()
        {
            System.Console.WriteLine("Anchore Highlighted");
        }
    }
}