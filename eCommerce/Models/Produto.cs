using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerce.Models
{
    public class Produto
    {
        public int id {get; set;}
        public string nome {get; set;}
        public string detalhes {get; set;}
        public decimal preco {get; set;}
        public string imglink {get; set;}
        private string _idNumber;
        public string idNumber
        {
            get
            {
                switch (this.id)
                {
                    case (1):
                        _idNumber = "one";break;
                    case (2): 
                        _idNumber = "two"; break;
                    case (3):
                        _idNumber = "three"; break;
                    case (4):
                        _idNumber = "four"; break;
                    case (5):
                        _idNumber = "five"; break;
                    case (6):
                        _idNumber = "six"; break;
                    case (7):
                        _idNumber = "seven"; break;
                    case (8):
                        _idNumber = "eight"; break;
                    case (9):
                        _idNumber = "nine"; break;
                    default:
                        _idNumber = "one";
                        break;
                }
                return _idNumber; 
            }
            set{
                _idNumber = value;
            }
        }
        public Produto(){
            
        }
        public Produto(int id, string nome, string detalhes, decimal preco)
        {
            this.id = id;
            this.nome = nome;
            this.detalhes = detalhes;
            this.preco = preco;
            this.imglink = null;
        }
        public Produto(int id, string nome, string detalhes, decimal preco, string imglink):this(id, nome, detalhes, preco){
            this.imglink = imglink;
        }
    }
}