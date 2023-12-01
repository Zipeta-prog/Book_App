using BOOK_SYSTEM.Models;
using BOOK_SYSTEM.Services.Iservices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_SYSTEM.Services
{
    internal class OrderService : IOrder
    {
        private readonly HttpClient _httpClient;
        private readonly string URL = "http://localhost:3000/orders";

        public OrderService(){
            _httpClient = new HttpClient();
            }

        public async Task PostUserOrder(Orders orders)
        {
            var content = JsonConvert.SerializeObject(orders);

            var body = new StringContent(content, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(URL, body);

            if (response.IsSuccessStatusCode)

            {

                Console.WriteLine("ORDER PLACED SUCCESSFULLY");

            }
            else
            {
                Console.WriteLine("Error placing order,please Try again later!");
            }
        }
    }
}
