using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MainsoftTesting.Website.Data
{
    public partial class Testing : DbContext
    {
        public Testing()
            : base("name=Testing")
        {
        }

        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<ExamProfiles> ExamProfiles { get; set; }
        public virtual DbSet<ExamTechnology> ExamTechnology { get; set; }
        public virtual DbSet<ExamTopic> ExamTopic { get; set; }
        public virtual DbSet<QuestionHeader> QuestionHeader { get; set; }
        public virtual DbSet<QuestionOptions> QuestionOptions { get; set; }
        public virtual DbSet<Recruiter> Recruiter { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UserExam> UserExam { get; set; }
        public virtual DbSet<UserExamAnswers> UserExamAnswers { get; set; }
        public virtual DbSet<UserExamTopic> UserExamTopic { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>()
                .Property(e => e.ExamName)
                .IsUnicode(false);

            modelBuilder.Entity<Exam>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Exam>()
                .Property(e => e.CrationUser)
                .IsUnicode(false);

            modelBuilder.Entity<Exam>()
                .Property(e => e.ModificationUser)
                .IsUnicode(false);

            modelBuilder.Entity<ExamProfiles>()
                .Property(e => e.ProfileName)
                .IsUnicode(false);

            modelBuilder.Entity<ExamProfiles>()
                .Property(e => e.CreationUser)
                .IsUnicode(false);

            modelBuilder.Entity<ExamProfiles>()
                .Property(e => e.ModificationUser)
                .IsUnicode(false);

            modelBuilder.Entity<ExamProfiles>()
                .HasMany(e => e.Exam)
                .WithOptional(e => e.ExamProfiles)
                .HasForeignKey(e => e.ExamProfile);

            modelBuilder.Entity<ExamTechnology>()
                .Property(e => e.TechnologyName)
                .IsUnicode(false);

            modelBuilder.Entity<ExamTechnology>()
                .Property(e => e.CreationUser)
                .IsUnicode(false);

            modelBuilder.Entity<ExamTechnology>()
                .Property(e => e.ModificationUser)
                .IsUnicode(false);

            modelBuilder.Entity<ExamTechnology>()
                .HasMany(e => e.Exam)
                .WithOptional(e => e.ExamTechnology1)
                .HasForeignKey(e => e.ExamTechnology);

            modelBuilder.Entity<ExamTechnology>()
                .HasMany(e => e.UserExamAnswers)
                .WithOptional(e => e.ExamTechnology)
                .HasForeignKey(e => e.TechnologyId);

            modelBuilder.Entity<ExamTopic>()
                .Property(e => e.TopicName)
                .IsUnicode(false);

            modelBuilder.Entity<ExamTopic>()
                .Property(e => e.CereationUser)
                .IsUnicode(false);

            modelBuilder.Entity<ExamTopic>()
                .Property(e => e.ModificationUser)
                .IsUnicode(false);

            modelBuilder.Entity<ExamTopic>()
                .HasMany(e => e.QuestionHeader)
                .WithOptional(e => e.ExamTopic)
                .HasForeignKey(e => e.QuestionTopic);

            modelBuilder.Entity<ExamTopic>()
                .HasMany(e => e.UserExamAnswers)
                .WithOptional(e => e.ExamTopic)
                .HasForeignKey(e => e.TopicId);

            modelBuilder.Entity<ExamTopic>()
                .HasMany(e => e.UserExamTopic)
                .WithOptional(e => e.ExamTopic)
                .HasForeignKey(e => e.TopicId);

            modelBuilder.Entity<QuestionHeader>()
                .Property(e => e.QuestionText)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionHeader>()
                .Property(e => e.QuestionImage)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionHeader>()
                .Property(e => e.CreationUser)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionHeader>()
                .Property(e => e.ModificationUser)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionHeader>()
                .HasMany(e => e.UserExamAnswers)
                .WithOptional(e => e.QuestionHeader)
                .HasForeignKey(e => e.QuestionId);

            modelBuilder.Entity<QuestionOptions>()
                .Property(e => e.OptionText)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionOptions>()
                .Property(e => e.CreationUser)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionOptions>()
                .Property(e => e.ModificationUser)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionOptions>()
                .HasMany(e => e.UserExamAnswers)
                .WithOptional(e => e.QuestionOptions)
                .HasForeignKey(e => e.AnswerId);

            modelBuilder.Entity<Recruiter>()
                .Property(e => e.RecruiterName)
                .IsUnicode(false);

            modelBuilder.Entity<Recruiter>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Recruiter>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Recruiter>()
                .Property(e => e.CreationUser)
                .IsUnicode(false);

            modelBuilder.Entity<Recruiter>()
                .Property(e => e.ModificationUser)
                .IsUnicode(false);

            modelBuilder.Entity<UserExam>()
                .Property(e => e.CreationUser)
                .IsUnicode(false);

            modelBuilder.Entity<UserExam>()
                .Property(e => e.ModificationUser)
                .IsUnicode(false);

            modelBuilder.Entity<UserExamAnswers>()
                .Property(e => e.CreationUser)
                .IsUnicode(false);

            modelBuilder.Entity<UserExamAnswers>()
                .Property(e => e.ModificationUser)
                .IsUnicode(false);

            modelBuilder.Entity<UserExamTopic>()
                .Property(e => e.CreationUser)
                .IsUnicode(false);

            modelBuilder.Entity<UserExamTopic>()
                .Property(e => e.ModificationUser)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.MaritalStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.DocType)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.DocNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Age)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.BirthCity)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.JobSituation)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.LastJobCompany)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.LastJobName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.LastJobReasson)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.AcademicLevel)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.AcademicInstitution)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.DegreeFinalization)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.DegreeTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.UserExam)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.UserExamAnswers)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.UserExamTopic)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);
        }
    }
}
