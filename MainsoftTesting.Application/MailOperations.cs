using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainsoftTesting.Domain.Models;
using MainsoftTesting.Infrastructure.Users;
using MainsoftTesting.Domain.Models.CQRS.Request;
using MainsoftTesting.Domain.Models.CQRS.Response;
using MainsoftTesting.Domain.CQRS.Request;

namespace MainsoftTesting.Application
{
    public class MailOperations
    {
        public static Task<bool> SendMail(MailRequest request)
            => Infrastructure.MailOperations.SendMail(request);

    }
}
