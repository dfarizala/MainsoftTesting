using System;
using System.Collections.Generic;

namespace MainsoftTesting.Services.Persistence.Models
{
    public partial class UserExamAnswer
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? UserExamId { get; set; }
        public int? TechnologyId { get; set; }
        public int? TopicId { get; set; }
        public int? QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public string? CreationUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModificationUser { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual QuestionOption? Answer { get; set; }
        public virtual QuestionHeader? Question { get; set; }
        public virtual ExamTechnology? Technology { get; set; }
        public virtual ExamTopic? Topic { get; set; }
        public virtual User? User { get; set; }
        public virtual UserExam? UserExam { get; set; }
    }
}
