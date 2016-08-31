using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCBarApplication.Models
{   [Table("Drinks")]
    public class Drinks
    {
        [Key]
        public int DrinkID { get; set; }
        public String DrinkName { get; set; }
        public String DrinkDescription { get; set; }
        public int DrinkPrice { get; set; }



    }
}