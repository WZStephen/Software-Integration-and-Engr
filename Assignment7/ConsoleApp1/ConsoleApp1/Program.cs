using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the course array
            Course[] course_array = utilities.readFile_course("Courses.csv");

            //Query (Question1)
            IEnumerable<Course> lines = from course in course_array where course.Subject == "IEE" && course.CourseCode >= 300 orderby course.Instructor select course;
            Console.WriteLine("\n***IEE courses with a course number of 300 or higher***\n");
            foreach (var currentLine in lines)
            {
                Console.WriteLine("Course title is " + currentLine.CourseTitle + "---" +"Course Instructor is " + currentLine.Instructor);
            }

            //Query (Question 2)
            // 1st: Group the courses by subjects
            // 2nd: Group the grouped courses(subject) by course code
            var groupedCourses = from course in course_array
                                 group course by course.Subject into Subjects
                       select new{
                           Subject = Subjects.Key, 
                           CourseCodes = from courses in Subjects group courses by courses.CourseCode into CourseCodes 
                                         select new { 
                                             code = CourseCodes.Key 
                                         }
                       };
            Console.WriteLine("\n\n***The groups that have at least two courses in the second level group***\n");
            foreach (var line in groupedCourses)
            {
                int numberOfCourses = line.CourseCodes.Count();
                if (numberOfCourses >= 2)
                {
                    Console.WriteLine("Subject: " + line.Subject);
                }
            }


        }
    }
}
