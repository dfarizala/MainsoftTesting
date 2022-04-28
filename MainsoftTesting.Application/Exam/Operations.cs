using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainsoftTesting.Domain.Models;
using MainsoftTesting.Infrastructure.Users;
using MainsoftTesting.Domain.Models.CQRS.Request;
using MainsoftTesting.Domain.Models.CQRS.Response;

namespace MainsoftTesting.Application.Exam
{
    public class Operations
    {
        public static Task<GetExamsResponse> GetExam()
            => Infrastructure.Exams.Operations.GetExams();

    }
}
