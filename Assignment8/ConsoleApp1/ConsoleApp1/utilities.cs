using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class utilities
    {
        public static Course NewCourse(string[] information)
        {
            //string subject, int coursecode, int coursenbr, string coursetitle, string location, string instructor
            string subject = information[0];
            int code = Convert.ToInt32(information[1]);
            int id = Convert.ToInt32(information[2]);
            string title = information[3];
            string loc = information[7];
            string ins = information[10];
            Course course = new Course(subject, code, id, title, loc, ins);
            return course;
        }

        public static Instructor NewInstructor(string[] information)
        {
            string instrunctorname = information[0];
            string office = information[1];
            string email_address = information[2];
            Instructor instructor = new Instructor(instrunctorname, office, email_address);
            return instructor;
        }


        public static Course[] readFile_course(string fileName) {
            // Read file
            var rootDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string file = Path.Combine(rootDirectory, fileName);
            Console.WriteLine(file);
            int totalCount = 0;

            //count the total line of the Course file
            var lineCount = File.ReadLines(file).Count();

            //Read the courses into course array
            Course[] array = new Course[lineCount - 1];
            var fileReader = new StreamReader(file);
            using (fileReader)
            {
                //initialize the readline
                string line = fileReader.ReadLine();

                //skip the first informational line
                line = fileReader.ReadLine();

                //read over the rest lines
                while (line != null)
                {
                    string[] data = line.Split(",");
                    totalCount++;
                    Course course = utilities.NewCourse(data);
                    array[totalCount - 1] = course;
                    line = fileReader.ReadLine();
                }
                //foreach (var item in array)
                //{
                //     Console.WriteLine(item.CourseCode.ToString());
                //}
            }
            return array;
        }

        public static Instructor[] readFile_instructor(string fileName)
        {
            // Read file
            var rootDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string file = Path.Combine(rootDirectory, fileName);
            Console.WriteLine(file);
            int totalCount = 0;

            //count the total line of the Course file
            var lineCount = File.ReadLines(file).Count();
            //Console.WriteLine(lineCount);
            //Read the courses into course array
            Instructor[] array = new Instructor[lineCount - 1];
            var fileReader = new StreamReader(file);
            using (fileReader)
            {
                //initialize the readline
                string line = fileReader.ReadLine();

                //skip the first informational line
                line = fileReader.ReadLine();

                //read over the rest lines
                while (line != null)
                {
                    string[] data = line.Split(",");
                    totalCount++;
                    Instructor instructor = utilities.NewInstructor(data);
                    array[totalCount - 1] = instructor;
                    line = fileReader.ReadLine();
                }
            }
            return array;
        }

    }
}
