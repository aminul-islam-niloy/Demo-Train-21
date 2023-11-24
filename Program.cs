using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Code_21.Objct_and_Class;

namespace Demo_Code_21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // OOP Class and object 
            Student student = new Student();
            student.Name = "Aminul";
            student.StudentId = 1354576;
            student.Phone = 9876543;
            student.Department = "CSE";
            student.Session = "2018";
            student.Address = "Dhaka";

            Student student1 = new Student();
            student.DisplayStudentInfo();

            student1 = student;
            student1.DisplayStudentInfo();

            //set and get private value
            student.setPassword("123547");
            string pass = student.getpassword();
            Console.WriteLine("Password is = " + pass);
            Console.WriteLine("Copon is : " + student.getCopun());


            Console.ReadKey();
        }
    }
}
