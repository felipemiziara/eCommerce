using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerce.Models
{
    public class Carrinho
    {
        public List<Produto> produtos = new List<Produto>();

        private decimal _total;
        public decimal total {
            get
            {
                _total = 0;
                foreach (Produto p in this.produtos)
                {
                    _total += p.preco;
                }
                return _total;
            }
        }

        public String ToString()
        {
            String resp = " ";
            foreach (Produto p in this.produtos)
            {
                resp += ", Produto: " + p.nome + ": " + p.detalhes;
            }
            return resp;
        }

    }
}