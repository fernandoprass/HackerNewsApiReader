using API.Contracts;
using API.Helpers;
using API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace API.Implementation
{
    /// <summary> The Story Service class </summary>
    public class StoryService : IStoryService
    {
        /// <summary>Although HttpClient is a disposable class, it is used in this way to avoid TCP port exhausting</summary>
        private readonly HttpClient httpClient = new HttpClient();

        #region PrivateMethods
        /// <summary> Get the list of story Ids </summary>
        /// <returns></returns>
        private async Task<int[]> GetListOfStoryIds()
        {
            int[] list = null;
            {
                var uri = new Uri(Constant.URL_LIST_OF_SPTORY_ID);
                using (var response = await httpClient.GetAsync(uri))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<int[]>(apiResponse);
                }
            }
            return list;
        }

        /// <summary> Get the details of the stories </summary>
        /// <param name="listOfStoryId">ListBestStories of story Ids</param>
        /// <returns></returns>
        private async Task<IEnumerable<Story>> GetDetails(int[] listOfStoryId)
        {
            var stories = new List<Story>();

            if (listOfStoryId.Any())
            {
                foreach (var id in listOfStoryId.Take(Constant.NUMBER_OF_STORIES))
                {
                    var url = new Uri(string.Format(Constant.URL_STORY, id));
                    using (var response = await httpClient.GetAsync(url))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var story = JsonConvert.DeserializeObject<Story>(apiResponse);
                        stories.Add(story);
                    }
                }
            }

            return stories;
        }

        /// <summary> Convert Story to StoryDto </summary>
        /// <param name="stories">The story</param>
        /// <returns></returns>
        private async Task<IEnumerable<StoryDto>> StoryToStoryDto(IEnumerable<Story> stories)
        {
            var storyDtos = new List<StoryDto>();
            if (stories != null && stories.Any())
            {
                storyDtos.AddRange(stories.Select(story => story.ToDto()));
            }

            return storyDtos;
        }
        #endregion

        #region PublicMethods

        /// <inheritdoc />
        public async Task<IEnumerable<StoryDto>> ListBestStories()
        {
            var listOfStoryIds = await GetListOfStoryIds();
            var storiesDetails = await GetDetails(listOfStoryIds);
            var listStoryDto = StoryToStoryDto(storiesDetails);
            return await listStoryDto;
        }
        #endregion
    }
}
