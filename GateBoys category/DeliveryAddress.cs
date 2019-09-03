using IdentitySample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GateBoys.Models
{
    public class DeliveryAddress
    {
        [Key]
        public int DeliveryAddressId { get; set; }

        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        //

        [Display(Name = "Country")]
        public string country { get; set; }

        [Display(Name = "Street Number")]
        public string street_number { get; set; }
        [Display(Name = "Street Name")]
        public string route { get; set; }

        [Display(Name = "Province")]
        public string administrative_area_level_1 { get; set; }


        [Display(Name = "City")]
        public string locality { get; set; }

        [Display(Name = "Code")]
        public string postal_code { get; set; }

        public string adress { get; set; }

        public string addressCMBN()
        {
            string ad = (country + ", " + street_number + " " + route + " ," + administrative_area_level_1 + ", " + locality + ", " + postal_code);
            return ad;
        }
        public virtual Order orders { get; set; }

    }
}
