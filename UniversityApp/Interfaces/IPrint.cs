using System;
using System.Collections.Generic;
using UniversityApp.Models;

namespace UniversityApp.Interfaces
{
    public interface IPrint
    {
        void Print(Person person);
        void Print(List<Person> persons);
    }
}
