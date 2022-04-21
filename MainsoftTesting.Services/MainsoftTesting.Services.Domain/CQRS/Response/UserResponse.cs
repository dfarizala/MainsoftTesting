using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainsoftTesting.Services.Domain.Entities;

namespace MainsoftTesting.Services.Domain.CQRS.Response
{
    public class AddUserResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
    }

    public class ListUsersResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
        public List<User> Users { get; set; }
    }
}
