using System;

namespace UniversityApp.Models
{
    public class Teacher : Person
    {        
        public Student[] Students { get; set; }
        public Group Group { get; set; }
    }
}
