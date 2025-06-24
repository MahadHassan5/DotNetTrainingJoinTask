using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var courses = new List<Course>
        {
            new Course { CourseId = 1, CourseName = "Math" }
        };

        var students = new List<Student>
        {
            new Student { StudentId = 1, Name = "Ali", CourseId = 1 }
        };

        // Method Syntax Join
        var methodJoin = students.Join(
            courses,
            s => s.CourseId,
            c => c.CourseId,
            (s, c) => new { s.Name, c.CourseName });

        Console.WriteLine("Method Syntax:");
        foreach (var item in methodJoin)
            Console.WriteLine($"{item.Name} - {item.CourseName}");

        // Query Syntax Join
        var queryJoin = from s in students
                        join c in courses on s.CourseId equals c.CourseId
                        select new { s.Name, c.CourseName };

        Console.WriteLine("\nQuery Syntax:");
        foreach (var item in queryJoin)
            Console.WriteLine($"{item.Name} - {item.CourseName}");
    }
}

class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }

}

class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int CourseId { get; set; }
}
