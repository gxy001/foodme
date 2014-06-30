using foodme.server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace foodme.server.Controllers
{
    public class OrderController : ApiController
    {
        List<Order> orders = new List<Order>();

        //// GET api/order
        //public IEnumerable<Order> GetAllOrders()
        //{
        //    return orders;
        //}

        // POST api/order
        public Order PostNewOrder(Order item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            item.orderId = Math.Abs(DateTime.Now.ToBinary()).ToString();
            orders.Add(item);
            return item;
        }
    }
}
