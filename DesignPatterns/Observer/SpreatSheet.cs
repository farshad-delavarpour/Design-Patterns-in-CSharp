namespace DesignPatterns.Observer
{
    public class SpreatSheet : IObserver
    {
        private readonly DataSource _dataSource;

        public SpreatSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            System.Console.WriteLine($"SpreatSheet Updated => {_dataSource.Value}");
        }
    }
}