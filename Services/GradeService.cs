using Entities;
using Repositories;
using ServiceContracts.Services;

namespace Services;

public class GradeService : CrudService<Grade>, IGradeService
{
    public GradeService(Repository<Grade> gradeRepository) : base(gradeRepository)
    {
    }
}