using System;
using System.Collections.Generic;

namespace MainsoftTesting.Services.Persistence.Models
{
    public partial class QuestionOption
    {
        public QuestionOption()
        {
            UserExamAnswers = new HashSet<UserExamAnswer>();
        }

        public int Id { get; set; }
        public int? QuestionHeaderId { get; set; }
        public string? OptionText { get; set; }
        public int? IsCorrect { get; set; }
        public string? CreationUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModificationUser { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual QuestionHeader? QuestionHeader { get; set; }
        public virtual ICollection<UserExamAnswer> UserExamAnswers { get; set; }
    }
}
