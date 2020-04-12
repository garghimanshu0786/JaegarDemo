using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : ControllerBase
    {
        public OrderController()
        {
        }


        [Route("{id}")]
        public Order GetOrder(int id)
        {
            return OrderProvider.orders.Find(user => user.OrderId == id);
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return OrderProvider.orders;
        }
    }





}
