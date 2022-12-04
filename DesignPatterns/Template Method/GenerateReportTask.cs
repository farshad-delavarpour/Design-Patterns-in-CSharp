namespace DesignPatterns.TemplateMethod
{
    public class GenerateReportTask : Task
    {
        public GenerateReportTask(Logger logger) : base(logger)
        {
        }

        protected override void DoExecute()
        {
            System.Console.WriteLine("Report Generated.");
        }
    }

    public class TransferMoneyTask : Task
    {
        public TransferMoneyTask(Logger logger) : base(logger)
        {
        }

        protected override void DoExecute()
        {
            System.Console.WriteLine("Money Transferred.");
        }
    }
}