using System;
using System.Collections.Generic;

namespace MainsoftTesting.Services.Persistence.Models
{
    public partial class ExamTopic
    {
        public ExamTopic()
        {
            QuestionHeaders = new HashSet<QuestionHeader>();
            UserExamAnswers = new HashSet<UserExamAnswer>();
            UserExamTopics = new HashSet<UserExamTopic>();
        }

        public int Id { get; set; }
        public string? TopicName { get; set; }
        public string? CereationUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModificationUser { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual ICollection<QuestionHeader> QuestionHeaders { get; set; }
        public virtual ICollection<UserExamAnswer> UserExamAnswers { get; set; }
        public virtual ICollection<UserExamTopic> UserExamTopics { get; set; }
    }
}
