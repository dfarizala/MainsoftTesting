using Microsoft.AspNetCore.Mvc;
using MainsoftTesting.Services.Domain.CQRS.Request;
using MainsoftTesting.Services.Domain.CQRS.Response;
using MainsoftTesting.Services.Domain.Entities;
using MainsoftTesting.Services.Application;
using AutoMapper;

namespace MainsoftTesting.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("AddUser")]
        public AddUserResponse AddUser(AddUserRequest request)
        {
            Mapper.CreateMap<AddUserRequest, MainsoftTesting.Services.Domain.Entities.User>();
            var obj = Mapper.Map<MainsoftTesting.Services.Domain.Entities.User>(request);
            return UserApplication.AddUser(obj);
        }

        [HttpGet(Name ="ListUsers")]
        public ListUsersResponse ListUsers()
        {
            return UserApplication.ListUsers();
        }

        [HttpPost]
        [Route("UserDetail")]
        public UserDetailResponse UserDetail(UserDetailRequest request)
        {
            return UserApplication.UserDetail(request.Id);
        }

    }
}
