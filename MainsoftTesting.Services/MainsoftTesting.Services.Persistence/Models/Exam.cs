using System;
using System.Collections.Generic;

namespace MainsoftTesting.Services.Persistence.Models
{
    public partial class Exam
    {
        public Exam()
        {
            ExamTopics = new HashSet<ExamTopic>();
            QuestionHeaders = new HashSet<QuestionHeader>();
            UserExams = new HashSet<UserExam>();
        }

        public int Id { get; set; }
        public string? ExamName { get; set; }
        public int? EstimatedTime { get; set; }
        public string? Status { get; set; }
        public int? ExamProfile { get; set; }
        public int? ExamTechnology { get; set; }
        public int? NumberOfQuestions { get; set; }
        public string? CrationUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModificationUser { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual ExamProfile? ExamProfileNavigation { get; set; }
        public virtual ExamTechnology? ExamTechnologyNavigation { get; set; }
        public virtual ICollection<ExamTopic> ExamTopics { get; set; }
        public virtual ICollection<QuestionHeader> QuestionHeaders { get; set; }
        public virtual ICollection<UserExam> UserExams { get; set; }
    }
}
