namespace SchoolApi.Data.Entities
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public Major StudentMajor { get; set; }
        public int Age { get; set; }
        public int Gpa { get; set; }
    }
}