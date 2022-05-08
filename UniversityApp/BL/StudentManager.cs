using System;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp.BL
{
    public static class StudentManager
    {
        const short maxAge = 139;
        public static Student Create(string firstName, string lastName, int age)
            => new Student(firstName, lastName, age);
        public static Student[] Create(int count, int minAge)
        {
            Student[] students = new Student[count];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student($"stName{i}", $"stSurName{i}", rnd.Next(minAge, maxAge));
            }
            return students;
        }
        public static void Print(Student student)
        {
            Console.WriteLine("**********Student**********");
            Console.WriteLine($"id: {student._id} name: {student._firstName} lastName: {student._lastName} age: {student._age}");
            Console.WriteLine($"**********{student._id} -Teacher**********");
            if (student._teacher != null)
                Console.WriteLine($"id: {student._teacher._id} name: {student._teacher._firstName} lastName: {student._teacher._lastName} age: {student._teacher._age}");
            else
                Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();
        }
        public static void Print(Student[] students)
        {
            Console.WriteLine("**********Students**********");
            for (int i = 0; i < students.Length; i++)
            {                
                Console.WriteLine($"id: {students[i]._id} name: {students[i]._firstName} lastName: {students[i]._lastName} age: {students[i]._age}");
                Console.WriteLine($"**********{students[i]._id} -Teacher**********");
                if (students[i]._teacher != null)
                    Console.WriteLine($"id: {students[i]._teacher._id} name: {students[i]._teacher._firstName} lastName: {students[i]._teacher._lastName} age: {students[i]._teacher._age}");
                else
                    Console.WriteLine("-------------------------------------------------------------------");
            }
            Console.WriteLine();
        }
    }
}
