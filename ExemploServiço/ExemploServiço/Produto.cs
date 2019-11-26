using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ExemploServiço
{
    [DataContract]
    public class Produto
    {
        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public decimal Preco { get; set; }

        public int ID { get; set; }

        private int Versao { get; set; }

    }
}