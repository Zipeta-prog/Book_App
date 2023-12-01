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
    internal class UsersService : Iuser
    {

        private readonly HttpClient _httpClient;
        private readonly string URL = "http://localhost:3000/users";
        public UsersService() {
            _httpClient = new HttpClient();

        }

     

        public async Task<List<Users>> GetAllUsers()
        {
            var resp = await _httpClient.GetAsync(URL);

            var content = await resp.Content.ReadAsStringAsync();
            var UsersList = JsonConvert.DeserializeObject<List<Users>>(content);
          /*  if (resp.IsSuccessStatusCode && UsersList != null)
            {
               C
            }
            else
            {
                Console.WriteLine("error");
            }*/
            return UsersList;
        }

        public async Task RegisterUsers(Users user)
        {
            var content = JsonConvert.SerializeObject(user);

            var body = new StringContent(content, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(URL, body);

            if (response.IsSuccessStatusCode)

            {

                Console.WriteLine("REGISTERED SUCCESSFULLY");

            }
            else
            {
                Console.WriteLine("Error registering the user please Try again later!");
            }

        }
    }
}
