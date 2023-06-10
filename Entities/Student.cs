using System.ComponentModel.DataAnnotations;

namespace Entities;

public class Student
{
    public int StudentId { get; set; }

    public int StudentNumber { get; set; }

    [Required] [StringLength(100)] public string FirstName { get; set; }

    [Required] [StringLength(100)] public string LastName { get; set; }

    public string Email { get; set; }

    // Assuming a student can be enrolled in multiple courses
    public ICollection<Course> Courses { get; set; }

    // If you are grading exams, you may want to keep a list of exam grades for each student
    // public ICollection<ExamGrade> ExamGrades { get; set; }
}