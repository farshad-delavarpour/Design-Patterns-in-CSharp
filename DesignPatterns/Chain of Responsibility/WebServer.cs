namespace DesignPatterns.ChainOfResponsibility
{
    public class WebServer
    {
        private Handler _handler;

        public WebServer(Handler handler)
        {
            _handler = handler;
        }

        public void handle(HttpRequest request)
        {
            _handler.Handle(request);
        }
    }
}