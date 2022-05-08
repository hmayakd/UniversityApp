using System;
using UniversityApp.Models;

namespace UniversityConsoleApp.Models
{
    public class Teacher : ModelBase
    {
        public Teacher() : base()
        {

        }
        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }
        public Student[] _students;
    }
}
