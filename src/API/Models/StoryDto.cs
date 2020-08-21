using System;

namespace API.Models
{
    /// <summary> The story data transfer object </summary>
    public class StoryDto
    {
        /// <summary>The title of the story, poll or job.HTML. </summary>
        public string title { get; set; }

        /// <summary> The URI of the story. </summary>
        public Uri uri { get; set; }

        /// <summary> The username of the item's author. </summary>
        public string postedBy { get; set; }

        /// <summary>  Creation date of the item, in DateTime. </summary>
        public DateTime time { get; set; }

        /// <summary> The story's score, or the votes for a pollopt.</summary>
        public int score { get; set; }

        /// <summary> The number of comments.</summary>
        public int commentCount { get; set; }
    }

}
