using Microsoft.EntityFrameworkCore;
using SchoolApi.Data.Entities;

namespace SchoolApi.Data
{
    public class RepositoryContext : DbContext
    {
        private DbSet<Student> Students { get; set; }
        private DbSet<Major> Majors { get; set; }
        
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options) 
        { }
    }
}