namespace DesignPatterns.TemplateMethod
{
    public class GenerateReportTask : Task
    {
        protected override void DoExecute()
        {
            System.Console.WriteLine("Report Generated.");
        }
    }

    public class TransferMoneyTask : Task
    {
        protected override void DoExecute()
        {
            System.Console.WriteLine("Money Transferred.");
        }
    }
}