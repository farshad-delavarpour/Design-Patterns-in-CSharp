namespace DesignPatterns.Facade
{
    public class TwitterAPI
    {
        private string _appKey;
        private string _secretKey;

        public TwitterAPI(string appKey, string secretKey)
        {
            _appKey = appKey;
            _secretKey = secretKey;
        }

        public List<Tweet> GetRecentTweets()
        {
            var twitterClient = new TwitterClient();
            return twitterClient.getRecentTweets(GetAccessToken());
        }

        private string GetAccessToken()
        {
            var oauth = new OAuth();
            var requestToken = oauth.requestToken(_appKey, _secretKey);
            return oauth.getAccessToken(requestToken);
        }

    }
}