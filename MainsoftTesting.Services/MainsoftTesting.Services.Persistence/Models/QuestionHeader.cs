using System;
using System.Collections.Generic;

namespace MainsoftTesting.Services.Persistence.Models
{
    public partial class QuestionHeader
    {
        public QuestionHeader()
        {
            QuestionOptions = new HashSet<QuestionOption>();
            UserExamAnswers = new HashSet<UserExamAnswer>();
        }

        public int Id { get; set; }
        public int? ExamId { get; set; }
        public int? QuestionType { get; set; }
        public int? QuestionTopic { get; set; }
        public string? QuestionText { get; set; }
        public string? QuestionImage { get; set; }
        public string? CreationUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModificationUser { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual Exam? Exam { get; set; }
        public virtual ExamTopic? QuestionTopicNavigation { get; set; }
        public virtual ICollection<QuestionOption> QuestionOptions { get; set; }
        public virtual ICollection<UserExamAnswer> UserExamAnswers { get; set; }
    }
}
