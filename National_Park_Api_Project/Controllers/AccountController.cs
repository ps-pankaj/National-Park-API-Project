using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using National_Park_Api_Project.Models;
using National_Park_Api_Project.Repository.IRepository;

namespace National_Park_Api_Project.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost("register")]
        public IActionResult Register([FromBody]User user)
        {
            if(ModelState.IsValid)
            {
                var isUniqueUser = _userRepository.IsUniqueUser(user.UserName);
                if (!isUniqueUser) return BadRequest("User in use !!!");
                var userInfo = _userRepository.Register(user.UserName,user.Password);
                if (userInfo == null) return BadRequest();
            }
            return Ok();
        }
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]UserVM userVM)
        {
            var user = _userRepository.Authenticate(userVM.UserName, userVM.Password);
            if (user == null) return BadRequest("Wrong user / pwd");
            return Ok(user);

        }
        
    }
}
