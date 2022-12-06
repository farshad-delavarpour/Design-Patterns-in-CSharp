namespace DesignPatterns.Observer
{
    public class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer) => _observers.Add(observer);

        public void NotifyObservers(object value)
        {
            foreach (var observer in _observers)
                observer.Update();
        }

        public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

    }
}