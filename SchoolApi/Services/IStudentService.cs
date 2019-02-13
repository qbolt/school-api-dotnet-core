using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolApi.Data.Entities;

namespace SchoolApi.Services
{
    public interface IStudentService
    {
        Task<Student> GetById(int id);
        Task<IEnumerable<Student>> GetAll();
        Task<IEnumerable<Student>> GetStudentsByMajor(string majorText);
    }
}