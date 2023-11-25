using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Code_21.CRC;
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


            //CRC maintain

            BankAccount bc = new BankAccount(1000);

            Console.WriteLine( bc.GetBalance());

            bc.Deposit(5000);
            Console.WriteLine(bc.GetBalance());

            bc.Withdraw(1000);
            Console.WriteLine(bc.GetBalance());

            bc.Withdraw(100000);
            Console.WriteLine(bc.GetBalance());






            Console.ReadKey();
        }
    }
}
