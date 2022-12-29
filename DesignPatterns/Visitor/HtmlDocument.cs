namespace DesignPatterns.Visitor
{
    public class HtmlDocument
    {
        private readonly List<HtmlNode> _htmlNodes = new();

        public void AddNode(HtmlNode node) =>
            _htmlNodes.Add(node);

        public void HighLight()
        {
            foreach (var node in _htmlNodes)
                node.HighLight();
        }
    }
}