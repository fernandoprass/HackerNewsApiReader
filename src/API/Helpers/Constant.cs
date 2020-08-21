using System;
using Microsoft.Extensions.DependencyInjection;

namespace API.Helpers
{
    /// <summary>
    /// The constants system
    /// Note: To save time, I chose to use constant to store system parameter values. This is certainly not  
    /// the best way, it was chosen only because of the time available to solve the problem.  
    /// Improvement suggestion 
    /// (i) Put the configuration on appsettings.json file
    /// (ii) Add a table to store the key and its value. Then you could create a user interface where 
    ///      the system administrator can update these values ​​whenever necessary (best choice)
    /// </summary>
    public static class Constant
    {
        public const int NUMBER_OF_STORIES = 20;
        public const string URL_STORY = @"https://hacker-news.firebaseio.com/v0/item/{0}.json";
        public const string URL_LIST_OF_SPTORY_ID =@"https://hacker-news.firebaseio.com/v0/beststories.json";
    }
}
