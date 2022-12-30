namespace DesignPatterns.Bridge
{
    public class SamsungTV : Device
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Samsung: turnOn");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Samsung: turnOff");
        }

        public void SetChannel(int number)
        {
            System.Console.WriteLine("Samsung: setChannel");
        }
    }
}