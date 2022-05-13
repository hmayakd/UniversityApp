using System;

namespace UniversityApp.Models
{
    public class Student : BaseModel
    {
        int age;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get => age; set => age = value < 15 ? throw new Exception("Student can not be younger then 15 years old!") : age = value; }
        public Teacher Teacher { get; set; }
        public Group Group { get; set; }
    }
}