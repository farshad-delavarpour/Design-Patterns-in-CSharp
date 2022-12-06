namespace DesignPatterns.Mediator
{
    public class ArticleDialogBox : DialogBox
    {
        private ListBox _articleListBox;
        private Button _saveButton;
        private TextBox _textBox;

        public ArticleDialogBox()
        {
            _articleListBox = new ListBox(this);
            _saveButton = new Button(this);
            _textBox = new TextBox(this);
        }

        public void SimulateUserInteraction()
        {
            _articleListBox.Selection = "Article 1";
            System.Console.WriteLine($"TextBox => {_textBox.Content}");
            System.Console.WriteLine($"Button => {_saveButton.IsEnabled}");

            _textBox.Content = "";
            System.Console.WriteLine($"TextBox => {_textBox.Content}");
            System.Console.WriteLine($"Button => {_saveButton.IsEnabled}");
        }

        public override void Changed(UIControl control)
        {
            if (control == _articleListBox)
                ArticleSelected();
            else if (control == _textBox)
                TitleChanged();

        }

        private void ArticleSelected()
        {
            _textBox.Content = _articleListBox.Selection;
            _saveButton.IsEnabled = true;
        }

        private void TitleChanged() => _saveButton.IsEnabled = !string.IsNullOrEmpty(_textBox.Content);
    }
}