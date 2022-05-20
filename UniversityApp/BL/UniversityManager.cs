using System;
using UniversityApp.Models;
using System.Collections.Generic;

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
        public static List<Student> SwapWithTeacher(List<Student> students, Teacher teacher)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            List<Student> swappedStds = new List<Student>(students.Count);
            for (int i = 0; i < students.Count; i++)
            {
                swappedStds.Add(studentManager.CopyValue(students[i]));
                swappedStds[i].Teacher = teacherManager.CopyValue(teacher);
                swappedStds[i].Group = studentManager.CopyValue(students[i].Group);
            }
            return swappedStds;
        }
        public static List<Student> SwapWithGroup(List<Student> students, Group group)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            List<Student> swappedStds = new List<Student>(students.Count);
            for (int i = 0; i < students.Count; i++)
            {
                swappedStds.Add(studentManager.CopyValue(students[i]));
                swappedStds[i].Teacher = (Teacher)teacherManager.CopyValue(students[i].Teacher);
                swappedStds[i].Group = studentManager.CopyValue(group);
            }
            return swappedStds;
        }
        public static Teacher SwapWithStudents(Teacher teacher, List<Student> students)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            Teacher swappedTch = new Teacher();
            swappedTch = (Teacher)teacherManager.CopyValue(teacher);
            swappedTch.Group = studentManager.CopyValue(teacher.Group);
            swappedTch.Students = new List<Student>(students.Count);
            for (int i = 0; i < swappedTch.Students.Count; i++)
            {
                swappedTch.Students[i] = (Student)studentManager.CopyValue(students[i]);
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
            for (int i = 0; i < teacher.Students.Count; i++)
            {
                swappedTch.Students[i] = studentManager.CopyValue(teacher.Students[i]);
            }

            return swappedTch;
        }
        public static List<Teacher> SwapWithStudents(List<Teacher> teachers, List<Student> students)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            List<Teacher> swappedTchs = new List<Teacher>(teachers.Count);
            int minStCount = students.Count / teachers.Count;
            for (int i = 0; i < teachers.Count - 1; i++)
            {
                swappedTchs.Add(teacherManager.CopyValue(teachers[i]));
                swappedTchs[i].Group = studentManager.CopyValue(teachers[i].Group);
                for (int j = 0; j < minStCount; j++)
                {
                    swappedTchs[i].Students = new List<Student>();
                    swappedTchs[i].Students.Add(studentManager.CopyValue(students[i * minStCount + j]));
                }
            }
            int lastStCount = minStCount * (teachers.Count - 1);
            swappedTchs.Add(teacherManager.CopyValue(teachers[lastStCount]));
            swappedTchs[teachers.Count - 1].Group = studentManager.CopyValue(teachers[lastStCount].Group);
            swappedTchs[teachers.Count - 1].Students = new List<Student>(students.Count - lastStCount);
            int counter = 0;
            for (int i = lastStCount; i < students.Count; i++)
            {
                swappedTchs[teachers.Count - 1].Students = new List<Student>();
                swappedTchs[teachers.Count - 1].Students.Add(studentManager.CopyValue(students[i]));
            }
            return swappedTchs;
        }
        public static List<Teacher> SwapWithGroups(List<Teacher> teachers, Group group)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            List<Teacher> swappedTchs = new List<Teacher>(teachers.Count);

            for (int i = 0; i < teachers.Count; i++)
            {
                swappedTchs.Add(teacherManager.CopyValue(teachers[i]));
                swappedTchs[i].Group = studentManager.CopyValue(group);
                for (int j = 0; j < teachers[i].Students.Count; j++)
                {
                    swappedTchs[i].Students.Add(studentManager.CopyValue(teachers[i].Students[j]));
                }
            }
            return swappedTchs;
        }
    }
}
