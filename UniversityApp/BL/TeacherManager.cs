using System;
using UniversityApp.Models;

namespace UniversityApp.BL
{
    public static class TeacherManager
    {
        const short maxAge = 139;
        public static Teacher Create(string firstName, string lastName, int age)
        {
            Teacher teacher = new Teacher()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
            };
            return teacher;
        }
        public static Teacher[] Create(int count, int minAge)
        {
            Teacher[] teachers = new Teacher[count];
            Random rnd = new Random();
            for (int i = 0; i < teachers.Length; i++)
            {
                teachers[i] = new Teacher()
                {
                    FirstName = $"TchFName{i}",
                    LastName = $"TchLName{i}",
                    Age = rnd.Next(minAge, maxAge),
                };
            }
            return teachers;
        }
        public static Teacher CopyValue(Teacher teacher)
        {
            if (teacher != null)
            {
                Teacher teacherCopy = new Teacher()
                {
                    Id = teacher.Id,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    Age = teacher.Age,
                    Group = StudentManager.CopyValue(teacher.Group),
                    Students = StudentManager.CopyValue(teacher.Students),
                };
                return teacherCopy;
            }
            else
                return null;
        }
        public static Teacher[] CopyValue(Teacher[] teachers)
        {
            if (teachers != null)
            {
                Teacher[] teachersCopy = new Teacher[teachers.Length];
                for (int i = 0; i < teachersCopy.Length; i++)
                {
                    teachersCopy[i] = new Teacher()
                    {
                        Id = teachers[i].Id,
                        FirstName = teachers[i].FirstName,
                        LastName = teachers[i].LastName,
                        Age = teachers[i].Age,
                        Group = StudentManager.CopyValue(teachers[i].Group),
                        Students = StudentManager.CopyValue(teachers[i].Students),
                    };
                }
                return teachersCopy;
            }
            else
                return null;
        }
        public static void Print(Teacher teacher)
        {
            Console.WriteLine("**********Teacher**********");
            Console.WriteLine($"id: {teacher.Id} name: {teacher.FirstName} lastName: {teacher.LastName} age: {teacher.Age}");
            Console.WriteLine($"**********{teacher.Id} -Students**********");
            int stdCount = 0;
            if (teacher.Students != null)
                stdCount = teacher.Students.Length;
            else
            {
                Console.WriteLine("-------------------------------------------------------------------");
            }
            for (int i = 0; i < stdCount; i++)
            {
                if (teacher.Students != null)
                    Console.WriteLine($"id: {teacher.Students[i].Id} name: {teacher.Students[i].FirstName} lastName: {teacher.Students[i].LastName} " +
                        $"age:{teacher.Students[i].Age}");
                else
                    Console.WriteLine("-------------------------------------------------------------------");
            }
            Console.WriteLine($"**********{teacher.Id} -Groups**********");
            if (teacher.Group != null)
                Console.WriteLine($"id: {teacher.Group.Id} name: {teacher.Group.Name}");
            else
                Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();
        }
        public static void Print(Teacher[] teachers)
        {
            Console.WriteLine("**********Teachers**********");
            for (int i = 0; i < teachers.Length; i++)
            {
                Console.WriteLine($"id: {teachers[i].Id} name: {teachers[i].FirstName} lastName: {teachers[i].LastName} age: {teachers[i].Age}");
                Console.WriteLine($"**********{teachers[i].Id} -Students**********");
                int stdCount = 0;
                if (teachers[i].Students != null)
                    stdCount = teachers[i].Students.Length;
                else
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                }
                for (int j = 0; j < stdCount; j++)
                {
                    if (teachers[i].Students != null)
                        Console.WriteLine($"id: {teachers[i].Students[j].Id} name: {teachers[i].Students[j].FirstName} lastName: {teachers[i].Students[j].LastName} " +
                            $"age: {teachers[i].Students[j].Age}");
                    else
                        Console.WriteLine("-------------------------------------------------------------------");
                }
                Console.WriteLine($"**********{teachers[i].Id} -Groups**********");
                if (teachers[i].Group != null)
                    Console.WriteLine($"id: {teachers[i].Group.Id} name: {teachers[i].Group.Name}");
                else
                    Console.WriteLine("-------------------------------------------------------------------");
            }
            Console.WriteLine();
        }
    }
}
