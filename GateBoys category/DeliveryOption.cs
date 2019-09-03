using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GateBoys.Models
{
    public class DeliveryOption
    {
        [Key]
        public string DeliveryTitle { get; set; }
        [DataType(DataType.Date)]
        public DateTime PickUpDate { get; set; }
        public bool Status { get; set; }
    }
//    public class DeliveryAddress
//    {
//        [Key]
//        public int DeliveryAddressId { get; set; }
//        [DataType(DataType.MultilineText)]
//        public string Address { get; set; }
//        public virtual Order orders { get; set; }
//    }
}