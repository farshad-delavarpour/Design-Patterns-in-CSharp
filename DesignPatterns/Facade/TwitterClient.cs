namespace DesignPatterns.Facade
{
    public class TwitterClient
    {
        public List<Tweet> getRecentTweets(String accessToken)
        {
            System.Console.WriteLine("Getting recent tweets");

            return new List<Tweet>();
        }
    }
}