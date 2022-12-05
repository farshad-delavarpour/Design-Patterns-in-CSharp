namespace DesignPatterns.Command
{
    public class AddCustomerCommand : Command
    {
        private CustomerService _customerService;
        public AddCustomerCommand(CustomerService customerService)
        {
            _customerService = customerService;
        }
        public void Execute()
        {
            _customerService.AddCustomer();
        }
    }
}