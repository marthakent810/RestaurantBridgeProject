using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantBridgeProject.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpEmail { get; set; }
        public string EmpPhone { get; set; }
        public int EmpNum { get; set; }
        public string EmergName { get; set; }
        public string EmergNum { get; set; }
        public string DateStart { get; set; }
    }
}