namespace Entities;

public class CourseTeacher
{
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }

    public int CourseId { get; set; }
    public Course Course { get; set; }
}