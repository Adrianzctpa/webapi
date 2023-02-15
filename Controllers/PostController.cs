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

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetPostResponseDTO>>> UpdatePost(UpdatePostResponseDTO updPost) {
            var resp = await _postService.updatePost(updPost);

            if (resp.Data is null) {
                return NotFound(resp);
            } 

            return Ok(resp);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetPostResponseDTO>>>> DeletePost(int id) {
            var resp = await _postService.deletePost(id);

            if (resp.Data is null) {
                return NotFound(resp);
            } 

            return Ok(resp);
        }
    }
}
