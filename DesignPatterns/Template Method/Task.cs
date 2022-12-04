namespace DesignPatterns.TemplateMethod
{
    public abstract class Task
    {
        private readonly Logger _logger;

        public Task(Logger logger)
        {
            _logger = logger;
        }

        public void Execute()
        {
            _logger.CreateLog();

            DoExecute();
        }

        protected abstract void DoExecute();
    }
}