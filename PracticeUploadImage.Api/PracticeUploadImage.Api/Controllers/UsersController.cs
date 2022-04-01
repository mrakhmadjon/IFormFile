using Microsoft.AspNetCore.Mvc;
using PracticeUploadImage.Api.Models;

namespace PracticeUploadImage.Api.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class UsersController
    {
        [HttpPost]
        public ActionResult<User> CreateUser([FromForm] UserDto user)
        {
        }
    }
}
