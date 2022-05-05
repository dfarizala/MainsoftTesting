namespace MainsoftTesting.Website.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuestionHeader")]
    public partial class QuestionHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuestionHeader()
        {
            QuestionOptions = new HashSet<QuestionOptions>();
            UserExamAnswers = new HashSet<UserExamAnswers>();
        }

        public int id { get; set; }

        public int? ExamId { get; set; }

        public int? QuestionType { get; set; }

        public int? QuestionTopic { get; set; }

        [StringLength(1000)]
        public string QuestionText { get; set; }

        [StringLength(500)]
        public string QuestionImage { get; set; }

        [StringLength(20)]
        public string CreationUser { get; set; }

        public DateTime? CreationDate { get; set; }

        [StringLength(20)]
        public string ModificationUser { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual ExamTopic ExamTopic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionOptions> QuestionOptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserExamAnswers> UserExamAnswers { get; set; }
    }
}
