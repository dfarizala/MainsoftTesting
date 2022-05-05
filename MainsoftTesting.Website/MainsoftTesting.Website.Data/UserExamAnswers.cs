namespace MainsoftTesting.Website.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserExamAnswers
    {
        public int id { get; set; }

        public int? UserId { get; set; }

        public int? UserExamId { get; set; }

        public int? TechnologyId { get; set; }

        public int? TopicId { get; set; }

        public int? QuestionId { get; set; }

        public int? AnswerId { get; set; }

        [StringLength(20)]
        public string CreationUser { get; set; }

        public DateTime? CreationDate { get; set; }

        [StringLength(20)]
        public string ModificationUser { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual ExamTechnology ExamTechnology { get; set; }

        public virtual ExamTopic ExamTopic { get; set; }

        public virtual QuestionHeader QuestionHeader { get; set; }

        public virtual QuestionOptions QuestionOptions { get; set; }

        public virtual UserExam UserExam { get; set; }

        public virtual Users Users { get; set; }
    }
}
