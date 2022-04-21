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

        public virtual DbSet<User> Users { get; set; } = null!;

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

                entity.Property(e => e.LasName)
                    .HasMaxLength(200)
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
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
