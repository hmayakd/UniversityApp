using System;
using System.Collections.Generic;

namespace UniversityApp.Models
{
    public class Teacher : Person
    {
        public List<Student> Students { get; set; }
        public Group Group { get; set; }
    }
}
