using System;
using Microsoft.Win32;
// using static register;

namespace Book_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome, Choose an Option to Proceed.
            //1. Register (Type 1)
            //2. Login (Type 2)

            //If (Console.readline == 1)
            Register register = new Register();
            Login login = new Login();

            //If (Console.readline == 2)
            /* Login login = new Login();
             login.main(); */

            Console.WriteLine(" Welcome, Choose an Option to Proceed \n 1. Register  (Type 1) \n 2. Login  (Type 2)");
            string option = Console.ReadLine();
            if (option == "1")
            {
                register.Start();

            }
            else if (option == "2")
            {
                Console.WriteLine("Proceed to login");
                login.Start();
            }
            else
            {
                Console.WriteLine("You entered an invalid option");
            }

        }
    }
}