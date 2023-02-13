using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }


        [HttpGet]
        public ActionResult<List<Post>> Get() {
            return Ok(_postService.getPosts());
        }

        [HttpGet("{id}")]
        public ActionResult<Post> GetSinglePost(int id) {
            return Ok(_postService.getPostById(id));
        }
    }
}
