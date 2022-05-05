namespace MainsoftTesting.Website.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExamTopic")]
    public partial class ExamTopic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamTopic()
        {
            QuestionHeader = new HashSet<QuestionHeader>();
            UserExamAnswers = new HashSet<UserExamAnswers>();
            UserExamTopic = new HashSet<UserExamTopic>();
        }

        public int id { get; set; }

        [StringLength(200)]
        public string TopicName { get; set; }

        public int? ExamId { get; set; }

        [StringLength(20)]
        public string CereationUser { get; set; }

        public DateTime? CreationDate { get; set; }

        [StringLength(20)]
        public string ModificationUser { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual Exam Exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionHeader> QuestionHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserExamAnswers> UserExamAnswers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserExamTopic> UserExamTopic { get; set; }
    }
}
