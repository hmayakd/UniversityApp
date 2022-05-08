using System;
using UniversityApp.Models;

namespace UniversityConsoleApp.Models
{
    public class Student : ModelBase
    {
        public Student() : base()
        {

        }
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }
        public Teacher _teacher;
    }
}
