using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PracticeUploadImage.Api.Validations
{
    public class ImageValidation
    {
        private const int MaxImageSize = 2;
        public static (bool isValid,string errorMessage) IsValidAvatar(IFormFile file)
        {

            if (file is null)
                return (false, "image can't be null");
            else
            {
                long imgSize = file.Length / 1024 / 1024;

                if (imgSize > MaxImageSize)
                    return (false, $"img must be shorted than {MaxImageSize}");
                else
                    return (false, null);
            }
            
        }
    }
}
