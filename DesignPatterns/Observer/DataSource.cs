namespace DesignPatterns.Observer
{
    public class DataSource : Subject
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                NotifyObservers(_value);
            }
        }
    }
}