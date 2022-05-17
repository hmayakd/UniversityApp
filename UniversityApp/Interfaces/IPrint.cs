using System;
using UniversityApp.Models;

namespace UniversityApp.Interfaces
{
    public interface IPrint
    {
        void Print(Person person);
        void Print(Person[] persons);
    }
}
