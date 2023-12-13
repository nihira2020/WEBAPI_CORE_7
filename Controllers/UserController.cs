using LearnAPI.Modal;
using LearnAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService service) {
            this.userService = service;
        }

        [HttpPost("userregisteration")]
        public async Task<IActionResult> UserRegisteration(UserRegister userRegister)
        {
            var data= await this.userService.UserRegisteration(userRegister);
            return Ok(data);
        }

        [HttpPost("confirmregisteration")]
        public async Task<IActionResult> confirmregisteration(int userid,string username,string otptext)
        {
            var data = await this.userService.ConfirmRegister(userid,username,otptext);
            return Ok(data);
        }

        [HttpPost("resetpassword")]
        public async Task<IActionResult> resetpassword(string username, string oldpassword,string newpassword)
        {
            var data = await this.userService.ResetPassword(username, oldpassword,newpassword);
            return Ok(data);
        }

        [HttpPost("forgetpassword")]
        public async Task<IActionResult> forgetpassword(string username)
        {
            var data = await this.userService.ForgetPassword(username);
            return Ok(data);
        }

        [HttpPost("updatepassword")]
        public async Task<IActionResult> updatepassword(string username,string password,string otptext)
        {
            var data = await this.userService.UpdatePassword(username,password,otptext);
            return Ok(data);
        }

        [HttpPost("updatestatus")]
        public async Task<IActionResult> updatestatus(string username, bool status)
        {
            var data = await this.userService.UpdateStatus(username, status);
            return Ok(data);
        }

        [HttpPost("updaterole")]
        public async Task<IActionResult> updaterole(string username, string role)
        {
            var data = await this.userService.UpdateRole(username, role);
            return Ok(data);
        }
    }
}
