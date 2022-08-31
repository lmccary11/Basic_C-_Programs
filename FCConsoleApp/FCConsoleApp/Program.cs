using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallengeConsoleApp
{
    internal class Program

    {
        static void Main(string[] args)
        {
            using (var db = new StudentSubject())
            {
                // Create and save a new Student
                Console.Write("Enter the name for a new Student: ");
                var studentName = Console.ReadLine();

                var student = new Student { StudentName = studentName };
                db.Students.Add(student);
                db.SaveChanges();

                // Display all Students from the database
                var query = from b in db.Students
                            orderby b.StudentName
                            select b;

                Console.WriteLine("All students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
        public class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }

            public virtual List<Subject> Subjects { get; set; }
        }
        public class Subject
        {
            public int SubjectId { get; set; }
            public string SubjectName { get; set; }
            public string SubjectSemester { get; set; }

            public int StudentId { get; set; }
            public virtual Student Student { get; set; }
        }

        public class StudentSubject : DbContext
        {
            public DbSet<Subject> Subjects { get; set; }
            public DbSet<Student> Students { get; set; }
        }
    }
}