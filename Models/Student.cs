using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Student
    {
        [Key]
        public long Id { get; set; }
        public long CourseId { get; set; }
        public string UserName { get; set; }
        public long Age { get; set; }
    }
}