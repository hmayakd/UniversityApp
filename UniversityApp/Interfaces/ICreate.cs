﻿using System;
using UniversityApp.Models;

namespace UniversityApp.Interfaces
{
    public interface ICreate
    {
        const short maxAge = 139;
        Person Create(string firstName, string lastName, int age);
        Person[] Create(int count, int minAge);
    }
}
