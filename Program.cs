// See https://aka.ms/new-console-template for more information
using BOOK_SYSTEM;
using BOOK_SYSTEM.Services;

Console.WriteLine("Hello, World!");

LoginService loginService = new LoginService();
await loginService.LoginAsync();

/*Register register = new Register();
register.RegisterUser();*/

