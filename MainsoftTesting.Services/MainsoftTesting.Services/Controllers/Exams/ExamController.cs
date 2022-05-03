using Microsoft.AspNetCore.Http;
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

    public class ExamController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public ExamController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetExams")]
        public GetExamsResponse GetExams()
        {
            return ExamApplication.GetExams();
        }

        [HttpPost]
        [Route("AssignExam")]
        public AssignExamResponse AssignExam(AssignExamRequest request)
        {
            return ExamApplication.AssignExam(request);
        }

    }
}
