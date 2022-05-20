using System;
using System.Collections.Generic;
using UniversityApp.Interfaces;
using UniversityApp.Models;

namespace UniversityApp.BL
{
    public class TeacherManager : ICreate, IPrint
    {
        const short maxAge = 139;
        public Person Create(string firstName, string lastName, int age)
        {
            Teacher teacher = new Teacher()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
            };
            return teacher;
        }
        public List<Person> Create(int count, int minAge)
        {
            List<Person> persons = new List<Person>(count);
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                persons.Add((Person)new Teacher()
                {
                    FirstName = $"TchFName{i}",
                    LastName = $"TchLName{i}",
                    Age = rnd.Next(minAge, maxAge),
                });
            }
            return persons;
        }
        public Teacher CopyValue(Teacher teacher)
        {
            StudentManager studentManager = new StudentManager();
            if (teacher != null)
            {
                Teacher teacherCopy = new Teacher()
                {
                    Id = teacher.Id,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    Age = teacher.Age,
                    Group = studentManager.CopyValue(teacher.Group),
                    Students = studentManager.CopyValue(teacher.Students),
                };
                return teacherCopy;
            }
            else
                return null;
        }
        public List<Teacher> CopyValue(List<Teacher> teachers)
        {
            StudentManager studentManager = new StudentManager();
            if (teachers != null)
            {
                List<Teacher> teachersCopy = new List<Teacher>(teachers.Count);
                for (int i = 0; i < teachersCopy.Count; i++)
                {
                    teachersCopy[i] = new Teacher()
                    {
                        Id = teachers[i].Id,
                        FirstName = teachers[i].FirstName,
                        LastName = teachers[i].LastName,
                        Age = teachers[i].Age,
                        Group = studentManager.CopyValue(teachers[i].Group),
                        Students = studentManager.CopyValue(teachers[i].Students),
                    };
                }
                return teachersCopy;
            }
            else
                return null;
        }
        public List<Teacher> PersonToTch(List<Person> persons)
        {
            if (persons != null)
            {
                List<Teacher> teachers = new List<Teacher>(persons.Count);
                for (int i = 0; i < persons.Count; i++)
                    teachers.Add((Teacher)persons[i]);
                return teachers;
            }
            else
                return null;
        }
        public List<Person> TeacherToPrs(List<Teacher> teachers)
        {
            if (teachers != null)
            {
                List<Person> persons = new List<Person>(teachers.Count);
                for (int i = 0; i < teachers.Count; i++)
                    persons.Add((Person)teachers[i]);
                return persons;
            }
            else
                return null;
        }
        public void Print(Person person)
        {
            Teacher teacher = new Teacher();
            teacher = (Teacher)person;
            Console.WriteLine("**********Teacher**********");
            Console.WriteLine($"id: {teacher.Id} name: {teacher.FirstName} lastName: {teacher.LastName} age: {teacher.Age}");
            Console.WriteLine($"**********{teacher.Id} -Students**********");
            int stdCount = 0;
            if (teacher.Students != null)
                stdCount = teacher.Students.Count;
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
        public void Print(List<Person> persons)
        {
            List<Teacher> teachers = new List<Teacher>(persons.Count);
            Console.WriteLine("**********Teachers**********");
            for (int i = 0; i < persons.Count; i++)
            {
                teachers.Add((Teacher)persons[i]);
                Console.WriteLine($"id: {teachers[i].Id} name: {teachers[i].FirstName} lastName: {teachers[i].LastName} age: {teachers[i].Age}");
                Console.WriteLine($"**********{teachers[i].Id} -Students**********");
                int stdCount = 0;
                if (teachers[i].Students != null)
                    stdCount = teachers[i].Students.Count;
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
