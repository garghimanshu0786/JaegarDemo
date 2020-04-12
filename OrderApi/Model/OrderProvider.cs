using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApi
{
    public class OrderProvider
    {
        public static List<Order> orders = new List<Order>
            {
                new Order(1, 250, "14-Apr-2020"),
                new Order(2, 450, "15-Apr-2020")
            };
    }
}
