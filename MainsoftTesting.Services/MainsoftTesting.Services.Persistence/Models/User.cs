using System;
using System.Collections.Generic;

namespace MainsoftTesting.Services.Persistence.Models
{
    public partial class User
    {
        public User()
        {
            UserExamAnswers = new HashSet<UserExamAnswer>();
            UserExamTopics = new HashSet<UserExamTopic>();
            UserExams = new HashSet<UserExam>();
        }

        public int Id { get; set; }
        public int? RecruiterId { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? CellPhone { get; set; }
        public string? Phone { get; set; }
        public string? Gender { get; set; }
        public string? MaritalStatus { get; set; }
        public string? DocType { get; set; }
        public string? DocNumber { get; set; }
        public string? Address { get; set; }
        public string? Nationality { get; set; }
        public string? Age { get; set; }
        public string? BirthCity { get; set; }
        public string? JobSituation { get; set; }
        public string? LastJobCompany { get; set; }
        public string? LastJobName { get; set; }
        public string? LastJobReasson { get; set; }
        public string? AcademicLevel { get; set; }
        public string? AcademicInstitution { get; set; }
        public string? DegreeFinalization { get; set; }
        public string? DegreeTitle { get; set; }

        public virtual Recruiter? Recruiter { get; set; }
        public virtual ICollection<UserExamAnswer> UserExamAnswers { get; set; }
        public virtual ICollection<UserExamTopic> UserExamTopics { get; set; }
        public virtual ICollection<UserExam> UserExams { get; set; }
    }
}
