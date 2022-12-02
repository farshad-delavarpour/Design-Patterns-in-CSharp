namespace DesignPatterns.Memento
{
    public class DocumentState
    {
        private string Content { get; set; }
        private string FontName { get; set; }
        private int FontSize { get; set; }

        public DocumentState(string content, string fontName, int fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }

        public string GetContent() => Content;
        public string GetFontName() => FontName;
        public int GetFontSize() => FontSize;
    }
}