namespace DesignPatterns.Command
{
    public class Button
    {
        private Command _command;

        public Button(Command command)
        {
            _command = command;
        }

        public void Click()
        {
            _command.Execute();
        }
    }
}