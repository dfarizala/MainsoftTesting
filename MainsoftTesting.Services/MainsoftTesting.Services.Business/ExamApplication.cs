using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainsoftTesting.Services.Domain.Entities;
using MainsoftTesting.Services.Persistence;
using MainsoftTesting.Services.Domain.CQRS.Response;

namespace MainsoftTesting.Services.Application
{
    public class ExamApplication
    {
        public static GetExamsResponse GetExams()
        {
            GetExamsResponse _Response = new GetExamsResponse();

            try
            {
                List<ExamList> _list = ExamOperations.GetExams();

                if (_list != null)
                {
                    _Response.Error = "OK";
                    _Response.Message = "Success";
                    _Response.Success = true;
                    _Response.Exams = _list;
                }
                else
                {
                    throw new Exception("No records found");
                }
                return _Response;
            }
            catch (Exception ex)
            {
                _Response.Error = "FAIL";
                _Response.Message = ex.Message;
                _Response.Success = false;
                _Response.Exams = null;

                return _Response;
            }
        }
    }
}
