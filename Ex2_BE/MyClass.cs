using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_BE
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum Gender { male, female }

    public class Student
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public bool IsMarried { get; set; }
        public DateTime PersoDate { get; set; }
        public Gender StudentGender { get; set; }
        public List<Course> Courses { get; set; }

        public Student()
        {
            Courses = new List<Course>();
        }
    }
}
