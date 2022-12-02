namespace DesignPatterns.Memento
{
    public class DocumentHistory
    {
        private List<DocumentState> States = new List<DocumentState>();

        public void Push(DocumentState state) =>
            States.Add(state);

        public DocumentState Pop()
        {
            var lastItem = States.LastOrDefault();

            if (lastItem != null)
                States.Remove(lastItem);

            return lastItem;
        }
    }
}