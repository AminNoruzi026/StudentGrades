using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentGrades.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string LessonName { get; set; }
        public string LessonTitle { get; set; }
        public int LessonGrade { get; set; }

        public int StudentId { get; set; }
        public Student student { get; set; }

        public int TeacherId { get; set; }
        public Teacher teacher { get; set; }


    }
}