using UniversityConsoleApp.Models;
namespace UniversityConsoleApp.BL
{
    public static class UniversityManager
    {
        public static Student SwapWithTeacher(Student student, Teacher teacher)
        {
            student._teacher = teacher;
            return student;
        }
        public static Student[] SwapWithTeachers(Student[] students, Teacher teacher)
        {
            for(int i = 0; i < students.Length; i++)
                students[i]._teacher = teacher;
            return students;
        }
        public static Teacher SwapWithStudent(Teacher teacher, Student[] students)
        {
            teacher._students = new Student[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                teacher._students[i] = students[i];
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

    }
}
