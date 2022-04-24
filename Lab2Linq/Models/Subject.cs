using Lab2Linq.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab2Linq
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        [Required]
        public string SubjectName { get; set; }
       
        public Student Student { get; set; }

        public Teacher Teacher { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<StudSubTeach> StudSubTeachs { get; set; }

        public ICollection <TeacherSubject> TeacherSubjects { get; set; }
        
    }
}
