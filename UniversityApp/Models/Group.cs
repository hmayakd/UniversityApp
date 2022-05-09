using System;
using UniversityApp.Models;

namespace UniversityApp.Models
{
    public class Group
    {
        public Group()
        {

        }
        public Group(string name)
        {
            _id = Guid.NewGuid();
            _name = name;
        }
        public Guid _id;
        public string _name;
        public Student[] _students;
        public Teacher[] _teachers;
    }
}
