using System.ComponentModel.DataAnnotations;

namespace Entities;

public class Course
{
    public int CourseId { get; set; }

    [Required] [StringLength(100)] public string Name { get; set; }

    public string Description { get; set; }

    public ICollection<Teacher> Teachers { get; set; }

    public ICollection<Student> Students { get; set; }

    public ICollection<Exam> Exams { get; set; }
}