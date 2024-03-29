namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler _next;

        public Handler(Handler next)
        {
            _next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (!DoHandle(request))
                return;

            if (_next != null)
                _next.Handle(request);
        }

        public abstract bool DoHandle(HttpRequest request);

    }
}