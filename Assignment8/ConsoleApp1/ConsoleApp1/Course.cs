using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Course
    {
        public string Subject { get; set; }
        public int CourseCode { get; set; }
        public int CourseNbr { get; set; }
        public string CourseTitle { get; set; }
        public string Location { get; set; }
        public string Instructor { get; set; }

        // Constructor
        public Course(string subject, int coursecode, int coursenbr, string coursetitle, string location, string instructor)
        {
            Subject = subject;
            CourseCode = coursecode;
            CourseNbr = coursenbr;
            CourseTitle = coursetitle;
            Location = location;
            Instructor = instructor;
        }
    }
}
