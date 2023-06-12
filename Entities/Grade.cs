using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

public class Grade
{
    public int GradeId { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }

    public int ExamId { get; set; }
    public Exam Exam { get; set; }

    [Range(0, 100)] public decimal Score { get; set; }
}