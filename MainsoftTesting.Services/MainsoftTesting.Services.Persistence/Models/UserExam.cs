using System;
using System.Collections.Generic;

namespace MainsoftTesting.Services.Persistence.Models
{
    public partial class UserExam
    {
        public UserExam()
        {
            UserExamAnswers = new HashSet<UserExamAnswer>();
            UserExamTopics = new HashSet<UserExamTopic>();
        }

        public int Id { get; set; }
        public int? ExamId { get; set; }
        public int? UserId { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }
        public int? TotalTime { get; set; }
        public int? ExamPercentage { get; set; }
        public string? CreationUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModificationUser { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual Exam? Exam { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<UserExamAnswer> UserExamAnswers { get; set; }
        public virtual ICollection<UserExamTopic> UserExamTopics { get; set; }
    }
}
