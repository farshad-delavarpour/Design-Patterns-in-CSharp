namespace DesignPatterns.Mediator
{
    public class TextBox : UIControl
    {
        private string _content = string.Empty;

        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
                _owner.Changed(this);
            }
        }

        public TextBox(DialogBox dialogBox) : base(dialogBox)
        {
        }
    }
}