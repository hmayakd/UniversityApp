using System;

namespace UniversityApp.Models
{
    public class Student : Person
    {
        public Teacher Teacher { get; set; }
        public Group Group { get; set; }
    }
}