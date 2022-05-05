namespace MainsoftTesting.Website.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            UserExam = new HashSet<UserExam>();
            UserExamAnswers = new HashSet<UserExamAnswers>();
            UserExamTopic = new HashSet<UserExamTopic>();
        }

        public int id { get; set; }

        public int? RecruiterId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string CellPhone { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Gender { get; set; }

        [StringLength(20)]
        public string MaritalStatus { get; set; }

        [StringLength(10)]
        public string DocType { get; set; }

        [StringLength(20)]
        public string DocNumber { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Nationality { get; set; }

        [StringLength(10)]
        public string Age { get; set; }

        [StringLength(200)]
        public string BirthCity { get; set; }

        [StringLength(20)]
        public string JobSituation { get; set; }

        [StringLength(200)]
        public string LastJobCompany { get; set; }

        [StringLength(200)]
        public string LastJobName { get; set; }

        [StringLength(500)]
        public string LastJobReasson { get; set; }

        [StringLength(20)]
        public string AcademicLevel { get; set; }

        [StringLength(200)]
        public string AcademicInstitution { get; set; }

        [StringLength(20)]
        public string DegreeFinalization { get; set; }

        [StringLength(200)]
        public string DegreeTitle { get; set; }

        public virtual Recruiter Recruiter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserExam> UserExam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserExamAnswers> UserExamAnswers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserExamTopic> UserExamTopic { get; set; }
    }
}
