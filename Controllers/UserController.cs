using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

       [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetUserResponseDTO>>> PostUser(AddUserResponseDTO user) {
            return Ok(await _userService.PostUser(user));
        }
    }
}
