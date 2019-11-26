using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExemploEntityFramework
{

    [Table("Produtos")]
    public class Produtos
    {
        public int  Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public Categoria CategoriaProduto { get; set; }
    }

    public class  Categoria
    {
        [Key]
        public int CategoriaId { get; set; }


        [MaxLength(100)]
        [Required]
        public string Nome { get; set; }

        public List<Produtos> Produtos { get; set; }
    }
}
