namespace DesignPatterns.Bridge
{
    public class SonyTV : Device
    {
        public void TurnOn()
        {
            Console.WriteLine("Sony: turnOn");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony: turnOff");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine("Sony: setChannel");
        }
    }
}