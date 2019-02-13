using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Data.Entities;

namespace SchoolApi.Data.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(RepositoryContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _entities
                .Include(s => s.StudentMajor)
                .ToListAsync();
        }
        
        public async Task<IEnumerable<Student>> GetStudentsByMajorTextAsync(string major)
        {
            return await _entities
                .Include(s => s.StudentMajor)
                .Where(s => s.StudentMajor.MajorText == major)
                .ToListAsync();
        }
    }
}