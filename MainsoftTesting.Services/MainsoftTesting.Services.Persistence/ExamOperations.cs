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

        public static bool AssignExam(int idUser, int idExam, string Recruiter)
        {

            DateTime _ActualDate = System.DateTime.Now;

            using (TestingContext _Context = new TestingContext())
            {
                var _Exam = _Context.Exams.FirstOrDefault(x => x.Id == idExam);
                var _User = _Context.Users.FirstOrDefault(x => x.Id == idUser);
                var _Topics = (from topic in _Context.ExamTopics
                               where topic.ExamId == _Exam.Id
                               select new ExamTopic
                               { Id = topic.Id,
                                 TopicName = topic.TopicName,
                                 ExamId = topic.ExamId }                               
                               ).OrderByDescending(x => x.Id).ToList();

                UserExam _ExamAssignation = new UserExam();

                var _obj = new UserExam();

                _obj.ExamId = _Exam.Id;
                _obj.UserId = _User.Id;
                _obj.ExamPercentage = 0;
                _obj.CreationDate = _ActualDate;
                _obj.ModificationDate = _ActualDate;
                _obj.CreationUser = Recruiter;
                _obj.ModificationUser = Recruiter;

                _Context.Add(_obj);
                _Context.SaveChanges();

                var _NewId = _Context.UserExams.Max(x => x.Id);

                foreach (ExamTopic _Top in _Topics)
                {
                    var _NewTopic = new UserExamTopic();

                    _NewTopic.TopicId = _Top.Id;
                    _NewTopic.UserExamId = _NewId;
                    _NewTopic.UserId = _User.Id;
                    _NewTopic.TopicPercentage = 0;
                    _NewTopic.CreationDate = _ActualDate;
                    _NewTopic.ModificationDate = _ActualDate;
                    _NewTopic.CreationUser = Recruiter;
                    _NewTopic.ModificationUser = Recruiter;

                    _Context.Add(_NewTopic);
                    _Context.SaveChanges();
                }
                return true;
            }
        }
    }
}
