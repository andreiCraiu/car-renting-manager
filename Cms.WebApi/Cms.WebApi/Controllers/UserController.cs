using Cms.Interface.Service;
using Cms.Model;
using Cms.ViewModel.User;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cms.WebApi.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("")]
        [HttpPost]
        public IActionResult Authenticate([FromBody] UserVm user)
        {
            var userModel = new UserModel();
            userModel.Email = user.Email;
            userModel.UserName = user.Email;
            userModel.PasswordHash = user.Password;
            userModel.SecurityStamp = Guid.NewGuid().ToString();
            _userService.SaveUser(userModel);
            return Ok(userModel);
        }

        [Route("register")]
        [HttpPost]
        public IActionResult RegisterUser([FromBody] UserVm user)
        {
            var userModel = new UserModel();
            userModel.Email = user.Email;
            userModel.PasswordHash = user.Password;
            userModel.SecurityStamp = Guid.NewGuid().ToString();
            _userService.SaveUser(userModel);
            return Ok(userModel);
        }


    }
}