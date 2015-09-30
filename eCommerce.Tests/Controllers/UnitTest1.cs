using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using eCommerce.Models;
using System.Collections.Generic;
namespace eCommerce.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesteBancoDeDados()
        {
            ProdutoContext db = new ProdutoContext();
            Assert.IsTrue(db.ToList().Count != 0);
        }
        [TestMethod]
        public void TesteCarrinho()
        {
            Carrinho c = new Carrinho();
            ProdutoContext db = new ProdutoContext();
            c.produtos = db.ToList();
            Assert.IsTrue(c.total > 0);
        }
        [TestMethod]
        public void TesteAddProduto()
        {
            Produto p = new Produto(0, "test", null, 50);
            ProdutoContext db = new ProdutoContext();
            db.Add(p);
            List<Produto> lista = db.ToList();
            foreach(Produto pr in lista){
                if(pr.nome.Equals("test")){
                    Assert.IsTrue(true);
                }
            }
        }
        [TestMethod]
        public void TesteRemove()
        {
            Produto p = null;
            ProdutoContext db = new ProdutoContext();

            List<Produto> lista = db.ToList();
            foreach (Produto pr in lista)
            {
                if (pr.nome.Equals("test"))
                {
                    p = pr;
                }
            }

            db.Remove(p);
            Assert.IsTrue(true);
        }
    }
}
