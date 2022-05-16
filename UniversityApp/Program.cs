using UniversityApp.BL;
using UniversityApp.Models;

namespace UniversityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();

            Student student = (Student)studentManager.Create("John", "Doe", 19);
            Student[] students = (Student[])studentManager.Create(5, 16);
            Teacher teacher = (Teacher)teacherManager.Create("Albert", "Einstein", 26);
            Teacher[] teachers = (Teacher[])teacherManager.Create(3, 26);
            Group group = new Group() { Name = "Group1" };

            Student swappedStd = new Student();
            swappedStd = UniversityManager.SwapWithTeacher(student, teacher);
            swappedStd = UniversityManager.SwapWithGroup(swappedStd, group);
            studentManager.Print(student);
            studentManager.Print(swappedStd);

            Student[] swappedStds = new Student[students.Length];
            swappedStds = UniversityManager.SwapWithTeacher(students, teacher);
            swappedStds = UniversityManager.SwapWithGroup(swappedStds, group);
            studentManager.Print(students);
            studentManager.Print(swappedStds);

            Teacher swappedTch = new Teacher();
            swappedTch = UniversityManager.SwapWithStudents(teacher, students);
            swappedTch = UniversityManager.SwapWithGroup(swappedTch, group);
            teacherManager.Print(teacher);
            teacherManager.Print(swappedTch);

            Teacher[] swappedTchs = new Teacher[teachers.Length];
            swappedTchs = UniversityManager.SwapWithStudents(teachers, students);
            swappedTchs = UniversityManager.SwapWithGroups(swappedTchs, group);
            teacherManager.Print(teachers);
            teacherManager.Print(swappedTchs);
        }
    }
}
