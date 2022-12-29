namespace DesignPatterns.Visitor
{
    public class HtmlDocument
    {
        private readonly List<IHtmlNode> _htmlNodes = new();

        public void AddNode(IHtmlNode node) =>
            _htmlNodes.Add(node);

        public void Execute(IOperation operation)
        {
            foreach (var node in _htmlNodes)
                node.Execute(operation);
        }
    }
}