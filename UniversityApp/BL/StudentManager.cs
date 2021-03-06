using System;
using System.Collections.Generic;
using UniversityApp.Interfaces;
using UniversityApp.Models;

namespace UniversityApp.BL
{
    public class StudentManager : ICreate, IPrint
    {
        const short maxAge = 139;
        public Person Create(string firstName, string lastName, int age)
        {
            Student student = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
            };
            return student;
        }
        public List<Person> Create(int count, int minAge)
        {
            List<Person> persons = new List<Person>(count);
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                persons.Add((Person)new Student()
                {
                    FirstName = $"StFName{i}",
                    LastName = $"StLName{i}",
                    Age = rnd.Next(minAge, maxAge),
                });
            }
            return persons;
        }
        public Student CopyValue(Student student)
        {
            if (student != null)
            {
                Student studentCopy = new Student()
                {
                    Id = student.Id,
                    LastName = student.LastName,
                    FirstName = student.FirstName,
                    Age = student.Age,
                    Group = CopyValue(student.Group),
                };
                return studentCopy;
            }
            else
                return null;
        }
        public Group CopyValue(Group group)
        {
            if (group != null)
            {
                Group groupCopy = new Group()
                {
                    Id = group.Id,
                    Name = group.Name,
                };
                return groupCopy;
            }
            else return null;
        }
        public List<Student> CopyValue(List<Student> students)
        {
            if (students != null)
            {
                List<Student> studentsCopy = new List<Student>(students.Count);
                for (int i = 0; i < studentsCopy.Count; i++)
                {
                    studentsCopy[i] = new Student()
                    {
                        Id = students[i].Id,
                        LastName = students[i].LastName,
                        FirstName = students[i].FirstName,
                        Age = students[i].Age,
                        Group = CopyValue(students[i].Group),
                    };
                }
                return studentsCopy;
            }
            else
                return null;
        }
        public List<Student> PersonToStd(List<Person> persons)
        {
            if (persons != null)
            {
                List<Student> students = new List<Student>(persons.Count);
                for (int i = 0; i < persons.Count; i++)
                    students.Add((Student)persons[i]);
                return students;
            }
            else
                return null;
        }
        public List<Person> StudentsToPrs(List<Student> students)
        {
            if (students != null)
            {
                List<Person> persons = new List<Person>(students.Count);
                for (int i = 0; i < students.Count; i++)
                    persons.Add((Person)students[i]);
                return persons;
            }
            else
                return null;
        }
        public void Print(Person person)
        {
            Student student = new Student();
            student = (Student)person;
            Console.WriteLine("**********Student**********");
            Console.WriteLine($"id: {student.Id} name: {student.FirstName} lastName: {student.LastName} age: {student.Age}");
            Console.WriteLine($"**********{student.Id} -Teacher**********");
            if (student.Teacher != null)
                Console.WriteLine($"id: {student.Teacher.Id} name: {student.Teacher.FirstName} lastName: {student.Teacher.LastName} age: {student.Teacher.Age}");
            else
                Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"**********{student.Id} -Group**********");
            if (student.Group != null)
                Console.WriteLine($"id: {student.Group.Id} name: {student.Group.Name}");
            else
                Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();
        }
        public void Print(List<Person> persons)
        {
            List<Student> students = new List<Student>(persons.Count);
            for (int i = 0; i < persons.Count; i++)
            {
                students.Add((Student)persons[i]);
            };
            Console.WriteLine("**********Students**********");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"id: {students[i].Id} name: {students[i].FirstName} lastName: {students[i].LastName} age: {students[i].Age}");
                Console.WriteLine($"**********{students[i].Id} -Teacher**********");
                if (students[i].Teacher != null)
                    Console.WriteLine($"id: {students[i].Teacher.Id} name: {students[i].Teacher.FirstName} lastName: {students[i].Teacher.LastName} " +
                        $"age: {students[i].Teacher.Age}");
                else
                    Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine($"**********{students[i].Id} -Group**********");
                if (students[i].Group != null)
                    Console.WriteLine($"id: {students[i].Group.Id} name: {students[i].Group.Name}");
                else
                    Console.WriteLine("-------------------------------------------------------------------");
            }
            Console.WriteLine();
        }
    }
}
