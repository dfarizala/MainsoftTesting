using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainsoftTesting.Services.Domain.Entities;
using MainsoftTesting.Services.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace MainsoftTesting.Services.Persistence
{
    public class ExamOperations
    {
        public static List<ExamList> GetExams()
        {

            using (TestingContext context = new TestingContext())
            {
                var _List = (from exam in context.Exams
                             join e in context.ExamTechnologies on exam.ExamTechnology equals e.Id
                             join x in context.ExamProfiles on exam.ExamProfile equals x.Id
                             select new ExamList() 
                             {
                                 Id = exam.Id,
                                 ExamName = exam.ExamName,
                                 EstimatedTime = (exam.EstimatedTime / 60),
                                 Status = exam.Status,
                                 ExamProfile = x.ProfileName,
                                 ExamTechnology = e.TechnologyName,
                                 NumberOfQuestions = exam.NumberOfQuestions
                             }).ToList(); ;

                return _List;
                                       
            }

        }
    }
}
