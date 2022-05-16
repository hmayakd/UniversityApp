using System;
using UniversityApp.Models;

namespace UniversityApp.BL
{
    public class BaseManager
    {
        const short maxAge = 139;
        public virtual Person Create(string firstName, string lastName, int age)
        {
            return null;
        }
        public virtual Person[] Create(int count, int minAge)
        {
            return null;
        }
    }
}
