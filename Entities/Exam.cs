using System;
using System.ComponentModel.DataAnnotations;

namespace Entities;

public class Exam
{
    public int ExamId { get; set; }

    [Required]
    public string Title { get; set; }

    public DateTime ExamDate { get; set; }

    // Assuming each exam is associated with a specific course
    public int CourseId { get; set; }
    public Course Course { get; set; }

    // If an exam has multiple questions, you might want to represent that
    // public ICollection<Question> Questions { get; set; }

    // If you're storing exam grades, you might want a navigation property to those
    // public ICollection<ExamGrade> ExamGrades { get; set; }
}
