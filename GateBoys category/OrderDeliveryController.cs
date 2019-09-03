using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GateBoys.Models;
using IdentitySample.Models;
//using GateBoys.Models;
//using netshSample.Models.NewModels;

namespace GateBoys.Controllers
{
    public class OrderDeliveryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Shipments
        //public ActionResult Index()
        //{
        //    var shipments = db.Shipments.Include(s => s.Driver).Include(s => s.Order);
        //    return View(shipments.ToList());
        //}

        //// GET: Shipments/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Shipment shipment = db.Shipments.Find(id);
        //    if (shipment == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(shipment);
        //}

        //// GET: Shipments/Create
        //public ActionResult Create()
        //{
        //    ViewBag.driverID = new SelectList(db.Drivers, "driverID", "FirstName");
        //    ViewBag.orderID = new SelectList(db.Orders, "OrderId", "OrderNumber");
        //    return View();
        //}

        //// POST: Shipments/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "shipmentID,orderID,driverID,deliveryType,deliveryDate,expectedDate,Status")] Shipment shipment)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (shipment.deliveryType == "24 Hours Delivery")
        //        {
        //            shipment.expectedDate = DateTime.Now.AddHours(24);
        //        }
        //        else if (shipment.deliveryType == "2 Days Delivery")
        //        {
        //            shipment.expectedDate = DateTime.Now.AddDays(2);
        //        }
        //        else if (shipment.deliveryType == "4 Days Delivery")
        //        {
        //            shipment.expectedDate = DateTime.Now.AddDays(4);
        //        }
        //        shipment.deliveryDate = DateTime.Now;
        //        shipment.Status = "On The Way";

        //        db.Shipments.Add(shipment);
        //        db.SaveChanges();

        //        var order = new Order();
        //        var st = db.Orders.ToList().Find(s => s.OrderNumber == shipment.Order.OrderNumber).ToString();

        //        if (shipment.Order.OrderNumber == st)
        //        {
        //            //order.Status = "Delivered";
        //            db.SaveChanges();
        //        }

        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.driverID = new SelectList(db.Drivers, "driverID", "FirstName", shipment.driverID);
        //    ViewBag.orderID = new SelectList(db.Orders, "OrderId", "OrderNumber", shipment.orderID);
        //    return View(shipment);
        //}

        //// GET: Shipments/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Shipment shipment = db.Shipments.Find(id);
        //    if (shipment == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.driverID = new SelectList(db.Drivers, "driverID", "FirstName", shipment.driverID);
        //    ViewBag.orderID = new SelectList(db.Orders, "OrderId", "OrderNumber", shipment.orderID);
        //    return View(shipment);
        //}

        //// POST: Shipments/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "shipmentID,orderID,driverID,deliveryType,deliveryDate,expectedDate,Status")] Shipment shipment)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(shipment).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.driverID = new SelectList(db.Drivers, "driverID", "FirstName", shipment.driverID);
        //    ViewBag.orderID = new SelectList(db.Orders, "OrderId", "OrderNumber", shipment.orderID);
        //    return View(shipment);
        //}

        //// GET: Shipments/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Shipment shipment = db.Shipments.Find(id);
        //    if (shipment == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(shipment);
        //}

        //// POST: Shipments/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Shipment shipment = db.Shipments.Find(id);
        //    db.Shipments.Remove(shipment);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
