using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class SchoolManagementDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Exam> Exams { get; set; }
    public DbSet<Grade> Grades { get; set; }

    public SchoolManagementDbContext(DbContextOptions<SchoolManagementDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // seed Students table
        modelBuilder.Entity<Student>().HasData(
            new Student
            {
                StudentId = 1, FirstName = "John", StudentNumber = 123456, LastName = "Doe",
                Email = "john@doe.com"
            },
            new Student
            {
                StudentId = 2, FirstName = "Jane", StudentNumber = 123457, LastName = "Doe",
                Email = "jane@doe.com"
            },
            new Student
            {
                StudentId = 3, FirstName = "Jack", StudentNumber = 123458, LastName = "Doe",
                Email = "jack@doe.com"
            }
        );
        modelBuilder.Entity<Student>().HasIndex(student => student.StudentNumber).IsUnique();

        // seed Teachers table
        modelBuilder.Entity<Teacher>().HasData(
            new Teacher
            {
                TeacherId = 1, FirstName = "John", LastName = "Smith", Email = "smith@edu.com"
            },
            new Teacher
            {
                TeacherId = 2, FirstName = "Jane", LastName = "Smith", Email = "smith@edu.com"
            },
            new Teacher
            {
                TeacherId = 3, FirstName = "Jack", LastName = "Smith", Email = "smith@edu.com"
            }
        );

        // seed Courses table
        modelBuilder.Entity<Course>().HasData(
            new Course
            {
                CourseId = 1, Name = "Mathematics", Description = "Mathematics course"
            },
            new Course
            {
                CourseId = 2, Name = "Physics", Description = "Physics course"
            },
            new Course
            {
                CourseId = 3, Name = "Chemistry", Description = "Chemistry course"
            }
        );

        // seed Exams table
        modelBuilder.Entity<Exam>().HasData(
            new Exam
            {
                ExamId = 1, Title = "Mathematics Exam 1",
                CourseId = 1, ExamDate = new DateTime(2023, 7, 1)
            },
            new Exam
            {
                ExamId = 2, Title = "Mathematics Exam 2",
                CourseId = 1, ExamDate = new DateTime(2023, 7, 2)
            },
            new Exam
            {
                ExamId = 3, Title = "Physics Exam 1", CourseId = 2,
                ExamDate = new DateTime(2023, 7, 5)
            },
            new Exam
            {
                ExamId = 4, Title = "Physics Exam 2", CourseId = 2,
                ExamDate = new DateTime(2023, 7, 2)
            },
            new Exam
            {
                ExamId = 5, Title = "Chemistry Exam 1", CourseId = 3,
                ExamDate = new DateTime(2023, 7, 9)
            }
        );

        // seed Grades table
        modelBuilder.Entity<Grade>().HasData(
            new Grade
            {
                GradeId = 1, StudentId = 1, ExamId = 1, Score = 50
            },
            new Grade
            {
                GradeId = 2, StudentId = 1, ExamId = 2, Score = 45
            },
            new Grade
            {
                GradeId = 3, StudentId = 1, ExamId = 3, Score = 30
            },
            new Grade
            {
                GradeId = 4, StudentId = 1, ExamId = 4, Score = 80
            },
            new Grade
            {
                GradeId = 5, StudentId = 1, ExamId = 5, Score = 100
            },
            new Grade
            {
                GradeId = 6, StudentId = 2, ExamId = 1, Score = 50
            },
            new Grade
            {
                GradeId = 7, StudentId = 2, ExamId = 2, Score = 40
            },
            new Grade
            {
                GradeId = 8, StudentId = 2, ExamId = 3, Score = 30
            },
            new Grade
            {
                GradeId = 9, StudentId = 2, ExamId = 4, Score = 20
            },
            new Grade
            {
                GradeId = 10, StudentId = 2, ExamId = 5, Score = 10
            }
        );

        modelBuilder.Entity<Student>().HasIndex(s => s.Email).IsUnique();

        modelBuilder.Entity<Teacher>()
            .HasMany(teacher => teacher.Courses)
            .WithMany(course => course.Teachers);

        modelBuilder.Entity<TeacherCourse>().HasKey(tc => new { tc.TeacherId, tc.CourseId });

        modelBuilder.Entity<TeacherCourse>().HasData(
            new TeacherCourse { TeacherId = 1, CourseId = 1 },
            new TeacherCourse { TeacherId = 2, CourseId = 2 });
    }
}