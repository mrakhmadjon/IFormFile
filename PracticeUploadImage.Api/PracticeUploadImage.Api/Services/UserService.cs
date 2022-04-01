using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PracticeUploadImage.Api.Contexts;
using PracticeUploadImage.Api.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PracticeUploadImage.Api.Services
{
    public class UserService
    {
        private readonly IMapper mapper;
        private UserDbContext userDb;
        private DbSet<User> Users;
        private IWebHostingEnvironment env;

        public UserService(IMapper mapper,UserDbContext userDb)
        {
            this.mapper = mapper;
            this.userDb = userDb;
            this.Users = userDb.Set<User>();
        }
        public Task<User> CreateAsync (UserDto user)
        {
            var mapstudent = mapper.Map<User>(user);





        }

        public async Task<string> SaveFileAsync(Stream file, string fileName)
        {
            fileName = Guid.NewGuid().ToString("N") + "_" + fileName;
            string storagePath = config.GetSection("Storage:ImageUrl").Value;
            string filePath = Path.Combine(env.WebRootPath, $"{storagePath}/{fileName}");
            FileStream mainFile = File.Create(filePath);
            await file.CopyToAsync(mainFile);
            mainFile.Close();

            return fileName;
        }
    }
}
