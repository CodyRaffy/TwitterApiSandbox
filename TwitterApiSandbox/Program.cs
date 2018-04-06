using System;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace TwitterApiSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Auth.SetUserCredentials(
                Properties.Settings.Default.ConsumerKey,
                Properties.Settings.Default.ConsumerSecret,
                Properties.Settings.Default.AccessToken,
                Properties.Settings.Default.AccessTokenSecret);


            var searchParameter = new SearchTweetsParameters("Trump")
            {
                //GeoCode = new GeoCode(-122.398720, 37.781157, 1, DistanceMeasure.Miles),
                Lang = LanguageFilter.English,
                SearchType = SearchResultType.Recent,
                MaximumNumberOfResults = 15,
                //Until = new DateTime(2015, 06, 02),
                //SinceId = 399616835892781056,
                //MaxId = 405001488843284480,
                //Filters = TweetSearchFilters.Images
            };

            var tweets = Search.SearchTweets(searchParameter);

            foreach (var tweet in tweets)
            {
                Console.WriteLine($"Tweet: {tweet.FullText}");
            }

            Console.ReadLine();
        }
    }
}
