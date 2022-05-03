using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainsoftTesting.Services.Domain.Entities;

namespace MainsoftTesting.Services.Domain.CQRS.Response
{
    public class GetExamsResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
        public List<ExamList> Exams { get; set; }

    }

    public class AssignExamResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }

    }

    public class GetAssignedExamsResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
        public List<AssignedExamList> Assignment { get; set; }

    }

}
