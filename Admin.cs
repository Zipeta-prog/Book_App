using System.Xml.Linq;

namespace Book_App
{
    public class User
    {
        public int ID { get; private set; }
        public string username_login { get; set; }
        public string password { get; set; }

        private static int nextUserID = 1; // Auto-increment ID

        public User(string username_login, string password)
        {
            ID = nextUserID++;
            username_login = name;
            Password = password;
        }
    }

    public class Admin : User
    {
        public Admin(string username_login, string password) : base(username_login, password)
        {

        }
    }




}