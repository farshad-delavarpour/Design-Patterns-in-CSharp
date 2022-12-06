namespace DesignPatterns.Mediator
{
    public class UIControl
    {
        protected readonly DialogBox _owner;

        public UIControl(DialogBox dialogBox)
        {
            _owner = dialogBox;
        }
    }
}