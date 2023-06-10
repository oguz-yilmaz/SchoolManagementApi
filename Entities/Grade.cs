using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

public class Grade
{
    public int GradeId { get; set; }

    // Assuming each grade is associated with a specific student
    public int StudentId { get; set; }
    public Student Student { get; set; }

    // Assuming each grade is associated with a specific exam
    public int ExamId { get; set; }
    public Exam Exam { get; set; }

    [Range(0, 100)] public decimal Score { get; set; }
}