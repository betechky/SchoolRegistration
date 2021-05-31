using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SchoolRegistrationSystem.Models
{
    public partial class SchoolRegistrationContext : DbContext
    {
        public SchoolRegistrationContext()
        {
        }

        public SchoolRegistrationContext(DbContextOptions<SchoolRegistrationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Instructor> Instructor { get; set; }
        public virtual DbSet<RegType> RegType { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<StudentCourses> StudentCourses { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SchoolRegistration;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasKey(e => e.CourseId)
                    .HasName("PK__Courses__C92D71873BBC97DD");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Instructor)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Instructo__Cours__412EB0B6");
            });

            modelBuilder.Entity<RegType>(entity =>
            {
                entity.HasKey(e => e.StudentType)
                    .HasName("PK__RegType__45EDBF3AF0D9BE4B");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Registrat__Cours__5441852A");

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.InstructorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Registrat__Instr__5535A963");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Registrat__Stude__534D60F1");

                entity.HasOne(d => d.StudentTypeNavigation)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.StudentType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Registrat__Stude__52593CB8");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK__Students__32C52A798A675ACA");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Students__Course__403A8C7D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
