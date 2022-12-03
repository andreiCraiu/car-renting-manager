using Cms.ViewModel.User;
using Cms.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web.Http;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Cms.WebApi.Controllers
{
    [RoutePrefix("api/vm/users")]
    public class UserController : ControllerBase
    {
        [Route("")]
        [HttpPost]
        public IActionResult Authenticate(UserVm user)
        {
            return Ok();
        }

        [Route("register")]
        [HttpPost]
        public IActionResult RegisterUser(UserVm user)
        {
            return Ok();
        }


    }
}