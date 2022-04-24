using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab2Linq
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        
        [Required]
        public string ClassName { get; set; }

        public Student Student { get; set; }

       
    }
}
