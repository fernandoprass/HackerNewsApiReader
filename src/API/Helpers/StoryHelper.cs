using API.Models;
using System;

namespace API.Helpers
{
    /// <summary> The Story class helper </summary>
    public static class StoryHelper
    {
        /// <summary> Convert Story to StoryDto </summary>
        /// <param name="story">The story</param>
        /// <returns></returns>
        public static StoryDto ToDto(this Story story)
        {
            if (story != null)
            {
                var storyDto = new StoryDto
                {
                    title = story.title,
                    uri = !string.IsNullOrEmpty(story.url) ? new Uri(story.url) : null,
                    postedBy = story.by,
                    time = UnixTimeHelper.ToDatetime(story.time),
                    score = story.score,
                    commentCount = story.kids.Length
                };
                return storyDto;
            }

            return null;
        }
    }
}
