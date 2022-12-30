namespace DesignPatterns.Facade
{
    public class OAuth
    {
        public String requestToken(String appKey, String appSecret)
        {
            System.Console.WriteLine("Get a request token");
            return "requestToken";
        }

        public String getAccessToken(String requestToken)
        {
            System.Console.WriteLine("Get an access token");
            return "accessToken";
        }
    }
}