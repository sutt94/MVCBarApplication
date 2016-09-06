using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCBarApplication.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        public int DrinkID { get; set; }
        public String DrinkName { get; set; }
        public String Date { get; set; }
        public String CustomerName { get; set; }
    }
}