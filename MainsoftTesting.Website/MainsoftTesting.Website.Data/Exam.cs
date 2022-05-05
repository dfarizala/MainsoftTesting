namespace MainsoftTesting.Website.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exam")]
    public partial class Exam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exam()
        {
            ExamTopic = new HashSet<ExamTopic>();
            QuestionHeader = new HashSet<QuestionHeader>();
            UserExam = new HashSet<UserExam>();
        }

        public int id { get; set; }

        [StringLength(400)]
        public string ExamName { get; set; }

        public int? EstimatedTime { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        public int? ExamProfile { get; set; }

        public int? ExamTechnology { get; set; }

        public int? NumberOfQuestions { get; set; }

        [StringLength(20)]
        public string CrationUser { get; set; }

        public DateTime? CreationDate { get; set; }

        [StringLength(20)]
        public string ModificationUser { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual ExamProfiles ExamProfiles { get; set; }

        public virtual ExamTechnology ExamTechnology1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamTopic> ExamTopic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionHeader> QuestionHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserExam> UserExam { get; set; }
    }
}
