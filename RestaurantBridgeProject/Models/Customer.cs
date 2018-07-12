using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantBridgeProject.Models
{
    public class Customer
    {
        [Key]
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public string CustPhone { get; set; }
        public string FavMeal { get; set; }
        public string FavDrink { get; set; }
        public double LgstBill { get; set; }
        public virtual ICollection<Address>Addresses { get; set; }
    }
}