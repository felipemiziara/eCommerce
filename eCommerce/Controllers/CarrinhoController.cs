using eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class CarrinhoController : Controller
    {
        //
        // GET: /Carrinho/

        public ActionResult Index()
        {
            Carrinho carrinho = (Carrinho)Session["carrinho"];
            if (carrinho == null)
            {
                carrinho = new Carrinho();
            }

            return View("Index", carrinho);
        }

        //
        // GET: /Carrinho/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Carrinho/Add/5

        public ActionResult Add( int i)
        {
            Carrinho carrinho = (Carrinho)Session["carrinho"];
            ProdutoContext db = new ProdutoContext();
            if (carrinho == null)
            {
                carrinho = new Carrinho();
            }

            if(i != 0){
                Produto p = db.Find(i);
                carrinho.produtos.Add(p);
                Session["carrinho"] = carrinho;
            }
            return View("Index", carrinho);
        }

        //
        // POST: /Carrinho/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Carrinho/Edit/5

        public ActionResult Finalizar()
        {
            CarrinhoContext db = new CarrinhoContext();


            db.Add((Carrinho)Session["carrinho"]);

            return RedirectToAction("Index", "Home");
        }

        //
        // POST: /Carrinho/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Carrinho/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Carrinho/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
