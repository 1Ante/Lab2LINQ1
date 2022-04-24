using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab2Linq.Models
{
    public class TeacherSubject
    {
        [Key]
        public int TeacherSubjectsId { get; set; }

        public int TeacherId { get; set; }

        public int SubjectId { get; set; }

        public TeacherSubject(int teacherId, int subjectId)
        {
            TeacherId = teacherId;
            SubjectId = subjectId;
            
        }

        public Teacher Teacher { get; set; }

        public Subject Subject { get; set; }
    }
}
