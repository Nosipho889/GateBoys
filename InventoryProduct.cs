using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IdentitySample.Models;
using System.IO;

namespace Gateboys.Models
{
    public class InventoryProduct
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; }

        [Required]
        [Display(Name = "Brand Name")]
        public string brandName { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string productName { get; set; }


        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        public string productDescription { get; set; }
        public byte[] Image { get; set; }
        public string ImageType { get; set; }
        [Required]
        public int categoryId { get; set; }
        public virtual Category_ Categories { get; set; }


        public int catalogueId { get; set; }
        public virtual Catalogue_ Catalogues { get; set; }


        public int SupplierId { get; set; }
        public virtual Supplier Suppliers { get; set; }



        [Required]
        [Display(Name = "Quantity ")]
        public int quantityOnHand { get; set; }

        [Display(Name = "Unit Price")]
        public decimal unitPrice { get; set; }

        [Display(Name = "Discount Price")]
        public decimal DiscountPrice { get; set; }

        [Display(Name = "Total Price")]
        public decimal totalPrice { get; set; }

        public bool onPromotion { get; set; }



        public string status { get; set; }
        [Display(Name = "Quote Quantity")]
        public int? quantityForQuote { get; set; }


        public InventoryProduct()
        {
            DiscountPrice = unitPrice;
        }
        public void AddProduct(string name, int count, decimal price, string supply)
        {






            var Category = db.Category_.Find(6);
            var Catalogue = db.Catalogue_.Find(1);
            var Supplier = db.Suppliers.Where(x => x.supplierName == supply).FirstOrDefault();
            if (Supplier == null)
            {
                Supplier = db.Suppliers.Find(1);
            }


            db.Products.Add(new InventoryProduct()
            {

                productName = name,
                quantityOnHand = count,
                quantityForQuote = count,
                unitPrice = price,
                brandName = "Enter Brand Name",
                Categories = Category,
                Catalogues = Catalogue,
                Suppliers = Supplier




            });
            db.SaveChanges();
        }
    }
}
    