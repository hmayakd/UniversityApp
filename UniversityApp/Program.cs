using UniversityApp.BL;
using UniversityApp.Models;

namespace UniversityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = StudentManager.Create("John", "Doe", 19);
            Student[] students = StudentManager.Create(5, 16);
            Teacher teacher = TeacherManager.Create("Albert", "Einstein", 26);
            Teacher[] teachers = TeacherManager.Create(3, 26);
            Group group = new Group() { Name = "Group1" };

            Student swappedStd = new Student();
            swappedStd = UniversityManager.SwapWithTeacher(student, teacher);
            swappedStd = UniversityManager.SwapWithGroup(swappedStd, group);
            StudentManager.Print(student);
            StudentManager.Print(swappedStd);

            Student[] swappedStds = new Student[students.Length];
            swappedStds = UniversityManager.SwapWithTeacher(students, teacher);
            swappedStds = UniversityManager.SwapWithGroup(swappedStds, group);
            StudentManager.Print(students);
            StudentManager.Print(swappedStds);

            Teacher swappedTch = new Teacher();
            swappedTch = UniversityManager.SwapWithStudents(teacher, students);
            swappedTch = UniversityManager.SwapWithGroup(swappedTch, group);
            TeacherManager.Print(teacher);
            TeacherManager.Print(swappedTch);

            Teacher[] swappedTchs = new Teacher[teachers.Length];
            swappedTchs = UniversityManager.SwapWithStudents(teachers, students);
            swappedTchs = UniversityManager.SwapWithGroups(swappedTchs, group);
            TeacherManager.Print(teachers);
            TeacherManager.Print(swappedTchs);
        }
    }
}
