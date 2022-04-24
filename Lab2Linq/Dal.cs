using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lab2Linq.Models;

namespace Lab2Linq
{
    public class Dal
    {

        public void GetAllTeachersProgramming1()
        {
            using SchoolDb context = new SchoolDb();
            {

                IEnumerable<string> QuerySyntax = (from a in context.Teachers
                                                   join b in context.TeacherSubjects on a.TeacherId equals b.TeacherId
                                                   join c in context.Subjects on b.SubjectId equals  c.SubjectId
                                                   where c.SubjectId == 2
                                                   select a.TeacherName);

                foreach (var item in QuerySyntax)
                {
                    Console.WriteLine("Lärare som undervisar i Programmering 1: " + item);
                }
            }            
        }
        public void GetAllStudentsWithTeachers()
        {
            using SchoolDb context = new SchoolDb();
            {                               
                var results = from a in context.Students
                              join b in context.StudSubTeachs on a.StudentId equals b.StudentId
                              join c in context.Teachers on b.TeacherId equals c.TeacherId
                              orderby a.FirstName
                              select new { a.FirstName, a.LastName, c.TeacherName };                

                foreach (var item in results)
                {
                    Console.WriteLine("Elev: " + $"{item.FirstName}" + " " + $"{item.LastName}" + " " + "har lärare: " + $"{item.TeacherName}");

                }
            }
        }

        public void GetAllStudentsProgramming1()
        {
            using SchoolDb context = new SchoolDb();
            {
                var results = from a in context.Students
                              join b in context.StudSubTeachs on a.StudentId equals b.StudentId
                              join c in context.Subjects on b.SubjectId equals c.SubjectId
                              join d in context.Teachers on b.TeacherId equals d.TeacherId
                              where c.SubjectName == "Programmering 1"
                              select new { a.FirstName, a.LastName, d.TeacherName };

                foreach (var item in results)
                {
                    Console.WriteLine("Elev: " + $"{item.FirstName}" + " " + $"{item.LastName}" + " " + "Lärare: " + $"{item.TeacherName}");
                }
            }
        }

        public void EditSubject()
        {
            using SchoolDb context = new SchoolDb();
            {

                var subject = context.Subjects.Where(p => p.SubjectName == "Programmering 2").FirstOrDefault();

                if (subject is Subject)
                {
                    subject.SubjectName = "OOP";
                }

                context.SaveChanges();
            }
        }
        
        public void UpdateTeacher()
        {
            using SchoolDb context = new SchoolDb();
            {
                var teacher = context.StudSubTeachs.Where(p => p.StudentId == 1 && p.SubjectId == 2 && p.TeacherId == 2).FirstOrDefault();

                if (teacher is StudSubTeach)
                {
                    teacher.TeacherId = 4;
                }

                context.SaveChanges();            

            }
        }
    }
    
}
