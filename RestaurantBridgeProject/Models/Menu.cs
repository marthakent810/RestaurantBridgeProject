using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantBridgeProject.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        public string Selection { get; set; }
        public double Price { get; set; }
    }
}