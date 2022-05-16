using System;
using UniversityApp.Models;

namespace UniversityApp.Interfaces
{
    public interface ICreate
    {
        public Person Create(string firstName, string lastName, int age)
        {
            Person person = new Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
            };
            return person;
        }
    }
}
