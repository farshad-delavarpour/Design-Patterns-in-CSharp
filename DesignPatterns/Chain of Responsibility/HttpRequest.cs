namespace DesignPatterns.ChainOfResponsibility
{
    public class HttpRequest
    {
        public string Username { get; } = string.Empty;
        public string Password { get; } = string.Empty;

        public HttpRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}