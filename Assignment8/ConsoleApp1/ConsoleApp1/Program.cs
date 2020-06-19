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

            //Get the instructor array
            Instructor[] instructor_array = utilities.readFile_instructor("Instructors.csv");

            //foreach (var item in course_array)
            //{
            //    Console.WriteLine(item.Instructor);
            //}
            //Console.WriteLine("---------");
            //foreach (var item in instructor_array)
            //{
            //     Console.WriteLine(item.InstructName);
            //}

            //Query
            var oneFive = from course in course_array
                          join instructor in instructor_array on course.Instructor equals instructor.InstructName
                          where  course.CourseCode >= 200 && course.CourseCode <= 300
                          orderby course.CourseCode
                          select new { course.Subject, course.CourseCode, course.CourseNbr, instructor.EmailAddress };

            int count = 0;
            Console.WriteLine("\n***All CSE200 level courses with instructor's email address***\n");
            foreach (var course in oneFive)
            {
                Console.WriteLine(course.Subject + course.CourseCode + " " + course.CourseNbr + " " + course.EmailAddress);
                count++;
            }
            Console.WriteLine("\n Total count: " + count);
        }
    }
}
