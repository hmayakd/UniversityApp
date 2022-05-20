using System.Collections.Generic;
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
            List<Student> students = studentManager.PersonToStd(studentManager.Create(5, 16));
            Teacher teacher = (Teacher)teacherManager.Create("Albert", "Einstein", 26);
            List<Teacher> teachers = teacherManager.PersonToTch(teacherManager.Create(3, 26));
            Group group = new Group() { Name = "Group1" };

            Student swappedStd = new Student();
            swappedStd = UniversityManager.SwapWithTeacher(student, teacher);
            swappedStd = UniversityManager.SwapWithGroup(swappedStd, group);
            studentManager.Print(student);
            studentManager.Print(swappedStd);

            List<Student> swappedStds = new List<Student>(students.Count);
            swappedStds = UniversityManager.SwapWithTeacher(students, teacher);
            swappedStds = UniversityManager.SwapWithGroup(swappedStds, group);
            studentManager.Print(studentManager.StudentsToPrs(students));
            studentManager.Print(studentManager.StudentsToPrs(swappedStds));

            Teacher swappedTch = new Teacher();
            swappedTch = UniversityManager.SwapWithStudents(teacher, students);
            swappedTch = UniversityManager.SwapWithGroup(swappedTch, group);
            teacherManager.Print(teacher);
            teacherManager.Print(swappedTch);

            List<Teacher> swappedTchs = new List<Teacher>(teachers.Count);
            swappedTchs = UniversityManager.SwapWithStudents(teachers, students);
            swappedTchs = UniversityManager.SwapWithGroups(swappedTchs, group);
            teacherManager.Print(teacherManager.TeacherToPrs(teachers));
            teacherManager.Print(teacherManager.TeacherToPrs(swappedTchs));
        }
    }
}
