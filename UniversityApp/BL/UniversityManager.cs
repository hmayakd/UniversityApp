using System;
using UniversityApp.Models;

namespace UniversityApp.BL
{
    public static class UniversityManager
    {
        public static Student SwapWithTeacher(Student student, Teacher teacher)
        {
            Student swappedStd = new Student();
            swappedStd = StudentManager.CopyValue(student);
            swappedStd.Teacher = TeacherManager.CopyValue(teacher);
            swappedStd.Group = StudentManager.CopyValue(student.Group);
            return swappedStd;
        }
        public static Student SwapWithGroup(Student student, Group group)
        {
            Student swappedStd = new Student();
            swappedStd = StudentManager.CopyValue(student);
            swappedStd.Teacher = TeacherManager.CopyValue(student.Teacher);
            swappedStd.Group = StudentManager.CopyValue(group);
            return swappedStd;
        }
        public static Student[] SwapWithTeacher(Student[] students, Teacher teacher)
        {
            Student[] swappedStds = new Student[students.Length];
            for (int i = 0; i < swappedStds.Length; i++)
            {
                swappedStds[i] = StudentManager.CopyValue(students[i]);
                swappedStds[i].Teacher = TeacherManager.CopyValue(teacher);
                swappedStds[i].Group = StudentManager.CopyValue(students[i].Group);
            }
            return swappedStds;
        }
        public static Student[] SwapWithGroup(Student[] students, Group group)
        {
            Student[] swappedStds = new Student[students.Length];
            for (int i = 0; i < swappedStds.Length; i++)
            {
                swappedStds[i] = StudentManager.CopyValue(students[i]);
                swappedStds[i].Teacher = TeacherManager.CopyValue(students[i].Teacher);
                swappedStds[i].Group = StudentManager.CopyValue(group);
            }
            return swappedStds;
        }
        public static Teacher SwapWithStudents(Teacher teacher, Student[] students)
        {
            Teacher swappedTch = new Teacher();
            swappedTch = TeacherManager.CopyValue(teacher);
            swappedTch.Group = StudentManager.CopyValue(teacher.Group);
            swappedTch.Students = new Student[students.Length];
            for (int i = 0; i < swappedTch.Students.Length; i++)
            {
                swappedTch.Students[i] = StudentManager.CopyValue(students[i]);
            }
            return swappedTch;
        }
        public static Teacher SwapWithGroup(Teacher teacher, Group group)
        {
            Teacher swappedTch = new Teacher();
            swappedTch = TeacherManager.CopyValue(teacher);
            swappedTch.Group = StudentManager.CopyValue(group);
            for (int i = 0; i < teacher.Students.Length; i++)
            {
                swappedTch.Students[i] = StudentManager.CopyValue(teacher.Students[i]);
            }

            return swappedTch;
        }
        public static Teacher[] SwapWithStudents(Teacher[] teachers, Student[] students)
        {
            Teacher[] swappedTchs = new Teacher[teachers.Length];
            int minStCount = students.Length / teachers.Length;
            for (int i = 0; i < teachers.Length - 1; i++)
            {
                swappedTchs[i] = TeacherManager.CopyValue(teachers[i]);
                swappedTchs[i].Group = StudentManager.CopyValue(teachers[i].Group);
                swappedTchs[i].Students = new Student[minStCount];
                for (int j = 0; j < minStCount; j++)
                {
                    swappedTchs[i].Students[j] = StudentManager.CopyValue(students[i * minStCount + j]);
                }
            }
            int lastStCount = minStCount * (teachers.Length - 1);
            swappedTchs[teachers.Length - 1] = TeacherManager.CopyValue(teachers[lastStCount]);
            swappedTchs[teachers.Length - 1].Group = StudentManager.CopyValue(teachers[lastStCount].Group);
            swappedTchs[teachers.Length - 1].Students = new Student[students.Length - lastStCount];
            int counter = 0;
            for (int i = lastStCount; i < students.Length; i++)
            {
                swappedTchs[teachers.Length - 1].Students[counter++] = StudentManager.CopyValue(students[i]);
            }
            return swappedTchs;
        }
        public static Teacher[] SwapWithGroups(Teacher[] teachers, Group group)
        {
            Teacher[] swappedTchs = new Teacher[teachers.Length];
            
            for (int i = 0; i < swappedTchs.Length; i++)
            {
                swappedTchs[i] = TeacherManager.CopyValue(teachers[i]);
                swappedTchs[i].Group = StudentManager.CopyValue(group);
                for (int j = 0; j < teachers[i].Students.Length; j++)
                {
                    swappedTchs[i].Students[j] = StudentManager.CopyValue(teachers[i].Students[j]);
                }
            }
            return swappedTchs;
        }
    }
}
