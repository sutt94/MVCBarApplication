using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBarApplication.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MVCBarApplication.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult OrderQueue()
        {
            OrdersContext ordersContext = new OrdersContext();
            Orders[] orders = ordersContext.Orders.ToArray();
            return View(orders);
            
        }
    }
}