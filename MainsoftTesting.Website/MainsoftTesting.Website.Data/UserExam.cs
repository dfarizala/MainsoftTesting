namespace MainsoftTesting.Website.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserExam")]
    public partial class UserExam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserExam()
        {
            UserExamAnswers = new HashSet<UserExamAnswers>();
            UserExamTopic = new HashSet<UserExamTopic>();
        }

        public int id { get; set; }

        public int? ExamId { get; set; }

        public int? UserId { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? Finish { get; set; }

        public int? TotalTime { get; set; }

        public int? ExamPercentage { get; set; }

        [StringLength(20)]
        public string CreationUser { get; set; }

        public DateTime? CreationDate { get; set; }

        [StringLength(20)]
        public string ModificationUser { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserExamAnswers> UserExamAnswers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserExamTopic> UserExamTopic { get; set; }
    }
}
