using API.Contracts;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryController : ControllerBase
    {
        private readonly IStoryService storyService;

        /// <summary> The Story controller constructor </summary>
        /// <param name="storyService">The story service</param>
        public StoryController(IStoryService storyService)
        {
            this.storyService = storyService;
        }

        /// <summary> ListBestStories of the best stories </summary>
        /// <returns>The result of the operation</returns>
        [HttpGet("ListBestStories")]
        public Task<IEnumerable<StoryDto>> ListBestStories()
        {
            var bestStories = storyService.ListBestStories();
            return bestStories;
        }
    }
}
