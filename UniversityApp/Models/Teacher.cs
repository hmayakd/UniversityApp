using System;

namespace UniversityApp.Models
{
    public class Teacher : BaseModel
    {
        int age;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get => age; set => age = value < 25 ? throw new Exception("Teacher can not be younger then 25 years old!") : age = value; }
        public Student[] Students { get; set; }
        public Group Group { get; set; }
    }
}
