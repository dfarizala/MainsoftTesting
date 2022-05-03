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

namespace MainsoftTesting.Application.Exam
{
    public class Operations
    {
        public static Task<GetExamsResponse> GetExam()
            => Infrastructure.Exams.Operations.GetExams();

        public static Task<GetAssignedExamsResponse> GetAssignedExam()
            => Infrastructure.Exams.Operations.GetAssignedExams();

        public static Task<AssignExamResponse> AssignExam(AssignExamRequest request)
            => Infrastructure.Exams.Operations.AssignExam(request);

    }
}
