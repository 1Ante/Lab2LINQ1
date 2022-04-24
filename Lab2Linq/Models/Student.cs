using Lab2Linq.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab2Linq
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int ClassId { get; set; }

        public Student(string firstName, string lastName, int classId)
        {
            FirstName = firstName;
            LastName = lastName;
            ClassId = classId;
            
        }

        public Class Class { get; set; }
       
        public ICollection<StudSubTeach> StudSubTeachs { get; set; }

    }
}
