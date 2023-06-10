using System.ComponentModel.DataAnnotations;

namespace Entities;

public class Teacher
{
    public int TeacherId { get; set; }

    [Required] [StringLength(100)] public string FirstName { get; set; }

    [Required] [StringLength(100)] public string LastName { get; set; }

    public string Email { get; set; }

    // A teacher can teach multiple courses
    public ICollection<Course> Courses { get; set; }
}