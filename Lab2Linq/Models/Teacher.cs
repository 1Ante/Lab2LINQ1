using Lab2Linq.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab2Linq
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Required]
        public string TeacherName { get; set; }

       
        public Student Student { get; set; }


        public ICollection<Student> Students { get; set; }
        

        public ICollection<StudSubTeach> StudSubTeachs { get; set; }

        public ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
