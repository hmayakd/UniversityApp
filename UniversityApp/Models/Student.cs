using System;
using UniversityApp.Models;

namespace UniversityApp.Models
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
        public Group _group;
    }
}