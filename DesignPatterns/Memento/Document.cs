namespace DesignPatterns.Memento
{
    public class Document
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }

        public DocumentState CreateState()
        {
            return new DocumentState(Content, FontName, FontSize);
        }

        public void Restore(DocumentState state)
        {
            Content = state.GetContent();
            FontName = state.GetFontName();
            FontSize = state.GetFontSize();
        }

        public override string ToString()
        {
            return $"Content = {Content}, FontName = {FontName}, FontSize = {FontSize}";
        }
    }
}