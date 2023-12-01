using Book_App;

namespace Books
{
    public class BookS
    {
        private List<BookS> books = new List<BookS>();
        private string booksFilePath = @"C:\Book_App\Book.cs\books.txt";
        private string ordersFilePath = @"C:\Book_App\Book.cs\orders.txt";

        public void AddBook(Admin admin, string name, string description)
        {
            if (admin != null)
            {
                BookS newBook = new BookS(name, description);
                books.Add(newBook);

                // Save the updated book list to a file (books.txt)
                using (StreamWriter writer = File.AppendText(@"C:\Book_App\Book.cs\books.txt"))
                {
                    writer.WriteLine($"{newBook.ID},{newBook.BookName},{newBook.Description}");
                }
            }
            else
            {
                Console.WriteLine("Access Denied. Only admins can add books.");
            }
        }

        public void DisplayBooks()
        {
            string[] lines = File.ReadAllLines(@"C:\Book_App\Book.cs\books.txt");
            foreach (var line in lines)
            {
                string[] bookData = line.Split(',');
                Console.WriteLine($"ID: {bookData[0]} | Name: {bookData[1]} | Description: {bookData[2]}");
            }
        }

        public void BuyBook(User user, int bookID)
        {
            using (StreamWriter writer = File.AppendText(@"C:\Book_App\Book.cs\orders.txt"))
            {
                writer.WriteLine($"{user.ID},{bookID}");
            }
            Console.WriteLine($"Book ID {bookID} purchased by User ID: {user.ID}");
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                Admin admin = new Admin("admin@123.com", "admin-123");
                User user = new User("user@456.com", "pass-word");

                Books books = new Books();

                bool isAdminLoggedIn = false;
                while (!isAdminLoggedIn)
                {
                    Console.WriteLine("Enter email: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter password: ");
                    string password = Console.ReadLine();

                    if (email == admin.Email && password == admin.Password)
                    {
                        isAdminLoggedIn = true;

                        // Admin logged in - add a book
                        books.AddBook(admin, "Sample Book", "Sample Description");

                        // Display the book list
                        books.DisplayBooks();

                        // Simulate book purchase by user
                        Console.WriteLine("Enter the ID of the book you want to buy: ");
                        int bookID = int.Parse(Console.ReadLine());
                        books.OrderBook(user, bookID);
                    }
                    else
                    {
                        Console.WriteLine("Invalid credentials. Try again.");
                    }
                }
            }
        }
    }
}