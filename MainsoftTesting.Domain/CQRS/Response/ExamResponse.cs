using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainsoftTesting.Domain.Models;

namespace MainsoftTesting.Domain.Models.CQRS.Response
{
    public class GetExamsResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
        public List<ExamListModel> Exams { get; set; }

    }
}
