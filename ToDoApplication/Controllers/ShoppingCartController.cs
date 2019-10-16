using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ToDoApplication.Models;
using ToDoApplication.ViewModels;

namespace ToDoApplication.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OrderNow(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if(Session["Cart"] == null)
            {               
                List<Cart> lsCart = new List<Cart>();
                var d = db.ToDo.Find(id);
                lsCart.Add(new Cart(d,1));
                Session["Cart"] = lsCart;
            }
            else
            {
                List<Cart> lsCart = (List<Cart>)Session["Cart"];
                var d = db.ToDo.Find(id);
                lsCart.Add(new Cart(d, 1));
                Session["Cart"] = lsCart;
            }
            return View();
        }
    }
}