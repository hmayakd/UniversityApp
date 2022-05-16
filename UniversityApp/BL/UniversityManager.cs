using System;
using UniversityApp.Models;

namespace UniversityApp.BL
{
    public static class UniversityManager
    {
        public static Student SwapWithTeacher(Student student, Teacher teacher)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            Student swappedStd = new Student();
            swappedStd = studentManager.CopyValue(student);
            swappedStd.Teacher = teacherManager.CopyValue(teacher);
            swappedStd.Group = studentManager.CopyValue(student.Group);
            return swappedStd;
        }
        public static Student SwapWithGroup(Student student, Group group)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            Student swappedStd = new Student();
            swappedStd = studentManager.CopyValue(student);
            swappedStd.Teacher = teacherManager.CopyValue(student.Teacher);
            swappedStd.Group = studentManager.CopyValue(group);
            return swappedStd;
        }
        public static Student[] SwapWithTeacher(Student[] students, Teacher teacher)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            Student[] swappedStds = new Student[students.Length];
            for (int i = 0; i < swappedStds.Length; i++)
            {
                swappedStds[i] = studentManager.CopyValue(students[i]);
                swappedStds[i].Teacher = teacherManager.CopyValue(teacher);
                swappedStds[i].Group = studentManager.CopyValue(students[i].Group);
            }
            return swappedStds;
        }
        public static Student[] SwapWithGroup(Student[] students, Group group)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            Student[] swappedStds = new Student[students.Length];
            for (int i = 0; i < swappedStds.Length; i++)
            {
                swappedStds[i] = studentManager.CopyValue(students[i]);
                swappedStds[i].Teacher = teacherManager.CopyValue(students[i].Teacher);
                swappedStds[i].Group = studentManager.CopyValue(group);
            }
            return swappedStds;
        }
        public static Teacher SwapWithStudents(Teacher teacher, Student[] students)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            Teacher swappedTch = new Teacher();
            swappedTch = teacherManager.CopyValue(teacher);
            swappedTch.Group = studentManager.CopyValue(teacher.Group);
            swappedTch.Students = new Student[students.Length];
            for (int i = 0; i < swappedTch.Students.Length; i++)
            {
                swappedTch.Students[i] = studentManager.CopyValue(students[i]);
            }
            return swappedTch;
        }
        public static Teacher SwapWithGroup(Teacher teacher, Group group)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            Teacher swappedTch = new Teacher();
            swappedTch = teacherManager.CopyValue(teacher);
            swappedTch.Group = studentManager.CopyValue(group);
            for (int i = 0; i < teacher.Students.Length; i++)
            {
                swappedTch.Students[i] = studentManager.CopyValue(teacher.Students[i]);
            }

            return swappedTch;
        }
        public static Teacher[] SwapWithStudents(Teacher[] teachers, Student[] students)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            Teacher[] swappedTchs = new Teacher[teachers.Length];
            int minStCount = students.Length / teachers.Length;
            for (int i = 0; i < teachers.Length - 1; i++)
            {
                swappedTchs[i] = teacherManager.CopyValue(teachers[i]);
                swappedTchs[i].Group = studentManager.CopyValue(teachers[i].Group);
                swappedTchs[i].Students = new Student[minStCount];
                for (int j = 0; j < minStCount; j++)
                {
                    swappedTchs[i].Students[j] = studentManager.CopyValue(students[i * minStCount + j]);
                }
            }
            int lastStCount = minStCount * (teachers.Length - 1);
            swappedTchs[teachers.Length - 1] = teacherManager.CopyValue(teachers[lastStCount]);
            swappedTchs[teachers.Length - 1].Group = studentManager.CopyValue(teachers[lastStCount].Group);
            swappedTchs[teachers.Length - 1].Students = new Student[students.Length - lastStCount];
            int counter = 0;
            for (int i = lastStCount; i < students.Length; i++)
            {
                swappedTchs[teachers.Length - 1].Students[counter++] = studentManager.CopyValue(students[i]);
            }
            return swappedTchs;
        }
        public static Teacher[] SwapWithGroups(Teacher[] teachers, Group group)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            Teacher[] swappedTchs = new Teacher[teachers.Length];

            for (int i = 0; i < swappedTchs.Length; i++)
            {
                swappedTchs[i] = teacherManager.CopyValue(teachers[i]);
                swappedTchs[i].Group = studentManager.CopyValue(group);
                for (int j = 0; j < teachers[i].Students.Length; j++)
                {
                    swappedTchs[i].Students[j] = studentManager.CopyValue(teachers[i].Students[j]);
                }
            }
            return swappedTchs;
        }
    }
}
