using System;
using System.Collections.Generic;

namespace MainsoftTesting.Services.Persistence.Models
{
    public partial class ExamTechnology
    {
        public ExamTechnology()
        {
            Exams = new HashSet<Exam>();
            UserExamAnswers = new HashSet<UserExamAnswer>();
        }

        public int Id { get; set; }
        public string? TechnologyName { get; set; }
        public string? CreationUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModificationUser { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<UserExamAnswer> UserExamAnswers { get; set; }
    }
}
