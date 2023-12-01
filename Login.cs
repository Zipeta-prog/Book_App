using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_App
{
    public class Login
    {
        public void Start()
        {
            Console.WriteLine(" You Can Now Login");
            Console.WriteLine("Enter Your Username ");
            string username_login = Console.ReadLine();

            string[] lines = File.ReadAllLines(@"C:\Book_App\Login.cs\reg.txt");

            // if(i == (letters.length -1))
            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(' ');

                if (i == (lines.Length - 1))
                {
                    if (values[0] != username_login)
                    {
                        Console.WriteLine("Not Found, " + username_login);

                    }

                }

                if (values[0] == username_login)
                {

                    Console.WriteLine("Enter Password ");
                    string password_login = Console.ReadLine();
                    if (values[1] == password_login)
                    {
                        Console.WriteLine("Welcome, " + username_login);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You entered a Wrong Password");
                    }
                }


                // jane 345

            }
        }

    }

}
