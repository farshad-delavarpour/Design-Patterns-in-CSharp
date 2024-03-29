namespace DesignPatterns.Observer
{
    public class Chart : IObserver
    {
        private readonly DataSource _dataSource;

        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            System.Console.WriteLine($"Chart Updated => {_dataSource.Value}");
        }
    }
}