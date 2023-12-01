using BOOK_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_SYSTEM.Services
{
    internal class LoginService
    {
        public LoginService() { 
        
        }

        public async Task LoginAsync()
        {
            Console.WriteLine("WELCOME ENTER LOGIN CREDETIALS TO START \n Username:");
            String username=Console.ReadLine();
            Console.WriteLine($"ENTER PASSWORD FOR {username}");
            String password=Console.ReadLine();

            UsersService usersService = new UsersService();
          List<Users> allusers= await usersService.GetAllUsers();
            Users users=allusers.Find(element=>element.userName==username && element.password==password);
            if (users != null)
            {
                Console.WriteLine("login successfully");
                if(users.userName=="admin")
                {

                }else
                {
                    BookService bookService = new BookService();
                    await bookService.GetAllAvailableBooks(users.id);
                }

            }else
            {
                Console.WriteLine("Wrong username or password");
               await LoginAsync();

            }


        }

    }
}
