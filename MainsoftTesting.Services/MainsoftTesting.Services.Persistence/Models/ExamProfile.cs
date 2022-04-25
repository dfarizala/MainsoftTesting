using System;
using System.Collections.Generic;

namespace MainsoftTesting.Services.Persistence.Models
{
    public partial class ExamProfile
    {
        public ExamProfile()
        {
            Exams = new HashSet<Exam>();
        }

        public int Id { get; set; }
        public string? ProfileName { get; set; }
        public string? CreationUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModificationUser { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
    }
}
