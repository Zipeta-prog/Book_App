using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


public class Register
{
    public void Start()
    {

        Console.WriteLine("Proceed with Registration");

        Console.WriteLine("Enter a Username: ");

        string username = Console.ReadLine();

        Console.WriteLine("Enter Password: ");

        string password = Console.ReadLine();



        var path = @"C:\registration-system-master\register.cs\reg.txt";

        File.AppendAllText(path, NewId() + " ");
        File.AppendAllText(path, username + " ");
        File.AppendAllText(path, password);
        File.AppendAllText(path, "\n");

        Console.WriteLine("You Have Now Registered Successfully");
    }

    public int NewId()
    {

        var path = @"C:\Book_App\register.cs\reg.txt";

        if (File.Exists(path))
        {

            var lines = File.ReadAllLines(path);
            var last_line = lines[lines.Length - 1];
            string user_id = last_line.Split(' ')[0];
            int id = Convert.ToInt32(user_id);

            int new_id = ++id;
            return new_id;
        }
        else
        {
            return 1;
        }





    }



}
