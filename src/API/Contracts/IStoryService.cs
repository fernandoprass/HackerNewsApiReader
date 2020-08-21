using API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Contracts
{
    /// <summary>The Account service contract</summary>
    public interface IStoryService
    {
        /// <summary>ListBestStories the best stories</summary>
        /// <returns>A list of stories</returns>
        Task<IEnumerable<StoryDto>> ListBestStories();
    }
}
