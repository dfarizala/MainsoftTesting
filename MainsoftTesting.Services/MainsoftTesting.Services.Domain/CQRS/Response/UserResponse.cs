using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainsoftTesting.Services.Domain.CQRS.Response
{
    public class AddUserResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
    }
}
