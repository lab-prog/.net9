using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create a list of Student objects
            List<Student> students = new List<Student>
            {
                new Student(1, "Alice", 20, "A"),
                new Student(2, "Bob", 22, "B"),
                new Student(3, "Charlie", 21, "A"),
                new Student(4, "Diana", 23, "C"),
                new Student(5, "Eve", 20, "B")
            };

            // Step 2: Select - Project student names
            var studentNames = students.Select(s => s.Name);
            Console.WriteLine("Student Names:");
            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }

            // Step 3: Filter - Select students with grade "A"
            var gradeAStudents = students.Where(s => s.Grade == "A");
            Console.WriteLine("\nStudents with Grade A:");
            foreach (var student in gradeAStudents)
            {
                Console.WriteLine($"{student.Name} (Age: {student.Age})");
            }

            // Step 4: Sort - Order students by age
            var sortedByAge = students.OrderBy(s => s.Age);
            Console.WriteLine("\nStudents sorted by Age:");
            foreach (var student in sortedByAge)
            {
                Console.WriteLine($"{student.Name} (Age: {student.Age})");
            }

            // Step 5: Group - Group students by grade
            var groupedByGrade = students.GroupBy(s => s.Grade);
            Console.WriteLine("\nStudents grouped by Grade:");
            foreach (var group in groupedByGrade)
            {
                Console.WriteLine($"Grade {group.Key}:");
                foreach (var student in group)
                {
                    Console.WriteLine($"  - {student.Name}");
                }
            }
        }
    }
}
