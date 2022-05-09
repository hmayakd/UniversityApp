using UniversityApp.BL;
using UniversityApp.Models;

namespace UniversityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = StudentManager.Create("John", "Doe", 19);
            StudentManager.Print(student);
            Student[] students = StudentManager.Create(14, 18);
            StudentManager.Print(students);
            Teacher teacher = TeacherManager.Create("Albert", "Einstein", 21);
            TeacherManager.Print(teacher);
            Teacher[] teachers = TeacherManager.Create(3, 19);
            TeacherManager.Print(teachers);
            Group group = GroupManager.Create("Math");
            GroupManager.Print(group);
            Group[] groups = GroupManager.Create(7);
            GroupManager.Print(groups);

            Student swappedStd = new Student();
            swappedStd = UniversityManager.SwapWithTeacher(student, teacher);
            swappedStd = UniversityManager.SwapWithGroup(student, group);
            StudentManager.Print(swappedStd);
            Student[] swappedStds = new Student[students.Length];
            swappedStds = UniversityManager.SwapWithTeacher(students, teacher);
            swappedStds = UniversityManager.SwapWithGroup(students, group);
            StudentManager.Print(swappedStds);
            Teacher swappedTch = new Teacher();
            swappedTch = UniversityManager.SwapWithStudents(teacher, students);
            swappedTch = UniversityManager.SwapWithGroups(teacher, groups);
            TeacherManager.Print(swappedTch);
            Teacher[] swappedTchs = new Teacher[teachers.Length];
            swappedTchs = UniversityManager.SwapWithStudents(teachers, students);
            swappedTchs = UniversityManager.SwapWithGroups(teachers, groups);
            TeacherManager.Print(swappedTchs);
        }
    }
}
