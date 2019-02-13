using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolApi.Data.Entities;
using SchoolApi.Data.Repositories;

namespace SchoolApi.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        
        public Task<Student> GetById(int id)
        {
            return _studentRepository.GetByIdAsync(id);
        }

        public Task<IEnumerable<Student>> GetAll()
        {
            return _studentRepository.GetAllAsync();
        }

        public Task<IEnumerable<Student>> GetStudentsByMajor(string majorText)
        {
            return _studentRepository.GetStudentsByMajorTextAsync(majorText);
        }
    }
}