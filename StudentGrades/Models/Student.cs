using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentGrades.Models
{
    public class Student : Person
    {
        public int Id { get; set; }
        public ICollection<Lesson> lessons { get; set; }

        public int TeacherId { get; set; }
        public Teacher teacher { get; set; }


    }
}