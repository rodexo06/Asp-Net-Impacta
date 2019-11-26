using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploWebApi.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}