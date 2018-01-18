using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [Display(Name  = "Name")]
        public string TeacherName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}