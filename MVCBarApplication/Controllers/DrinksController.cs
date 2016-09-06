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
    public class DrinksController : Controller
    {
        
        public ActionResult Menu()
        {
            DrinksContext drinksContext = new DrinksContext();
            Drinks[] drinks = drinksContext.Drinks.ToArray();
           
            return View(drinks);
        }

        public ActionResult Order(int id, string drinkName, string txtCustomerName)
        {
            string connectionString =
            ConfigurationManager.ConnectionStrings["DrinksContext"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramID = new SqlParameter();
                paramID.ParameterName = "@DrinkID";
                paramID.Value = id;
                cmd.Parameters.Add(paramID);

                SqlParameter paramDrinkName = new SqlParameter();
                paramDrinkName.ParameterName = "@DrinkName";
                paramDrinkName.Value = drinkName;
                cmd.Parameters.Add(paramDrinkName);

                SqlParameter paramOrderDate = new SqlParameter();
                paramOrderDate.ParameterName = "@OrderDate";
                paramOrderDate.Value = DateTime.Now;
                cmd.Parameters.Add(paramOrderDate);

                SqlParameter paramCustomerName = new SqlParameter();
                paramCustomerName.ParameterName = "@CustomerName";
                paramCustomerName.Value = "Test";
                cmd.Parameters.Add(paramCustomerName);

                con.Open();
                cmd.ExecuteNonQuery();


                return View();
            }
        }
    }
}