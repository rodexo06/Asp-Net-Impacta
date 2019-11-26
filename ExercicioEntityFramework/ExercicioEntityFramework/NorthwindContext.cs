using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ExercicioEntityFramework
{
    public class NorthwindContext:DbContext
    {
        private const string conexao = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Northwind; Integrated Security = True";

        public NorthwindContext() : base(conexao)
        {

        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}