using Lab2Linq.Models;
using System;

namespace Lab2Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            Dal d = new Dal();

            using SchoolDb context = new SchoolDb();

            //Class class1 = new Class() { ClassName = "1A" };
            //Class class2 = new Class() { ClassName = "1B" };
            //Class class3 = new Class() { ClassName = "2A" };
            //Class class4 = new Class() { ClassName = "2B" };

            //Student student1 = new Student("Sara", "Persson", 1);
            //Student student2 = new Student("Per", "Andersson", 2);
            //Student student3 = new Student("Johan", "Karlsson", 3);
            //Student student4 = new Student("Maria", "Svensson", 4);

            //Subject subject1 = new Subject() { SubjectName = "Matematik" };
            //Subject subject2 = new Subject() { SubjectName = "Programmering 1" };
            //Subject subject3 = new Subject() { SubjectName = "Engelska" };
            //Subject subject4 = new Subject() { SubjectName = "Programmering 2" };

            //Teacher teacher1 = new Teacher() { TeacherName = "Jan Persson" };
            //Teacher teacher2 = new Teacher() { TeacherName = "Anas Qlok" };
            //Teacher teacher3 = new Teacher() { TeacherName = "Cecilia Johansson" };
            //Teacher teacher4 = new Teacher() { TeacherName = "Caroline Isaksson" };

            //StudSubTeach studSubTeach1 = new StudSubTeach(1, 2, 2);
            //StudSubTeach studSubTeach2 = new StudSubTeach(1, 3, 3);
            //StudSubTeach studSubTeach3 = new StudSubTeach(2, 1, 3);
            //StudSubTeach studSubTeach4 = new StudSubTeach(1, 4, 2);
            //StudSubTeach studSubTeach5 = new StudSubTeach(3, 2, 4);
            //StudSubTeach studSubTeach6 = new StudSubTeach(4, 3, 1);

            TeacherSubject teacherSubjects1 = new TeacherSubject(1, 3);
            TeacherSubject teacherSubjects2 = new TeacherSubject(1, 1);
            TeacherSubject teacherSubjects3 = new TeacherSubject(2, 4);
            TeacherSubject teacherSubjects4 = new TeacherSubject(2, 2);
            TeacherSubject teacherSubjects5 = new TeacherSubject(3, 3);
            TeacherSubject teacherSubjects6 = new TeacherSubject(4, 1);
            TeacherSubject teacherSubjects7 = new TeacherSubject(4, 2);


            //context.Add(class1);
            //context.Add(class2);
            //context.Add(class3);
            //context.Add(class4);

            //context.Add(student1);
            //context.Add(student2);
            //context.Add(student3);
            //context.Add(student4);

            //context.Add(subject1);
            //context.Add(subject2);
            //context.Add(subject3);
            //context.Add(subject4);

            //context.Add(teacher1);
            //context.Add(teacher2);
            //context.Add(teacher3);
            //context.Add(teacher4);

            //context.Add(studSubTeach1);
            //context.Add(studSubTeach2);
            //context.Add(studSubTeach3);
            //context.Add(studSubTeach4);
            //context.Add(studSubTeach5);
            //context.Add(studSubTeach6);


            context.Add(teacherSubjects1);
            context.Add(teacherSubjects2);
            context.Add(teacherSubjects3);
            context.Add(teacherSubjects4);
            context.Add(teacherSubjects5);
            context.Add(teacherSubjects6);
            context.Add(teacherSubjects7);

            context.SaveChanges();


            Console.WriteLine();
            Console.WriteLine("Meny");
            Console.WriteLine();
            Console.WriteLine("1. Hämta alla lärare som undervisar i Programmering 1");
            Console.WriteLine("2. Hämta alla elever med deras lärare, skriv både ut elevernas namn och namnet på alla lärare de har");
            Console.WriteLine("3. Hämta alla elever som läser Programmering 1 och skriv ut deras namn samt vilken lärare de har");
            Console.WriteLine("4. Editera ett ämne från Programmering 2 till OOP");
            Console.WriteLine("5. Uppdatera en elevs lärare i Programmering 1 från Anas till Caroline");
            Console.WriteLine("6. Avsluta programmet");
            Console.WriteLine();
            Console.WriteLine("Välj ur menyn genom att ange siffra:");

            bool keepLooping = true;
            while (keepLooping)
            {                              
                string input = Console.ReadLine();
                Console.WriteLine();
           
                switch (input)
                {
                    case "1":
                        d.GetAllTeachersProgramming1();
                        Console.WriteLine();
                        Console.WriteLine("Gör ett nytt val ur menyn:");
                        break;

                    case "2":
                        d.GetAllStudentsWithTeachers();
                        Console.WriteLine();
                        Console.WriteLine("Gör ett nytt val ur menyn:");
                        break;

                    case "3":
                        d.GetAllStudentsProgramming1();
                        Console.WriteLine();
                        Console.WriteLine("Gör ett nytt val ur menyn:");
                        break;

                    case "4":
                        d.EditSubject();                        
                        Console.WriteLine("Ämnet Programmering 2 har ändrats till OOP");
                        Console.WriteLine();
                        Console.WriteLine("Gör ett nytt val ur menyn:");
                        break;

                    case "5":
                        d.UpdateTeacher();
                        Console.WriteLine("Läraren har uppdaterats till Caroline Isaksson");
                        Console.WriteLine();
                        Console.WriteLine("Gör ett nytt val ur menyn:");
                        break;

                    case "6":
                        keepLooping = false;
                        break;

                    default:
                        Console.WriteLine("Du skrev in ett felaktigt värde. Försök igen");
                        break;


                }
            }
            
         
        }
    }
    
}
