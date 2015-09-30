using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.Models;

namespace eCommerce.Controllers
{
    public class HomeController : Controller
    {
        public ProdutoContext db = new ProdutoContext();
        public ActionResult Index()
        {
            ViewBag.Message = "eCommerce";
            Catalogo c = new Catalogo();
            c.lista = db.ToList();
            return View(c);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
