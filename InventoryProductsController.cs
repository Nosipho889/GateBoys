using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IdentitySample.Models;
using Gateboys.Models;
using System.IO;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;




using System.Text;
using System.Net.Mail;
using System.Web.UI.WebControls;
using System.Collections;

namespace Gateboys.Controllers
{
    public class InventoryProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: InventoryProducts
        public ActionResult Index()
        {
            var products = db.Products.Include(i => i.Catalogues).Include(i => i.Categories).Include(i => i.Suppliers);
            return View(products.ToList());
        }

        // GET: InventoryProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventoryProduct inventoryProduct = db.Products.Find(id);
            if (inventoryProduct == null)
            {
                return HttpNotFound();
            }
            return View(inventoryProduct);
        }

        // GET: InventoryProducts/Create
        public ActionResult Create()
        {
            ViewBag.catalogueId = new SelectList(db.Catalogue_, "catalogueId", "catalogueName");
            ViewBag.categoryId = new SelectList(db.Category_, "categoryId", "categoryName");
            ViewBag.SupplierId = new SelectList(db.Suppliers, "supplierid", "supplierName");
            return View();
        }

        // POST: InventoryProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "productId,brandName,productName,productDescription,Image,ImageType,categoryId,catalogueId,SupplierId,quantityOnHand,unitPrice,DiscountPrice,totalPrice,onPromotion,status,quantityForQuote")] InventoryProduct inventoryProduct)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(inventoryProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.catalogueId = new SelectList(db.Catalogue_, "catalogueId", "catalogueName", inventoryProduct.catalogueId);
            ViewBag.categoryId = new SelectList(db.Category_, "categoryId", "categoryName", inventoryProduct.categoryId);
            ViewBag.SupplierId = new SelectList(db.Suppliers, "supplierid", "supplierName", inventoryProduct.SupplierId);
            return View(inventoryProduct);
        }

        // GET: InventoryProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventoryProduct inventoryProduct = db.Products.Find(id);
            if (inventoryProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.catalogueId = new SelectList(db.Catalogue_, "catalogueId", "catalogueName", inventoryProduct.catalogueId);
            ViewBag.categoryId = new SelectList(db.Category_, "categoryId", "categoryName", inventoryProduct.categoryId);
            ViewBag.SupplierId = new SelectList(db.Suppliers, "supplierid", "supplierName", inventoryProduct.SupplierId);
            return View(inventoryProduct);
        }

        // POST: InventoryProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "productId,brandName,productName,productDescription,Image,ImageType,categoryId,catalogueId,SupplierId,quantityOnHand,unitPrice,DiscountPrice,totalPrice,onPromotion,status,quantityForQuote")] InventoryProduct inventoryProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inventoryProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.catalogueId = new SelectList(db.Catalogue_, "catalogueId", "catalogueName", inventoryProduct.catalogueId);
            ViewBag.categoryId = new SelectList(db.Category_, "categoryId", "categoryName", inventoryProduct.categoryId);
            ViewBag.SupplierId = new SelectList(db.Suppliers, "supplierid", "supplierName", inventoryProduct.SupplierId);
            return View(inventoryProduct);
        }

        // GET: InventoryProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventoryProduct inventoryProduct = db.Products.Find(id);
            if (inventoryProduct == null)
            {
                return HttpNotFound();
            }
            return View(inventoryProduct);
        }

        // POST: InventoryProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InventoryProduct inventoryProduct = db.Products.Find(id);
            db.Products.Remove(inventoryProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
