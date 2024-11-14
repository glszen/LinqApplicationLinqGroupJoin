using LinqApplicationLinqGroupJoin;
using System.Net.WebSockets;

List<Student> students = new List<Student>()
{
    new Student
    {
        StudentId = 1,
        StudentName = "Ali",
        ClassId = 1
    },

    new Student
    {
        StudentId = 2,
        StudentName = "Ayşe",
        ClassId = 2
    },

    new Student
    {
        StudentId = 3,
        StudentName = "Mehmet",
        ClassId = 1
    },

    new Student
    {
        StudentId = 4,
        StudentName = "Fatma",
        ClassId = 3
    },

    new Student
    {
        StudentId = 5,
        StudentName = "Ahmet",
        ClassId = 2
    }
};

List<Class> classes = new List<Class>()
{
    new Class
    {
        ClassId = 1,
        ClassName = "Matematik"
    },

    new Class
    {
        ClassId = 2,
        ClassName = "Türkçe"
    },

    new Class
    {
        ClassId = 3,
        ClassName = "Kimya"
    },
};

var result = classes.GroupJoin(students, @class => @class.ClassId, student => student.ClassId, (@class, studentGroup) => new
{
    Class = @class.ClassName,
    Students = studentGroup.ToList()
}
);

foreach (var item in result)
{
    Console.WriteLine("\nClasses: " + item.Class);

    foreach (var student in item.Students)
    {
        Console.WriteLine("Students: " + student.StudentName);
    }
}