using BOOK_SYSTEM.Models;
using BOOK_SYSTEM.Services.Iservices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_SYSTEM.Services
{
    internal class BookService : IBooks
    {
        private readonly HttpClient _httpClient;
        private readonly string URL = "http://localhost:3000/books";

        public BookService() {
            _httpClient = new HttpClient();
        }
        public async Task<List<Books>> GetAllAvailableBooks(String userID)
        {
            var resp = await _httpClient.GetAsync(URL);

            var content = await resp.Content.ReadAsStringAsync();
            var bookList = JsonConvert.DeserializeObject<List<Books>>(content);
            if (resp.IsSuccessStatusCode && bookList != null)
            {
                foreach (var book in bookList)
                {
                    Console.WriteLine($"{book.id}: {book.name}");
                    
                }
                Console.WriteLine("SELECT A BOOK YOU WANT TO BUY:");
                String user_Choice=Console.ReadLine();
                Orders orders = new Orders();
                orders.bookId = user_Choice;
                orders.userId=userID;
                OrderService orderService = new OrderService();
               await orderService.PostUserOrder(orders);

            }
            else
            {
                Console.WriteLine("error");
            }
            return bookList;
        }

       
    }
}
