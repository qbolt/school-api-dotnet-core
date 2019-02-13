using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolApi.Data.Entities;

namespace SchoolApi.Data.Repositories
{
    public interface IStudentRepository : IBaseRespository<Student>
    {
        Task<IEnumerable<Student>> GetStudentsByMajorTextAsync(string major);
    }
}