using MainsoftTesting.Domain.Models;
using MainsoftTesting.Infrastructure.Users;
using MainsoftTesting.Domain.Models.CQRS.Request;
using MainsoftTesting.Domain.Models.CQRS.Response;

namespace MainsoftTesting.Application.User
{
    public class Operations
    {
        public static Task<UserListResponse> GetUserList()
            => Infrastructure.Users.Operations.GetUserList();

        public static Task<UserDetailResponse> GetUserDetails(int id)
            => Infrastructure.Users.Operations.GetUserDetails(id);

        public static Task<UserResponse> CreateNewUser(Domain.Models.CreateUserViewModel objUser)
            => Infrastructure.Users.Operations.CreateNewUser(objUser);

    }
}