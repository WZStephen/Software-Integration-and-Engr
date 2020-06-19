using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Instructor
    {
        public string InstructName { get; set; }
        public string OfficeNumber { get; set; }
        public string EmailAddress { get; set; }

        public Instructor(string instructorname, string officenumber, string emailaddress)
        {
            InstructName = instructorname;
            OfficeNumber = officenumber;
            EmailAddress = emailaddress;
        }
    }
}
