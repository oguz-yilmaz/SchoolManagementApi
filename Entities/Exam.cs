using System;
using System.ComponentModel.DataAnnotations;

namespace Entities;

public class Exam
{
    public int ExamId { get; set; }

    [Required] public string Title { get; set; }

    public DateTime ExamDate { get; set; }

    public int CourseId { get; set; }
    public Course? Course { get; set; }
}