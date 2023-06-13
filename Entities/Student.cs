using System.ComponentModel.DataAnnotations;

namespace Entities;

public class Student
{
    public int StudentId { get; set; }

    public int StudentNumber { get; set; }

    [Required] [StringLength(100)] public string FirstName { get; set; }

    [Required] [StringLength(100)] public string LastName { get; set; }

    public string Email { get; set; }

    public ICollection<Course>? Courses { get; set; }

    public ICollection<Grade> Grades { get; set; }
}