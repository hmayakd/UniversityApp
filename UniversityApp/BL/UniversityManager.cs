using UniversityApp.Models;

namespace UniversityApp.BL
{
    public static class UniversityManager
    {
        public static Student SwapWithTeacher(Student student, Teacher teacher)
        {
            Student swappedStd = new Student();
            swappedStd = student;
            swappedStd._teacher = teacher;
            return swappedStd;
        }
        public static Student SwapWithGroup(Student student, Group group)
        {
            Student swappedStd = new Student();
            swappedStd = student;
            swappedStd._group = group;
            return swappedStd;
        }
        public static Student[] SwapWithTeacher(Student[] students, Teacher teacher)
        {
            for (int i = 0; i < students.Length; i++)
                students[i]._teacher = teacher;
            return students;
        }
        public static Student[] SwapWithGroup(Student[] students, Group group)
        {
            for (int i = 0; i < students.Length; i++)
                students[i]._group = group;
            return students;
        }
        public static Teacher SwapWithStudents(Teacher teacher, Student[] students)
        {
            teacher._students = new Student[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                teacher._students[i] = students[i];
            }
            return teacher;
        }
        public static Teacher SwapWithGroups(Teacher teacher, Group[] groups)
        {
            teacher._groups = new Group[groups.Length];
            for (int i = 0; i < groups.Length; i++)
            {
                teacher._groups[i] = groups[i];
            }
            return teacher;
        }
        public static Teacher[] SwapWithStudents(Teacher[] teachers, Student[] students)
        {
            int minStCount = students.Length / teachers.Length;
            for (int i = 0; i < teachers.Length - 1; i++)
            {
                teachers[i]._students = new Student[minStCount];
                for (int j = 0; j < minStCount; j++)
                {
                    teachers[i]._students[j] = students[i * minStCount + j];
                }
            }
            int lastStCount = minStCount * (teachers.Length - 1);
            teachers[teachers.Length - 1]._students = new Student[students.Length - lastStCount];
            int counter = 0;
            for (int i = lastStCount; i < students.Length; i++)
            {
                teachers[teachers.Length - 1]._students[counter++] = students[i];
            }
            return teachers;
        }
        public static Teacher[] SwapWithGroups(Teacher[] teachers, Group[] groups)
        {
            int minGrCount = groups.Length / teachers.Length;
            for (int i = 0; i < teachers.Length - 1; i++)
            {
                teachers[i]._groups = new Group[minGrCount];
                for (int j = 0; j < minGrCount; j++)
                {
                    teachers[i]._groups[j] = groups[i * minGrCount + j];
                }
            }
            int lastGrCount = minGrCount * (teachers.Length - 1);
            teachers[teachers.Length - 1]._groups = new Group[groups.Length - lastGrCount];
            int counter = 0;
            for (int i = lastGrCount; i < groups.Length; i++)
            {
                teachers[teachers.Length - 1]._groups[counter++] = groups[i];
            }
            return teachers;
        }
        public static Group SwapWithStudents(Group group, Student[] students)
        {
            group._students = new Student[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                group._students[i] = students[i];
            }
            return group;
        }
        public static Group SwapWithTeachers(Group group, Teacher[] teachers)
        {
            group._teachers = new Teacher[teachers.Length];
            for (int i = 0; i < teachers.Length; i++)
            {
                group._teachers[i] = teachers[i];
            }
            return group;
        }
        public static Group[] SwapWithStudents(Group[] groups, Student[] students)
        {
            int minStdCount = students.Length / groups.Length;
            for (int i = 0; i < groups.Length - 1; i++)
            {
                groups[i]._students = new Student[minStdCount];
                for (int j = 0; j < minStdCount; j++)
                {
                    groups[i]._students[j] = students[i * minStdCount + j];
                }
            }
            int lastStdCount = minStdCount * (groups.Length - 1);
            groups[groups.Length - 1]._students = new Student[students.Length - lastStdCount];
            int counter = 0;
            for (int i = lastStdCount; i < students.Length; i++)
            {
                groups[students.Length - 1]._students[counter++] = students[i];
            }
            return groups;
        }
        public static Group[] SwapWithTeachers(Group[] groups, Teacher[] teachers)
        {
            int minTchCount = teachers.Length / groups.Length;
            for (int i = 0; i < groups.Length - 1; i++)
            {
                groups[i]._teachers = new Teacher[minTchCount];
                for (int j = 0; j < minTchCount; j++)
                {
                    groups[i]._teachers[j] = teachers[i * minTchCount + j];
                }
            }
            int lastTchCount = minTchCount * (groups.Length - 1);
            groups[groups.Length - 1]._teachers = new Teacher[teachers.Length - lastTchCount];
            int counter = 0;
            for (int i = lastTchCount; i < teachers.Length; i++)
            {
                groups[teachers.Length - 1]._teachers[counter++] = teachers[i];
            }
            return groups;
        }
    }
}
