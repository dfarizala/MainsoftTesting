using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainsoftTesting.Domain.CQRS.Request
{
    public class AssignExamRequest
    {
        public int idUser { get; set; }
        public int idExam { get; set; }
        public string Recruiter { get; set; }
    }
}
