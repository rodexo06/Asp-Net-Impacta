using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExercicioEntityFramework
{
    [Table("Categories", Schema = "dbo")]
    public class Categoria
    {
        [Key, Column("CategoryId")]
        public int CategoriaId { get; set; }

        [MaxLength(100), Required, Column("CategoryName")]
        public string Nome { get; set; }    
    }

    [Table("Products", Schema = "dbo")]
    public class Produto
    {
        [Key, Column("ProductId")]
        public int ProdutoId { get; set; }

        [MaxLength(100), Required, Column("ProductName")]
        public string Nome { get; set; }

        [Column("UnitPrice")]
        public decimal Preco { get; set; }

        [Column("UnitsInStock")]
        public Int16 Estoque { get; set; }

        [Column("CategoryId"), ForeignKey("Categoria")]
        public int CategoriaId { get; set; }

        [Column("SupplierID"), ForeignKey("Fornecedor")]
        public int FornecedorId { get; set; }

        public Categoria Categoria { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }

    [Table("Suppliers", Schema = "dbo")]
    public class Fornecedor
    {
        [Key, Column("SupplierID")]
        public int FornecedorId { get; set; }

        [MaxLength(100), Required, Column("CompanyName")]
        public string Nome { get; set; }
    }
}