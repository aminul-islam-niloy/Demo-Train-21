using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Code_21.Objct_and_Class
{
    internal class Student
    {
  

        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public  string Department { get; set; } 
        public string Session { get; set; }
        public string Address { get; set; }

        private string password;
        private string copon = "hhhhh";

        public string getCopun()
        {
            return copon;
        }

        public void setPassword(string pass)
        {
            password = pass;
        }

        public string getpassword()
        {
            return password;
        }

        //public Student()
        //{
        //    StudentId = 1001;
        //    Console.WriteLine("Value is setted in Constructor and it's "+ StudentId);
        //    //note that constructor is called automatic and 
        //    //getting and setting value is priority than initiation in constructor
        //}

        public void DisplayStudentInfo()
        {
            Console.WriteLine("Student Id = " + StudentId);
            Console.WriteLine("Student Name = " + Name);
            Console.WriteLine("Student Phone = " + Phone);
            Console.WriteLine("Student Department = " + Department);
            Console.WriteLine("Student Session = " + Session);
            Console.WriteLine("Student Address = " + Address);
            Console.WriteLine("\n");
        }

      

    }
}
