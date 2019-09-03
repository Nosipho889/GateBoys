using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GateBoys.Models
{
    public class Delivery
    {
        [Key]
        public int deliveryID { get; set; }
        public string deliveryType { get; set; }
        public double deliveryCost { get; set; }
        //public int driverID { get; set; }
        //public virtual Driver Driver { get; set; }
        public Delivery()
        {
            this.Status = "Available";
        }
        public string Status { get; set; }
    }
}