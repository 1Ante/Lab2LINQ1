using Lab2Linq.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Linq
{
    class SchoolDb : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<StudSubTeach> StudSubTeachs { get; set; }

        public DbSet<TeacherSubject> TeacherSubjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-BRKQTHE\SQLEXPRESS;Initial Catalog=SchoolDb;Integrated Security = True;");
        }
    }
}
