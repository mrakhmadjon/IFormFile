using Microsoft.AspNetCore.Http;

namespace PracticeUploadImage.Api.Models
{
    public class UserDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IFormFile Image { get; set; }
    }
}
