using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductManagementApp.Models;


namespace ProductManagementApp.Controllers
{
    public class ProductController : Controller
    {
        private ADOHelper helper = new ADOHelper();

        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            helper.AddProduct(product);
            return RedirectToAction("Index");
        }

        
        public ActionResult ViewProducts()
        {
            var products = helper.GetProducts();
            return View(products);
        }

        
        public ActionResult EditProduct(int id)
        {
            var product = helper.GetProducts().Find(p => p.ProductId == id);
            return View(product);
        }

        [HttpPost]
        public ActionResult EditProduct(Product product)
        {
            helper.UpdateProduct(product);
            return RedirectToAction("ViewProducts");
        }

        
        public ActionResult DeleteProduct(int id)
        {
            helper.DeleteProduct(id);
            return RedirectToAction("ViewProducts");
        }
    }
}
