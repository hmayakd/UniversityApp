using System;
using UniversityApp.Models;

namespace UniversityApp.BL
{
    public static class GroupManager
    {
        public static Group Create(string name)
            => new Group(name);        
        public static Group[] Create(int lenght)
        {
            Group[] groups = new Group[lenght];
            for (int i = 0; i < groups.Length; i++)
            {
                groups[i] = new Group($"gName{i}");
            }
            return groups;
        }
        public static void Print(Group group)
        {
            Console.WriteLine("**********Group**********");
            Console.WriteLine($"id: {group._id} name: {group._name}");
            Console.WriteLine($"**********{group._id} -Teachers**********");
            int tchCount = 0;
            if (group._teachers != null)
                tchCount = group._teachers.Length;
            else
            {
                Console.WriteLine("-------------------------------------------------------------------");
            }
            for (int i = 0; i < tchCount; i++)
            {
                if (group._teachers != null)
                    Console.WriteLine($"id: {group._teachers[i]._id} name: {group._teachers[i]._firstName} lastName: {group._teachers[i]._lastName} age: {group._teachers[i]._age}");
                else
                    Console.WriteLine("-------------------------------------------------------------------");
            }
            Console.WriteLine($"**********{group._id} -Students**********");
            int stdCount = 0;
            if (group._students != null)
                stdCount = group._students.Length;
            else
            {
                Console.WriteLine("-------------------------------------------------------------------");
            }
            for (int i = 0; i < stdCount; i++)
            {
                if (group._students != null)
                    Console.WriteLine($"id: {group._students[i]._id} name: {group._students[i]._firstName} lastName: {group._students[i]._lastName} " +
                        $"age:{group._students[i]._age}");
                else
                    Console.WriteLine("-------------------------------------------------------------------");
            }
            Console.WriteLine();
        }
        public static void Print(Group[] groups)
        {
            Console.WriteLine("**********Groups**********");
            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"id: {groups[i]._id} name: {groups[i]._name}");
                Console.WriteLine($"**********{groups[i]._id} -Teachers**********");
                int tchCount = 0;
                if (groups[i]._teachers != null)
                    tchCount = groups[i]._teachers.Length;
                else
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                }
                for (int j = 0; j < tchCount; j++)
                {
                    if (groups[i]._teachers != null)
                        Console.WriteLine($"id: {groups[i]._teachers[j]._id} name: {groups[i]._teachers[j]._firstName} lastName: {groups[i]._teachers[j]._lastName} " +
                            $"age: {groups[i]._teachers[j]._age}");
                    else
                        Console.WriteLine("-------------------------------------------------------------------");
                }
                Console.WriteLine($"**********{groups[i]._id} -Students**********");
                int stdCount = 0;
                if (groups[i]._students != null)
                    stdCount = groups[i]._students.Length;
                else
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                }
                for (int j = 0; j < stdCount; j++)
                {
                    if (groups[i]._students != null)
                        Console.WriteLine($"id: {groups[i]._students[j]._id} name: {groups[i]._students[j]._firstName} lastName: {groups[i]._students[j]._lastName} " +
                            $"age:{groups[i]._students[j]._age}");
                    else
                        Console.WriteLine("-------------------------------------------------------------------");
                }
            }
            Console.WriteLine();
        }
    }
}
