using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MainsoftTesting.Services.Persistence.Models
{
    public partial class TestingContext : DbContext
    {
        public TestingContext()
        {
        }

        public TestingContext(DbContextOptions<TestingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Exam> Exams { get; set; } = null!;
        public virtual DbSet<ExamProfile> ExamProfiles { get; set; } = null!;
        public virtual DbSet<ExamTechnology> ExamTechnologies { get; set; } = null!;
        public virtual DbSet<ExamTopic> ExamTopics { get; set; } = null!;
        public virtual DbSet<QuestionHeader> QuestionHeaders { get; set; } = null!;
        public virtual DbSet<QuestionOption> QuestionOptions { get; set; } = null!;
        public virtual DbSet<Recruiter> Recruiters { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserExam> UserExams { get; set; } = null!;
        public virtual DbSet<UserExamAnswer> UserExamAnswers { get; set; } = null!;
        public virtual DbSet<UserExamTopic> UserExamTopics { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:mainsoft-db-server.database.windows.net,1433;Initial Catalog=testing_db;Persist Security Info=False;User ID=testingadmin;Password=Testing2022*$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>(entity =>
            {
                entity.ToTable("Exam");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CrationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ExamName)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ExamProfileNavigation)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.ExamProfile)
                    .HasConstraintName("FK_Exam_ExamProfiles");

                entity.HasOne(d => d.ExamTechnologyNavigation)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.ExamTechnology)
                    .HasConstraintName("FK_Exam_ExamTechnology");
            });

            modelBuilder.Entity<ExamProfile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExamTechnology>(entity =>
            {
                entity.ToTable("ExamTechnology");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TechnologyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExamTopic>(entity =>
            {
                entity.ToTable("ExamTopic");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CereationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TopicName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuestionHeader>(entity =>
            {
                entity.ToTable("QuestionHeader");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionImage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.QuestionHeaders)
                    .HasForeignKey(d => d.ExamId)
                    .HasConstraintName("FK_QuestionHeader_Exam");

                entity.HasOne(d => d.QuestionTopicNavigation)
                    .WithMany(p => p.QuestionHeaders)
                    .HasForeignKey(d => d.QuestionTopic)
                    .HasConstraintName("FK_QuestionHeader_ExamTopic");
            });

            modelBuilder.Entity<QuestionOption>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OptionText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.QuestionHeader)
                    .WithMany(p => p.QuestionOptions)
                    .HasForeignKey(d => d.QuestionHeaderId)
                    .HasConstraintName("FK_QuestionOptions_QuestionHeader");
            });

            modelBuilder.Entity<Recruiter>(entity =>
            {
                entity.ToTable("Recruiter");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RecruiterName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcademicInstitution)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AcademicLevel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Age)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BirthCity)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CellPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DegreeFinalization)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DegreeTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobSituation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastJobCompany)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastJobName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastJobReasson)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Recruiter)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RecruiterId)
                    .HasConstraintName("FK_Users_Recruiter");
            });

            modelBuilder.Entity<UserExam>(entity =>
            {
                entity.ToTable("UserExam");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.UserExams)
                    .HasForeignKey(d => d.ExamId)
                    .HasConstraintName("FK_UserExam_Exam");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserExams)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserExam_Users");
            });

            modelBuilder.Entity<UserExamAnswer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.UserExamAnswers)
                    .HasForeignKey(d => d.AnswerId)
                    .HasConstraintName("FK_UserExamAnswers_QuestionOptions");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.UserExamAnswers)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_UserExamAnswers_QuestionHeader");

                entity.HasOne(d => d.Technology)
                    .WithMany(p => p.UserExamAnswers)
                    .HasForeignKey(d => d.TechnologyId)
                    .HasConstraintName("FK_UserExamAnswers_ExamTechnology");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.UserExamAnswers)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_UserExamAnswers_ExamTopic");

                entity.HasOne(d => d.UserExam)
                    .WithMany(p => p.UserExamAnswers)
                    .HasForeignKey(d => d.UserExamId)
                    .HasConstraintName("FK_UserExamAnswers_UserExam");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserExamAnswers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserExamAnswers_Users");
            });

            modelBuilder.Entity<UserExamTopic>(entity =>
            {
                entity.ToTable("UserExamTopic");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.UserExamTopics)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_UserExamTopic_ExamTopic");

                entity.HasOne(d => d.UserExam)
                    .WithMany(p => p.UserExamTopics)
                    .HasForeignKey(d => d.UserExamId)
                    .HasConstraintName("FK_UserExamTopic_UserExam");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserExamTopics)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserExamTopic_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
