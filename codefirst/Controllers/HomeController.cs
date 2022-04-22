using codefirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codefirst.Controllers
{
    public class HomeController : Controller
    {
        ProductContext db = new ProductContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult allproduct()
        {
            var data = db.products.ToList();
            return View(data);
        }
        public ActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProduct(Products pro)
        {
            db.products.Add(pro);
            db.SaveChanges();
            
            return RedirectToAction("allproduct");
        }
        public ActionResult CreateSale()
        {
            return View();

        }
        [HttpPost]
        public ActionResult CreateSale(sale s)
        {
            var saleqty = s.sale_qty;
            var saleitem = s.sale_product;
            var get_product = db.products.Where(x => x.productName == saleitem).FirstOrDefault();

            var prod_qty = get_product.qty;

            if ( saleqty < prod_qty )
            {
               var final= prod_qty - saleqty;
                //db.Entry(final).State = EntityState.Modified;
                get_product.qty = final;
                //db.Entry(final).State = EntityState.Modified;
                db.SaveChanges();
                db.Sales.Add(s);
                db.SaveChanges();
                return RedirectToAction("sale_list");
            }
            else
            {
                ViewBag.msg = "the product quntity is less then of your sale quntity";
                    return View();
            }
            //var final_qty = get_product.qty - saleqty;
           
        }
        public ActionResult sale_list()
        {
            var sale_data = db.Sales.ToList();

            return View(sale_data);
        }



        
    }
}