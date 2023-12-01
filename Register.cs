using BOOK_SYSTEM.Models;
using BOOK_SYSTEM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_SYSTEM
{
    internal class Register
    {
        public Register() { }


        public void RegisterUser()
        {
            Console.WriteLine("WELCOME TO OUR SYSTEM\nREGISTER\nEnter username:");
            String username = Console.ReadLine();
            Console.WriteLine($"ENTER PASSWORD FOR {username}");
            String password = Console.ReadLine();
            Users users = new Users();
            users.password = password;
            users.userName = username;
            UsersService usersService = new UsersService();
            usersService.RegisterUsers(users).Wait();





        }
    }
}
