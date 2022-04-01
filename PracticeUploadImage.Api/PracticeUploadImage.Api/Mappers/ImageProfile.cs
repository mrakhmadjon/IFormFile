using AutoMapper;
using PracticeUploadImage.Api.Models;

namespace PracticeUploadImage.Api.Mappers
{
    public class ImageProfile : Profile
    {
        public ImageProfile()
        {
            CreateMap<UserDto,User>().ReverseMap();
        }
    }
}
