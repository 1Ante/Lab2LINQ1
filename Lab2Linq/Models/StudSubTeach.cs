using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab2Linq.Models
{
    public class StudSubTeach
    {   
        [Key]
        public int StudentSubjectID { get; set; }

        public int StudentId { get; set; }

        public int SubjectId { get; set; }

        public int TeacherId { get; set; }

        public StudSubTeach(int studentId, int subjectId, int teacherId)
        {
            StudentId = studentId;
            SubjectId = subjectId;
            TeacherId = teacherId;

        }

        public Student Student { get; set; }

        public Subject Subject { get; set; }

        public Teacher Teacher { get; set; }

    }
}