using UniversityConsoleApp.BL;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = StudentManager.Create("John", "Doe", 19);
            StudentManager.Print(student);
            Student[] students = StudentManager.Create(7, 18);
            StudentManager.Print(students);
            Teacher teacher = TeacherManager.Create("Albert", "Einstein", 21);
            TeacherManager.Print(teacher);
            Teacher[] teachers = TeacherManager.Create(3, 19);
            TeacherManager.Print(teachers);

            Student swappedStd = new Student();
            swappedStd = UniversityManager.SwapWithTeacher(student, teacher);
            StudentManager.Print(swappedStd);
            Student[] swappedStds = new Student[students.Length];
            swappedStds = UniversityManager.SwapWithTeachers(students, teacher);
            StudentManager.Print(swappedStds);
            Teacher swappedTch = new Teacher();
            swappedTch = UniversityManager.SwapWithStudent(teacher, students);
            TeacherManager.Print(swappedTch);
            Teacher[] swappedTchs = new Teacher[teachers.Length];
            swappedTchs = UniversityManager.SwapWithStudents(teachers, students);
            TeacherManager.Print(swappedTchs);
        }
    }
}
