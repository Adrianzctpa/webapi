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
        public async Task<ActionResult<ServiceResponse<GetPostResponseDTO>>> GetPost() {
            return Ok(await _postService.getPosts());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetPostResponseDTO>>> GetSinglePost(int id) {
            return Ok(await _postService.getPostById(id));
        }
    }
}
