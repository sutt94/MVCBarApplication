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

        public ActionResult clearQueue()
        {
            string connectionString =
               ConfigurationManager.ConnectionStrings["OrdersContext"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spClearQueue", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();

                return View();
            }
        }

        public ActionResult remove(int id)
        {
            string connectionString =
               ConfigurationManager.ConnectionStrings["OrdersContext"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spRemove", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramID = new SqlParameter();
                paramID.ParameterName = "@OrderID";
                paramID.Value = id;
                cmd.Parameters.Add(paramID);

                con.Open();
                cmd.ExecuteNonQuery();

                return View();
            }
        }

    }
}