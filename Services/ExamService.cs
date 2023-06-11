using Entities;
using Repositories;
using ServiceContracts.Services;

namespace Services;

public class ExamService : CrudService<Exam>, IExamService
{
    public ExamService(Repository<Exam> examRepository) : base(examRepository)
    {
    }
}