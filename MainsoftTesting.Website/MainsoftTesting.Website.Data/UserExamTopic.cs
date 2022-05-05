namespace MainsoftTesting.Website.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserExamTopic")]
    public partial class UserExamTopic
    {
        public int id { get; set; }

        public int? UserId { get; set; }

        public int? UserExamId { get; set; }

        public int? TopicId { get; set; }

        public int? TopicPercentage { get; set; }

        [StringLength(20)]
        public string CreationUser { get; set; }

        public DateTime? CreationDate { get; set; }

        [StringLength(20)]
        public string ModificationUser { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual ExamTopic ExamTopic { get; set; }

        public virtual UserExam UserExam { get; set; }

        public virtual Users Users { get; set; }
    }
}
