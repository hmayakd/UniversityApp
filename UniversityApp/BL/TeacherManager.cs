using System;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp.BL
{
    public static class TeacherManager
    {
        const short maxAge = 139;
        public static Teacher Create(string firstName, string lastName, int age)
            => new Teacher(firstName, lastName, age);
        public static Teacher[] Create(int count, int minAge)
        {
            Teacher[] teachers = new Teacher[count];
            Random rnd = new Random();
            for (int i = 0; i < teachers.Length; i++)
            {
                teachers[i] = new Teacher($"tcName{i}", $"tcSurName{i}", rnd.Next(minAge, maxAge));
            }
            return teachers;
        }
        public static void Print(Teacher teacher)
        {
            Console.WriteLine("**********Teacher**********");
            Console.WriteLine($"id: {teacher._id} name: {teacher._firstName} lastName: {teacher._lastName} age: {teacher._age}");
            int stdCount = 0;
            if (teacher._students != null)
                stdCount = teacher._students.Length;
            else
            {
                Console.WriteLine($"**********{teacher._id} -Student**********");
                Console.WriteLine("-------------------------------------------------------------------");
            }
            for (int i = 0; i < stdCount; i++)
            {
                Console.WriteLine($"**********{teacher._id} -Student**********");
                if (teacher._students != null)
                    Console.WriteLine($"id: {teacher._students[i]._id} name: {teacher._students[i]._firstName} lastName: {teacher._students[i]._lastName} " +
                        $"age:{teacher._students[i]._age}");
                else
                    Console.WriteLine("-------------------------------------------------------------------");
            }
            Console.WriteLine();
        }
        public static void Print(Teacher[] teachers)
        {
            Console.WriteLine("**********Teachers**********");
            for (int i = 0; i < teachers.Length; i++)
            {                
                Console.WriteLine($"id: {teachers[i]._id} name: {teachers[i]._firstName} lastName: {teachers[i]._lastName} age: {teachers[i]._age}");
                int stdCount = 0;
                if (teachers[i]._students != null)
                    stdCount = teachers[i]._students.Length;
                else
                {
                    Console.WriteLine($"**********{teachers[i]._id} -Student**********");
                    Console.WriteLine("-------------------------------------------------------------------");
                }
                for (int j = 0; j < stdCount; j++)
                {
                    Console.WriteLine($"**********{teachers[i]._id} -Student**********");
                    if (teachers[i]._students != null)
                        Console.WriteLine($"id: {teachers[i]._students[j]._id} name: {teachers[i]._students[j]._firstName} lastName: {teachers[i]._students[j]._lastName} " +
                            $"age: {teachers[i]._students[j]._age}");
                    else
                        Console.WriteLine("-------------------------------------------------------------------");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
