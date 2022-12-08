namespace DesignPatterns.ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request) =>
            (request.Username == "Farshad" && request.Password == "123");
    }
}