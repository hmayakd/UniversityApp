using System;
using UniversityApp.Interfaces;
using UniversityApp.Models;

namespace UniversityApp.BL
{
    public class StudentManager : BaseManager
    {
        const short maxAge = 139;
        public override Person Create(string firstName, string lastName, int age)
        {
            Student student = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
            };
            return student;
        }
        public override Person[] Create(int count, int minAge)
        {
            Student[] students = new Student[count];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student()
                {
                    FirstName = $"StFName{i}",
                    LastName = $"StLName{i}",
                    Age = rnd.Next(minAge, maxAge),
                };
            }
            return students;
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
        public Student[] CopyValue(Student[] students)
        {
            if (students != null)
            {
                Student[] studentsCopy = new Student[students.Length];
                for (int i = 0; i < studentsCopy.Length; i++)
                {
                    Student studentCopy = new Student()
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
        public void Print(Student student)
        {
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
        public void Print(Student[] students)
        {
            Console.WriteLine("**********Students**********");
            for (int i = 0; i < students.Length; i++)
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
