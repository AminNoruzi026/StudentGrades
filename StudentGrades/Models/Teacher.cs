using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentGrades.Models
{
    public class Teacher : Person
    {
        public int Id { get; set; }

        public ICollection<Student> students { get; set; }
        public ICollection<Lesson> lessons { get; set; }

    }
}