using System;
using UniversityApp.Models;

namespace UniversityApp.BL
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
            Console.WriteLine($"**********{teacher._id} -Students**********");
            int stdCount = 0;
            if (teacher._students != null)
                stdCount = teacher._students.Length;
            else
            {
                Console.WriteLine("-------------------------------------------------------------------");
            }
            for (int i = 0; i < stdCount; i++)
            {
                if (teacher._students != null)
                    Console.WriteLine($"id: {teacher._students[i]._id} name: {teacher._students[i]._firstName} lastName: {teacher._students[i]._lastName} " +
                        $"age:{teacher._students[i]._age}");
                else
                    Console.WriteLine("-------------------------------------------------------------------");
            }
            Console.WriteLine($"**********{teacher._id} -Groups**********");
            int grCount = 0;
            if (teacher._groups != null)
                grCount = teacher._groups.Length;
            else
            {
                Console.WriteLine("-------------------------------------------------------------------");
            }
            for (int i = 0; i < grCount; i++)
            {
                if (teacher._groups != null)
                    Console.WriteLine($"id: {teacher._groups[i]._id} name: {teacher._groups[i]._name}");
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
                Console.WriteLine($"**********{teachers[i]._id} -Students**********");
                int stdCount = 0;
                if (teachers[i]._students != null)
                    stdCount = teachers[i]._students.Length;
                else
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                }
                for (int j = 0; j < stdCount; j++)
                {
                    if (teachers[i]._students != null)
                        Console.WriteLine($"id: {teachers[i]._students[j]._id} name: {teachers[i]._students[j]._firstName} lastName: {teachers[i]._students[j]._lastName} " +
                            $"age: {teachers[i]._students[j]._age}");
                    else
                        Console.WriteLine("-------------------------------------------------------------------");
                }
                Console.WriteLine($"**********{teachers[i]._id} -Groups**********");
                int grCount = 0;
                if (teachers[i]._groups != null)
                    grCount = teachers[i]._groups.Length;
                else
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                }
                for (int j = 0; j < grCount; j++)
                {
                    if (teachers[i]._groups != null)
                        Console.WriteLine($"id: {teachers[i]._groups[j]._id} name: {teachers[i]._groups[j]._name}");
                    else
                        Console.WriteLine("-------------------------------------------------------------------");
                }
            }
            Console.WriteLine();
        }
    }
}
