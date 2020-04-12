using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;

namespace UserService
{
    public class OrderDetailsProvider
    {
        public static async Task<OrderDetails> GetData()
        {
            List<Order> orders;
            User user;
            using (var httpClient = new HttpClient())
            {
                using (var response = httpClient.GetAsync("http://orderapi/orders").Result)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    orders = JsonConvert.DeserializeObject<List<Order>>(apiResponse);
                }
                using ( var response = httpClient.GetAsync("http://customerapi/user/1").Result)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    user = JsonConvert.DeserializeObject<User>(apiResponse);
                }
                return new OrderDetails { Orders = orders, User = user };
            }
        }
    }
}
