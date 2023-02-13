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
        public ActionResult<User> PostUser(User user) {
            return Ok(_userService.PostUser(user));
        }
    }
}
